using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AVALIACAO.Controllers
{
    public class UploadController : Controller
    {
        // GET: Upload
        public ActionResult Upload()
        {
            return View();
        }

        public ActionResult UploadArquivo(string fileContent)
        {
            fileContent = fileContent.Trim();
            string[] arquivoArray = fileContent.Split(new[] { "\r\n", "\r", "\n" },StringSplitOptions.None);
            Array.Sort(arquivoArray);
            string[] ArrayOrdenado = arquivoArray;

            return Json(ArrayOrdenado);
        }
    }
}