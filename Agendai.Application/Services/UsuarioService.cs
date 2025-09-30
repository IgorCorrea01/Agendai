using Agendai.Application.Contracts.Services;
using Agendai.Application.DTOs.Request;
using Agendai.Application.DTOs.Response;
using Agendai.Application.Utils.Hash;
using Agendai.Domain.Entities;
using Agendai.Domain.Repositories;
using AutoMapper;

namespace Agendai.Application.Services
{
    public sealed class UsuarioService : IUsuarioService
    {

        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;

        public UsuarioService(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }

        public async Task<UsuarioResponse> LoginAsync(LoginRequest login)
        {
            var usuario = await _usuarioRepository.GetByEmailAsync(login.Email);

            if (usuario == null || !PasswordHash.VerifyPassword(login.Senha, usuario.SenhaHash))
                throw new Exception("Usuário ou senha inválidos.");

            return _mapper.Map<UsuarioResponse>(usuario);
        }

        public async Task AddAsync(RegistroRequest usuarioRequest)
        {
            var existente = await _usuarioRepository.GetByEmailAsync(usuarioRequest.Email);

            if (existente != null)
                throw new Exception("Usuário já cadastrado com este e-mail.");

            var usuario = _mapper.Map<Usuario>(usuarioRequest);
            usuario.AtualizarSenha(PasswordHash.CryptPassword(usuarioRequest.SenhaHash));

            await _usuarioRepository.AddAsync(usuario);
        }

        public async Task DeleteAsync(Guid id)
        {
            var existente = await _usuarioRepository.GetByIdAsync(id);
            if (existente == null)
                throw new Exception("Usuário não encontrado.");

            await _usuarioRepository.DeleteAsync(existente);
        }

        public async Task<IEnumerable<UsuarioResponse>> GetAllAsync()
        {
            var users = await _usuarioRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<UsuarioResponse>>(users);
        }

        public async Task<UsuarioResponse> GetByEmailAsync(string email)
        {
            var usuario = await _usuarioRepository.GetByEmailAsync(email);
            if (usuario == null)
                throw new Exception("Usuário não encontrado.");

            return _mapper.Map<UsuarioResponse>(usuario);
        }

        public async Task<UsuarioResponse> GetByIdAsync(Guid id)
        {
            var usuario = await _usuarioRepository.GetByIdAsync(id);
            if (usuario == null)
                throw new Exception("Usuário não encontrado.");

            return _mapper.Map<UsuarioResponse>(usuario);
        }

        public async Task UpdateAsync(Guid id, RegistroRequest usuarioRequest)
        {
            var existente = await _usuarioRepository.GetByIdAsync(id);
            if (existente == null)
                throw new Exception("Usuário não encontrado.");

            if (!string.Equals(existente.Nome, usuarioRequest.Nome, StringComparison.OrdinalIgnoreCase))
                existente.AlterarNome(usuarioRequest.Nome);

            if (!string.Equals(existente.Email, usuarioRequest.Email, StringComparison.OrdinalIgnoreCase))
                existente.AlterarEmail(usuarioRequest.Email);

            if (!PasswordHash.VerifyPassword(usuarioRequest.SenhaHash, existente.SenhaHash))
                existente.AtualizarSenha(PasswordHash.CryptPassword(usuarioRequest.SenhaHash));

            await _usuarioRepository.UpdateAsync(existente);
        }
    }
}
