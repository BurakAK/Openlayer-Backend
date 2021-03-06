﻿using System;
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
    public class MahalleController : ControllerBase
    {
        IMahalleService _mahalleService;

        public MahalleController(IMahalleService mahalleService)
        {
            _mahalleService = mahalleService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _mahalleService.GetList();

            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getbycode")]
        public IActionResult GetByCode(int mahalleKodu)
        {
            var result = _mahalleService.GetByCode(mahalleKodu);

            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Mahalle mahalle)
        {

            var mKodu = _mahalleService.GetList().Data.Count;
            mahalle.MahalleKodu = mKodu + 1;
            var result = _mahalleService.Add(mahalle);

            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Mahalle mahalle)
        {
            var result = _mahalleService.Delete(mahalle);

            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Mahalle mahalle)
        {
            var result = _mahalleService.Update(mahalle);

            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
