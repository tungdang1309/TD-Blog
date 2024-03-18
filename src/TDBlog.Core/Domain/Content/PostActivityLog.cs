﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDBlog.Core.Domain.Content
{
    [Table("PostActibityLogs")]
    public class PostActivityLog
    {
        [Key]
        public Guid Id { get; set; }
        public Guid PostId { get; set; }
        public PostStatus FromStatus { get; set; }
        public PostStatus ToStatus {  get; set; }
        public DateTime DateCreated { get; set; }
        [MaxLength(500)]
        public string? Note { get; set; }
        public Guid UserId { get; set; }
        [MaxLength(250)]
        public string UserName { get; set; }

    }
}
