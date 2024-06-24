﻿using Easy.Services.CQRS.User.Command;
using Easy.Services.CQRS.UserMasterCliente.Command;
using Easy.Services.CQRS.UserMasterUser.Command;
using Easy.Services.DTOs;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Easy.Api.Controllers;

[Route("[controller]")]
[ApiController]
[Authorize]
public class AccountUserMasterUserController : ControllerBase
{
    private readonly IMediator _mediator;
    public AccountUserMasterUserController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [AllowAnonymous]
    [HttpPost]
    public async Task<ActionResult<RequestResult>> CadastrarUsuario([FromBody] UserMasterUserCreateCommand command)
    {
        return await _mediator.Send(command);
    }

}