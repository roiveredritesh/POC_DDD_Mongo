﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIControllerBase : ControllerBase
    {
        private ISender _mediator;

        protected ISender Mediator=>_mediator??=HttpContext.RequestServices.GetRequiredService<ISender>();
    }
}
