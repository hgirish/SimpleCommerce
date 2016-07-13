using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using SimpleCommerce.Core.Infrastructure.EntityFramework;
using SimpleCommerce.Core.ApplicationServices;

namespace SimpleCommerce.Web.Controllers
{
    public class SampleDataController : Controller
    {
        private readonly ISqlRepository _sqlRepository;

        public SampleDataController(ISqlRepository sqlRepository)
        {
            _sqlRepository = sqlRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ResetToSample()
        {
            var filePath = Path.Combine(GlobalConfiguration.ApplicationPath,
                "SampleData", "ResetToSampleData.sql");
            var lines = System.IO.File.ReadAllLines(filePath);
            var commands = _sqlRepository.ParseCommand(lines);
            _sqlRepository.RunCommands(commands);

            CopyImages();

            return Redirect("~/");
        }
        private void CopyImages()
        {
            var sourceDir = Path.Combine(GlobalConfiguration.ApplicationPath, "SampleData", "ProductImages");
            var destDir = Path.Combine(GlobalConfiguration.ApplicationPath, "UserContents");
            IEnumerable<string> files = Directory.GetFiles(sourceDir);
            foreach (var file in files)
            {
                var destFileName = Path.Combine(destDir, Path.GetFileName(file));
                System.IO.File.Copy(file, destFileName, true);
            }
        }
    }
}