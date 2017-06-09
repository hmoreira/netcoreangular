using System.Collections.Generic;
using vega.Models;
using System.Collections.ObjectModel;
using Microsoft.AspNetCore.Mvc;

namespace vega.Controllers
{
    public class ApiController
    {
        [HttpGet("/api/makes")]
        public IEnumerable<Make> GetMakes() {
            return new List<Make>();
        }
    }
}