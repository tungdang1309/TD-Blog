using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDBlog.Core.Models.Auth
{
    public class AuthenticateResult
    {
        public required string Token {  get; set; }
        public required string RefreshToken { get; set; }
    }
}
