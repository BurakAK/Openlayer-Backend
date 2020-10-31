using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KapiController : ControllerBase
    {
        IKapiService _kapiService;
        public KapiController(IKapiService kapiService)
        {
            _kapiService = kapiService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _kapiService.GetList();

            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getbykapino")]
        public IActionResult GetByKapiNo(int kapiNo)
        {
            var result = _kapiService.GetByKapiNo(kapiNo);

            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getlistbycode")]
        public IActionResult GetListByCode(int mahalleKodu)
        {
            var result = _kapiService.GetListByCode(mahalleKodu);

            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }


        [HttpPost("add")]
        public IActionResult Add(Kapi kapi)
        {
            var result = _kapiService.Add(kapi);

            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Kapi kapi)
        {
            var result = _kapiService.Delete(kapi);

            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Kapi kapi)
        {
            var result = _kapiService.Update(kapi);

            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
