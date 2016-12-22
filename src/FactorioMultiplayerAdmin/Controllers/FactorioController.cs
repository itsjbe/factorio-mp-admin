using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace FactorioMultiplayerAdmin.Controllers
{
    [Route("api/[controller]")]
    public class FactorioController : Controller
    {
        internal const string FactorioPath = "/opt/factorio/";
        internal const string FactorioExecutablePath = "/opt/factorio/bin/x64/factorio";

        [HttpGet("start/latest")]
        public IActionResult StartLatest()
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = FactorioExecutablePath,
                    Arguments = "--start-server-load-latest",
                    UseShellExecute = false,
                    //RedirectStandardOutput = true,
                    //RedirectStandardError = true,
                    CreateNoWindow = true
                }
            };
            process.Start();
            //process.BeginOutputReadLine();
            //process.BeginErrorReadLine();

            //process.OutputDataReceived += (s, e) => Console.WriteLine(e.Data);
            //process.ErrorDataReceived += (s, e) => Console.WriteLine(e.Data);

            return Ok();
        }

        [HttpGet("start/{name}")]
        public IActionResult Start(string name)
        {
            var process = new Process
                          {
                              StartInfo = new ProcessStartInfo
                                          {
                                              FileName = FactorioExecutablePath,
                                              Arguments = $"--start-server {name}",
                                              UseShellExecute = false,
                                              //RedirectStandardOutput = true,
                                              //RedirectStandardError = true,
                                              CreateNoWindow = true
                                          }
                          };
            process.Start();
            //process.BeginOutputReadLine();
            //process.BeginErrorReadLine();

            //process.OutputDataReceived += (s, e) => Console.WriteLine(e.Data);
            //process.ErrorDataReceived += (s, e) => Console.WriteLine(e.Data);
            
            return Ok();
        }
    }
}
