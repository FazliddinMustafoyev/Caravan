﻿using Caravan.Domain.Entities;
using Caravan.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan.Service.Interfaces
{
    public interface IUserService
    {
        public Task<IEnumerable<UserViewModel>> GetAllAysnc();
        public Task<User> GetAsync(int id);
        public Task<bool> UpdateAsync(int id, UserViewModel entity);
        public Task<bool> DeleteAsync(int id);
    }
}
