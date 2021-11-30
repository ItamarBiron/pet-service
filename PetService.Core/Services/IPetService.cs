using System;
using System.Threading.Tasks;

namespace PetService.Core.Services
{
    public interface IPetService
    {
        /// <summary>
        /// Get all <see cref="Pets"/ in DB>
        /// </summary>
        /// <returns></returns>
        public Task<String> GetAllPetsAsync();
    }
}