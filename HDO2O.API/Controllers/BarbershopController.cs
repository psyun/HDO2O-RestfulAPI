﻿using HDO2O.DTO;
using HDO2O.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HDO2O.API.Controllers
{
    [RoutePrefix("rest/barbershop")]
    public class BarbershopController : ApiController
    {
        private IBarbershopService _servBabershop;
        public BarbershopController(IBarbershopService servBarbershop)
        {
            _servBabershop = servBarbershop;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="barbershop"></param>
        /// <uri>POST:rest/barbershop/add</uri>
        /// <returns></returns>
        [HttpPost]
        [Route("add")]
        public IHttpActionResult AddBabershop(BarbershopDTO barbershop)
        {
            return Ok(_servBabershop.Add(barbershop));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <uri>rest/barbershop/getAll</uri>
        /// <returns></returns>
        [HttpGet]
        [Route("getAll")]
        public IHttpActionResult GetAll()
        {
            return Ok(_servBabershop.GetAll());
        }
    }
}