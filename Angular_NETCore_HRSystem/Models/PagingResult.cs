using System.Collections.Generic;

namespace Angular_ASPNETCore_CustomersService.Models
{
  public struct PagingResult<T>
  {
    public IEnumerable<T> Records { get; set; }
    public int TotalRecords { get; set; }

    public PagingResult(IEnumerable<T> items, int totalRecords)
    {
      TotalRecords = totalRecords;
      Records = items;
    }
  }
}
