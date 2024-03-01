using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDBlog.Core.Domain.Content
{
    [Table("PostInSeries")]
    [Index(nameof(PostId), IsUnique = true)]
    public class PostInSeries
    {
        public Guid PostId { get; set; }
        public Guid Series { get; set; }
        public int DisplayOrder { get; set; }
    }
}
