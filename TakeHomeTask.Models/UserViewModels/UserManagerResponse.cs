using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TakeHome.Models.UserViewModels
{
    public class UserManagerResponse
    {
        public string Message { get; set; }
        public bool Succeeded { get; set; }
        public IEnumerable<string> Errors { get; set; }
        public DateTime? ExpireDate { get; set; }
    }
}
