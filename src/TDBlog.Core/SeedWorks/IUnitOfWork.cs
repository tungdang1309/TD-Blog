using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDBlog.Core.Repositories;

namespace TDBlog.Data.SeedWorks
{
    public interface IUnitOfWork
    {
        IPostRepository Posts { get; }
        IPostCategoryRepository PostCategories { get; }
        ISeriesRepository Series { get; }
        Task<int> CompleteAsync();
    }
}
