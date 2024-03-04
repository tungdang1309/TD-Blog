using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDBlog.Core.Domain.Content;

namespace TDBlog.Core.Models.Content
{
    public class CreateUpdatePostRequest
    {
        public Guid CategoryId { get; set; }

        public string? Content { get; set; }


        public string? Source { get; set; }

        public string? Tags { get; set; }

        public string? SeoDescription { get; set; }
        public required string Name { get; set; }

        public required string Slug { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        public string? Thumbnail { get; set; }
        public required string CategorySlug { set; get; }
        public required string CategoryName { set; get; }
        public string AuthorUserName { set; get; }
        public string AuthorName { set; get; }
        public class AutoMapperProfiles : Profile
        {
            public AutoMapperProfiles()
            {
                CreateMap<CreateUpdatePostRequest, Post>();
            }
        }

    }
}
