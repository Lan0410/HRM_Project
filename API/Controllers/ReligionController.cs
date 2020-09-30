using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Model;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReligionController : ControllerBase
    {
        private IReligionBusiness _itemReligion;
        public ReligionController(IReligionBusiness religionBusiness)
        {
            _itemReligion = religionBusiness;
        }

        [Route("get-all")]
        [HttpGet]
        public IEnumerable<Religion> GetAll()
        {
            return _itemReligion.GetData();
        }
    }
}
