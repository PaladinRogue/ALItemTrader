using System;
using System.Collections.Generic;
using ALItemTrader.Api.Resources.Admin;
using ALItemTrader.Application.Admin.Interfaces;
using ALItemTrader.Application.Admin.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ALItemTrader.Api.Controllers
{
    [Route("api/[controller]")]
    public class AdminController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAdminApplicationService _adminApplicationService;

        public AdminController(IMapper mapper, IAdminApplicationService adminApplicationService)
        {
            _adminApplicationService = adminApplicationService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return new ObjectResult(
                _mapper.Map<IList<AdminAdto>, IList<AdminResource>>(_adminApplicationService.GetAdmins())
            );
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            return new ObjectResult(
                _mapper.Map<AdminAdto, AdminResource>(_adminApplicationService.GetAdminById(Guid.Empty))
            ); 
        }
    }
}
