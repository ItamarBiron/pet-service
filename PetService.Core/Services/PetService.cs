using System.Threading.Tasks;

namespace PetService.Core.Services
{
    public class PetService : IPetService
    {
        public Task<string> GetAllPetsAsync()
        {
            return Task.Run(() => "test");
        }
    }
}