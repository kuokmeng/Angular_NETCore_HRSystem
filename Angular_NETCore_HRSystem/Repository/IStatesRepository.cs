using Angular_ASPNETCore_CustomersService.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Angular_ASPNETCore_CustomersService.Repository
{
  public interface IStatesRepository
  {
    Task<List<State>> GetStatesAsync();
  }
}