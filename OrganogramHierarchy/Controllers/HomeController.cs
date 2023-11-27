using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganogramHierarchy.Data;
using OrganogramHierarchy.Models;
using System.Diagnostics;

namespace OrganogramHierarchy.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _context.OrganogramMasters.Select(x => new OrganogramMasterVm
            {
                Id = x.Id,
                parentName = x.parentName,
                parentCode = x.parentCode,
                parentId = x.parentId,
                type = x.type,
                imgUrl = x.imgUrl
            }).AsNoTracking().ToListAsync();

            return View(data);
        }

        [HttpGet("/api/OrganogramApi")]
        [AllowAnonymous]
        public async Task<IActionResult> OrganogramApi()
        {
            var data = await _context.OrganogramMasters.Select(x => new OrganogramMasterVm
            {
                Id = x.Id,
                parentName = x.parentName,
                parentCode = x.parentCode,
                parentId = x.parentId,
                type = x.type,
                imgUrl = x.imgUrl
            }).AsNoTracking().ToListAsync();

            return Json(data);
        }
        public JsonResult OrganogramGroupApi(int branchId)
        {
            var data = _context.OrganogramMasters.Select(x => new OrganogramMasterVm
            {
                Id = x.Id,
                parentName = x.parentName,
                parentCode = x.parentCode,
                parentId = x.parentId,
                type = x.type,
                imgUrl = x.imgUrl
            }).AsNoTracking().ToList();

            return Json(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
