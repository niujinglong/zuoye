using AutoMapper;
using RbacRepository;
using RbacRepository.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RbacApplication.Admin
{
    public class AdminService : BaseService<Rbac.Entity.Admin, AdminDto>, IAdminService
    {
        private readonly IAdminDto baseService;

        public AdminService(IAdminDto baseService, IMapper mapper) : base(baseService, mapper)
        {
            this.baseService = baseService;
        }
    }
}
