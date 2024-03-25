using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDBlog.Core.Domain.Royalty;
using TDBlog.Core.Models.Content;
using TDBlog.Core.Models;
using TDBlog.Core.SeedWorks;
using TDBlog.Core.Models.Royalty;

namespace TDBlog.Core.Repositories
{
    public interface ITransactionRepository : IRepository<Transaction,Guid>
    {
        Task<PagedResult<TransactionDto>> GetAllPaging(string? userName,
            int fromMonth,int fromYear, int toMonth, int toYear, int pageIndex = 1, int pageSize = 10);
    }
}
