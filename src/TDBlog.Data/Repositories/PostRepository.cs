﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDBlog.Core.Domain.Content;
using TDBlog.Core.Models;
using TDBlog.Core.Models.Content;
using TDBlog.Core.Repositories;
using TDBlog.Data.SeedWorks;

namespace TDBlog.Data.Repositories
{
    public class PostRepository : RepositoryBase<Post, Guid>, IPostRepository
    {
        private readonly IMapper _mapper;
        public PostRepository(TDBlogContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public Task<List<Post>> GetPopularPostAsync(int count)
        {
           return _context.Posts.OrderByDescending(x=> x.ViewCount).Take(count).ToListAsync();
        }

        public async Task<PagedResult<PostInListDto>> GetPostsPagingAsync(string? keyword, Guid? categoryId, int pageIndex = 1, int pageSize = 10)
        {
            var query = _context.Posts.AsQueryable();
            if(!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => x.Name.Contains(keyword));
            }
            if(categoryId.HasValue)
            {
                query = query.Where(x => x.CategoryId == categoryId.Value);
            }
            var totalRow = await query.CountAsync();
            query = query.OrderByDescending(x => x.DateCreated)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize);
            return new PagedResult<PostInListDto>
            {
                Results = await _mapper.ProjectTo<PostInListDto>(query).ToListAsync(),
                CurrentPage = pageIndex,
                RowCount = totalRow,
                PageSize = pageSize,
            };
        }
    }
}
