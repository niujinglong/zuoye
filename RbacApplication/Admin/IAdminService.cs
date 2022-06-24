using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rbac.Entity;

namespace RbacApplication.Admin
{
    public interface IAdminService:IBaseService<Rbac.Entity.Admin, AdminDto>
    {
    }
}
