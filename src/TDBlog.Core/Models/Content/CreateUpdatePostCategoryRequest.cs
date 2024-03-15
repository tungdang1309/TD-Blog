using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDBlog.Core.Domain.Content;
using TDBlog.Core.Domain.Identity;
using TDBlog.Core.Models.System;

namespace TDBlog.Core.Models.Content
{
    public class CreateUpdatePostCategoryRequest
    {
        [MaxLength(250)]
        public required string Name { get; set; }
        [Column(TypeName = "varchar(250)")]
        public required string Slug { get; set; }
        public Guid? ParentId { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string? SeoDescription { get; set; }
        public string? SortOrder { get; set; }
        public class AutoMapperProfiles : Profile
        {
            public AutoMapperProfiles()
            {
                CreateMap<CreateUpdatePostCategoryRequest, PostCategory>();
            }
        }
    }
}
