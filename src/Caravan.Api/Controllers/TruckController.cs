﻿using Caravan.Service.Common.Utils;
using Caravan.Service.Dtos.Trucks;
using Caravan.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Caravan.Api.Controllers
{
    [Route("api/trucks")]
    [ApiController]
    public class TruckController : ControllerBase
    {
        private readonly ITruckService _service;
        private readonly int pageSize = 20;
        public TruckController(ITruckService truckService)
        {
            this._service = truckService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync(int page)
            => Ok(await _service.GetAllAsync(new PaginationParams(page, pageSize)));

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromForm] TruckCreateDto dto)
            => Ok(await _service.CreateAsync(dto));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(long id)
            => Ok(await _service.GetAsync(id));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(long id)
            => Ok(await _service.DeleteAsync(id));

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(long id, [FromForm] TruckCreateDto truckCreateDto)
            => Ok(await _service.UpdateAsync(id, truckCreateDto));
    }
}
