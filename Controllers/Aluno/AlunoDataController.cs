using AcademiaFacil.Data.Interfaces.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AcademiaFacil.Controllers.Aluno
{
    [ApiController]
    [Route("Aluno")]
    public class AlunoDataController : ControllerBase
    {
        private IAlunoRepository _alunoRepository;

        public AlunoDataController(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_alunoRepository.GetAlunos());
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
