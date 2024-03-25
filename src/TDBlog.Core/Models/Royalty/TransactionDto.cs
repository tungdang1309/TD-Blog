﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDBlog.Core.Domain.Royalty;

namespace TDBlog.Core.Models.Royalty
{
    public class TransactionDto
    {
        public Guid Id { get; set; }
        public required string FromUserName { get; set; }
        public Guid FromUserId { get; set; }
        public Guid ToUserId { get; set; }

        public required string ToUserName { get; set; }
        public double Amount { get; set; }
        public TransactionType TransactionType { get; set; }
        public DateTime DateCreated { get; set; }

        public string? Note { get; set; }

        public class AutoMapperProfiles : Profile
        {
            public AutoMapperProfiles()
            {
                CreateMap<Transaction, TransactionDto>();
            }
        }
    }
}
