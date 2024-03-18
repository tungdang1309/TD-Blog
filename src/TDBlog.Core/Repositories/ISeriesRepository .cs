using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDBlog.Core.Models.Content;
using TDBlog.Core.Models;
using TDBlog.Core.SeedWorks;
using TDBlog.Core.Domain.Content;

namespace TDBlog.Core.Repositories
{
    public interface ISeriesRepository : IRepository<Series, Guid>
    {
        Task<PagedResult<SeriesInListDto>> GetAllPaging(string? keyword, int pageIndex = 1, int pageSize = 10);
        Task AddPostToSeries(Guid seriesId, Guid postId, int sortOrder);
        Task RemovePostToSeries(Guid seriesId, Guid postId);
        Task<List<PostInListDto>> GetAllPostsInSeries(Guid seriesId);
        Task<bool> IsPostInSeries(Guid seriesId, Guid postId);
    }
}
