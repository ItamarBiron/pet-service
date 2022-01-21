using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetService.Core.Services
{
    public class PetService : IPetService
    {
        public Task<string> GetAllPetsAsync()
        {
            throw new KeyNotFoundException();
            return Task.Run(() => "test");
        }
    }
}