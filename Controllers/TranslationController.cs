using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [ApiController]
    [EnableCors("AllowAll"), Route("[controller]")]
    public class TranslationController : ControllerBase
    {
        TranslationContext TransContext;

        public TranslationController(TranslationContext context)
        {
            TransContext = context;
        }

        [HttpGet("{word:alpha}")]
        public ActionResult<Translation> Get(string word)
        {
            Translation Result = TransContext.Translations.ToList().Find(x => x.English == word);

            if (Result != null)
                return Ok(Result);
            else 
                return NotFound(JObject.FromObject(new { message = "Translation not found" }));
        }
    }
}
