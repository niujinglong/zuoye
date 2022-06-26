using Rbac.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RbacApplication.Admin
{
    public class AdminDto : BaseClass
    {
        public long AdminId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public string LastLoginIP { get; set; }
        public byte IsLock { get; set; }
    }
}
