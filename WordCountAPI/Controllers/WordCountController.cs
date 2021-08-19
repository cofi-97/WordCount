using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WordCountAPI.Models;

namespace WordCountAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WordCountController : ControllerBase
    {
        private WordCount_DBContext _context;
        public WordCountController(WordCount_DBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public int Get()
        {
            var texts = _context.Texts.ToList();
            return CountWords(texts.First().TextToCount);
        }

        [HttpPost]
        public int Post([FromBody] string text)
        {
            return CountWords(text);
        }

        private int CountWords(string textToCount)
        {
            string[] substrings = textToCount.Split(new char[] { ' ', ',', ';', '.', '!', '"', '(', ')', '?' },
                StringSplitOptions.RemoveEmptyEntries);

            return substrings.Length;
        }
    }
}
