﻿using Caravan.DataAccess.DbContexts;
using Caravan.Domain.Entities;
using Caravan.Service.Dtos;
using Caravan.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan.Service.Interfaces
{
    public interface IOrderService
    {
        public Task<IEnumerable<Order>> GetAllAsync();
        public Task<OrderViewModel> GetAsync(long id);
        public Task<bool> UpdateAsync(long id,OrderCreateDto updateDto);
        public Task<bool> DeleteAsync(long id);
        public Task<bool> CreateAsync(OrderCreateDto createDto);
    }
}
