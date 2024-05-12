using AutoMapper;
using Domain.Dtos;
using Domain.Dtos.IdentityRole;
using Identity.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    public class AccountsRoleController : ControllerBase
    {
        private readonly IUserRole _userRole;
        private readonly IMapper _mapper;
        public AccountsRoleController(IUserRole userRole, IMapper mapper)
        {

            _userRole = userRole; _mapper = mapper;
        }
        [HttpGet("role")]
        public async Task<ActionResult<ResponseDto<List<IdentityRole>>>> GetRoles()
        {
            ResponseDto<List<RoleDto>> response = new ResponseDto<List<RoleDto>>();
            response.Dados = new List<RoleDto>();
            try
            {
                var result = await _userRole.GetRoles();
                if (result == null)
                {
                    response.Mensagem = $"N�o foi poss�vel consultar fun��es";
                    response.Status = false;
                    return BadRequest(response);
                }

                var dto = _mapper.Map<List<RoleDto>>(result.ToList());

                response.Dados = dto;
                response.Status = true;
                response.Mensagem = $"Consulta realizada com sucesso!Localizadas: {response.Dados.Count}";

                return Ok(response);
            }
            catch (Exception ex)
            {
                response.Mensagem = $"Erro.Detalhes: {ex.Message}";
                response.Status = false;
                return BadRequest(response);
            }
        }

        [HttpPost("role/add-role-user")]
        public async Task<ActionResult<ResponseDto<bool>>> AddRole(UserRoleDtoAdd user)
        {
            ResponseDto<string> response = new ResponseDto<string>();
            try
            {
                var result = await _userRole.AddRole(user.PessoaId, user.RoleId);

                if (result)
                {
                    response.Mensagem = $"Fun��o aplicada.";
                    response.Status = true;
                    response.Dados = $"Fun��o aplicada com sucesso! Usu�rio tem a permiss�o atribu�da.";
                    return Ok(response);
                }

                response.Mensagem = $"N�o foi poss�vel criar.";
                response.Status = false;
                response.Dados = $"N�o foi poss�vel criar.";

                return BadRequest(response);
            }
            catch (Exception ex)
            {
                response.Mensagem = $"Erro.Detalhes: {ex.Message}.";
                response.Status = false;
                return BadRequest(response);
            }
        }

        [HttpPost("role/create")]
        public async Task<ActionResult<ResponseDto<string>>> CreateRole(RoleDtoCreate role)
        {
            ResponseDto<string> response = new ResponseDto<string>();

            try
            {
                bool result = await _userRole.CreateRole(role.RoleName);
                if (result)
                {
                    response.Mensagem = $"Fun��o {role.RoleName.ToLower()} criada com sucesso.";
                    response.Status = true;
                    response.Dados = $"Adicionar fun��es aos usu�rios.";
                    return Ok(response);
                }

                response.Mensagem = $"N�o foi poss�vel criar.";
                response.Status = false;
                response.Dados = $"N�o foi poss�vel criar.";

                return BadRequest(response);
            }
            catch (Exception ex)
            {
                response.Mensagem = $"Erro.Detalhes: {ex.Message}";
                response.Status = false;
                response.Dados = $"Erro ao Executar Operacao.";
                return BadRequest(response);
            }
        }
    }
}
