using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDBlog.Data.SeedWorks
{
    public interface IUnitOfWork
    {
        Task<int> Complate();
    }
}
