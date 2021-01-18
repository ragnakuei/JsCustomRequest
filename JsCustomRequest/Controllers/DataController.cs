using System.Threading.Tasks;
using JsCustomRequest.Models;
using Microsoft.AspNetCore.Mvc;

namespace JsCustomRequest.Controllers
{
    [Route("api/[Controller]/[Action]")]
    public class DataController : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GetData01()
        {
            await Task.Delay(1000);

            return Ok(new ResponseDto
                      {
                          Data = "Data01",
                          Message = "Success-Data01",
                      });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GetData02()
        {
            await Task.Delay(2000);

            return Ok(new ResponseDto
                      {
                          Data    = "Data02",
                          Message = "Success-Data02",
                      });
        }
    }
}
