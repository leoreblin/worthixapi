using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Worthix.API.Application.DTOs;
using Worthix.API.Application.Interfaces;

namespace Worthix.API.Service.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly IApplicationServiceLivro _appservice;

        public LivroController(IApplicationServiceLivro appservice)
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
        public ActionResult Post([FromBody] LivroDTO livroDTO)
        {
            try
            {
                if (livroDTO == null)
                {
                    return NotFound();
                }

                _appservice.Add(livroDTO);
                return Ok("Livro cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] LivroDTO livroDTO)
        {
            try
            {
                if (livroDTO == null)
                {
                    return NotFound();
                }

                _appservice.Update(livroDTO);
                return Ok("Livro atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] LivroDTO livroDTO)
        {
            try
            {
                if (livroDTO == null)
                {
                    return NotFound();
                }

                _appservice.Remove(livroDTO);
                return Ok("Livro removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
