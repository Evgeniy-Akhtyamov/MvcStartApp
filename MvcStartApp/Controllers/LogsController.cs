using Microsoft.AspNetCore.Mvc;
using MvcStartApp.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcStartApp.Controllers
{
    public class LogsController : Controller
    {
        private readonly IBlogRepository _repo;

        public LogsController(IBlogRepository repo)
        {
            _repo = repo;
        }       
        
        public async Task<IActionResult> Index()
        {
            var requests = await _repo.GetRequests();
            return View(requests);
        }  
    }
}
