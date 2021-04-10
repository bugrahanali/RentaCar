using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getall")]
        public ActionResult Get()
        {
            
            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data); 
            }
            return BadRequest(result.Message);
        }
        
        [HttpGet("getbyBrandıd")]
        public ActionResult GetAllByCategoryId(int ıd)
        {

            var result = _carService.GetAllByBrandId(ıd);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public ActionResult Post(Car car)
        {

            var result = _carService.Add(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getallbyunitPrice")]
        public ActionResult GetAllByUnitPrice(decimal min, decimal max)
        {

            var result = _carService.GetAllByUnitPrice(min,max);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getcardetaildtos")]
        public ActionResult GetCarDetailDtos()
        {

            var result = _carService.GetCarDetailDtos();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getcarbycolorıd")]
        public ActionResult GetCarsByColorId(int ıd)
        {

            var result = _carService.GetCarsByColorId(ıd);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        
        [HttpPost("delete")]
        public ActionResult Delete(Car car)
        {

            var result = _carService.Delete(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public ActionResult Update(Car car)
        {

            var result = _carService.Update(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
