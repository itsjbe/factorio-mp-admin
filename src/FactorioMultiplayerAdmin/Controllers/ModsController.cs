using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FactorioMultiplayerAdmin.Controllers
{
    [Route("api/[controller]")]
    public class ModsController : Controller
    {
        const string ModsPath = "/opt/factorio/saves";

        readonly DirectoryInfo modsDirectory;

        public ModsController()
        {
            modsDirectory = new DirectoryInfo(ModsPath);
        }

        [HttpGet]
        public Task<string[]> ListMods()
        {
            if (!modsDirectory.Exists)
                return Task.FromResult<string[]>(null);

            var files = modsDirectory.EnumerateFiles("*.zip", SearchOption.TopDirectoryOnly)
                                     .Select(info => info.Name)
                                     .ToArray();

            return Task.FromResult(files);
        }

        [HttpPost("upload")]
        [Consumes("multipart/form-data")]
        public IActionResult Upload(IFormFile file)
        {
            try
            {
                //modsDirectory.Create();
                return null;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.GetBaseException().Message);
            }
        }
    }
}
