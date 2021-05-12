using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Worthix.API.Application.DTOs;
using Worthix.API.Application.Interfaces;
using Worthix.API.Domain.Entities;

namespace Worthix.API.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : Controller
    {
        private readonly IApplicationServiceAutor _appservice;

        public AutorController(IApplicationServiceAutor appservice)
        {
            _appservice = appservice;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_appservice.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(long id)
        {
            return Ok(_appservice.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] AutorDTO autorDTO)
        {
            try
            {
                if (autorDTO == null)
                {
                    return NotFound();
                }

                _appservice.Add(autorDTO);
                return Ok("Autor cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] AutorDTO autorDTO)
        {
            try
            {
                if (autorDTO == null)
                {
                    return NotFound();
                }

                _appservice.Update(autorDTO);
                return Ok("Autor atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] AutorDTO autorDTO)
        {
            try
            {
                if (autorDTO == null)
                {
                    return NotFound();
                }

                _appservice.Remove(autorDTO);
                return Ok("Autor removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
