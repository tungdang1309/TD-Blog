using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TDBlog.Core.Domain.Content
{
    [Table("PostCategories")]
    [Index(nameof(Slug), IsUnique = true)]
    public class PostCategory
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public required string Name { get; set; }
        [Column(TypeName = "nvarchar(250)")]

        public required string Slug { get; set; }
        public Guid? ParentId { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string? SeoKeywords { get; set; }
        [MaxLength(160)]
        public string? SeoDescription { get; set; }
        public string? SortOrder { get; set; }
    }
}
