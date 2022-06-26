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
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        ResultDto Register(AdminDto dto);
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        TokenDto Login(LoginDto dto);
    }
}
