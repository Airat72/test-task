using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YourNamespace.Data;
using YourNamespace.Models;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace YourNamespace.Controllers
{
    public class LogsController : Controller
    {
        private readonly LogsDbContext _context;

        public LogsController(LogsDbContext context)
        {
            _context = context;
        }

       
        public IActionResult Index()
        {
            return View(); 
        }


        [HttpGet]



    public async Task<IActionResult> GetLogs(
    string user = null,
    string dateTime = null,
    int? recordType = null)
{
    var query = _context.Logs.AsQueryable();

    if (!string.IsNullOrEmpty(user))
        query = query.Where(log => log.User.Contains(user));

    if (!string.IsNullOrEmpty(dateTime) && DateTime.TryParse(dateTime, out var dt))
        query = query.Where(log => log.DateTime.Date == dt.Date);

    if (recordType.HasValue)
        query = query.Where(log => (int)log.RecordType == recordType.Value);

    var logs = await query.ToListAsync();

    return Json(logs);
}
    }
}