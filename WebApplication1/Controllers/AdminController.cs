using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RbacApplication.Admin;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService adminService;

        public AdminController(IAdminService adminService)
        {
            this.adminService = adminService;
        }

        [HttpPost]
        public IActionResult Add(AdminDto dto)
        {
            return Ok(adminService.Add(dto));
        }

        [HttpGet]
        public IActionResult Show()
        {
            return new JsonResult(adminService.GetAll());
        }

        [HttpGet]
        public IActionResult GeiId(int id)
        {
            return new JsonResult(adminService.GetById(id));
        }

        [HttpDelete]
        public IActionResult Del(int id)
        {
            return Ok(adminService.Delete(id));
        }

        [HttpPut]
        public IActionResult Upd(AdminDto r)
        {
            return Ok(adminService.Update(r));
        }
    }
}
