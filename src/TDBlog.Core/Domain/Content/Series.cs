using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDBlog.Core.Domain.Content
{
    [Table("Series")]
    [Index(nameof(Slug), IsUnique = true)]
    public class Series
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(250)]
        public required string Name { get; set; }
        public string? Description { get; set; }
        [Column(TypeName ="nvarchar(250)")]
        public required string Slug { get; set; }
        public bool IsActive { get; set; }
        public int SortOrder {  get; set; }
        [MaxLength(250)]
        public string? SeoDescription { get; set; }
        [MaxLength(250)]
        public string? Thumbnail { get; set; }
        public string? Content {  get; set; }
        public Guid AuthorUserId { get; set; }
        public DateTime DateCreated { get; set; }

    }
}
