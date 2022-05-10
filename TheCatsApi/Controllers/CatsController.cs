using Microsoft.AspNetCore.Mvc;
using TheCatsApi.DataBase.Repositories;

namespace TheCatsApi.Controllers
{
    /// <summary>
    /// Classe responsável pelas ações dos endpoints da API. 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CatsController : ControllerBase
    {
        
        private ICatsRepository _catsRepository;

        private ILogger<CatsController> _logger;

        /// <summary>
        /// Construtor da Classe
        /// </summary>
        /// <param name="catsRepository">Objeto contendo as ações de busca no BD.</param>
        public CatsController(ICatsRepository catsRepository, ILogger<CatsController> logger)
        {
            _catsRepository = catsRepository;
            _logger = logger;
        }

        // GET: api/Cats
        /// <summary>
        /// Método responsavel pelo get da API.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var cats = _catsRepository.Buscar();
            _logger.LogInformation("Requisação Get Realizada!", DateTime.UtcNow);
            return Ok(cats);
        }

        /// <summary>
        /// Método responsavel pelo get por raça da API
        /// </summary>
        /// <param name="name">Raça</param>
        /// <returns></returns>
        // GET api/Cats/BucarNome/{name}
        [HttpGet("BucarNome/{name}")]
        public IActionResult GetRaca(string name)
        {
            var cat = _catsRepository.BuscarRaca(name);
            _logger.LogInformation("Requisação Get por nome Realizada: " + name, DateTime.UtcNow);

            if (cat == null)
            {
                _logger.LogError("Requisação Get por nome falhou: "+ name, DateTime.UtcNow);
                return NotFound();
            }
            return Ok(cat);
        }

        /// <summary>
        /// Método responsável pelo get por origem da API 
        /// </summary>
        /// <param name="origin"></param>
        /// <returns></returns>
        // GET api/Cats/{origin}
        [HttpGet("BucarOrigin/{origin}")]
        public IActionResult BuscarRacaOrigem(string origin)
        {
            var cats = _catsRepository.BuscarRacaOrigem(origin);

            _logger.LogInformation("Requisação Get por origem Realizada: " + origin, DateTime.UtcNow);

            if (cats == null)
            {
                _logger.LogError("Requisação Get por origem falhou: " + origin, DateTime.UtcNow);
                return NotFound();
            }
            return Ok(cats);
        }

        /// <summary>
        /// Método responsável pelo get por temperamento da API
        /// </summary>
        /// <param name="temperament">Temperamento</param>
        /// <returns></returns>
        // GET api/Cats/{temperament}
        [HttpGet("BuscarTemperament/{temperament}")]
        public IActionResult BuscarRacaTemperamento(string temperament)
        {
            var cats = _catsRepository.BuscarRacaTemperamento(temperament);

            _logger.LogInformation("Requisação Get por temperamento RealizadaRealizada: "+ temperament, DateTime.UtcNow);

            if (cats == null)
            {
                _logger.LogError("Requisação Get por temperamento falhou: " + temperament, DateTime.UtcNow);
                return NotFound();
            }
            return Ok(cats);
        }
    }
}
