using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private IEnumerable<Evento> _evento = new Evento[]
            {
                new Evento()
                {
                    EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "Paranavaí",
                Lote = "1° Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemUrl = "Foto.png"
                },
                new Evento()
                {
                    EventoId = 2,
                Tema = "Angular e suas novidades",
                Local = "Paranavaí",
                Lote = "2° Lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImagemUrl = "Foto.png"
                }
            };
        public EventoController()
        {
        }

        [HttpGet] // retorna tudo
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")] // retorna pelo id
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }
        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post()";
        }
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de put() com id = {id}";
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete() id delete = {id}";
        }
    }
}
