using ClassLibraryEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RbacRepository.Admin
{
    public class AdminDto:BaseDTO<Rbac.Entity.Admin,int>,IAdminDto
    {
        public AdminDto(MyDbContext db)
        {
            this.db = db;
        }
    }
}
