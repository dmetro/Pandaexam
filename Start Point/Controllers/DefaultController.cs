using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Core.Repository;
using Core.Services.ExChange;
using Microsoft.AspNetCore.Mvc;

namespace Start_Point.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class DefaultController : Controller
    {
        private IExChangeRespository _exChangeRespository;
        public DefaultController (IExChangeRespository exChangeRespository)
        {
            this._exChangeRespository = exChangeRespository;
        }

        [HttpGet]
        public Task<RepositiryItem> Get()
        {
            var res = _exChangeRespository.Get();
            return res;
        }
    }
}
