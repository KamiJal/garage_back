using garage_back.Models;
using System.Collections.Generic;

namespace garage_back.Persistence
{
    public interface IRepository
    {
        List<Warehouse> GetAllWarehouses();
    }
}
