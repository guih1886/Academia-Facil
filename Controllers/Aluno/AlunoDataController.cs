using AcademiaFacil.Data.DTO;
using AcademiaFacil.Data.Interfaces.Repository;
using AcademiaFacil.Models.Entidades;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AcademiaFacil.Controllers.AlunoData
{
    [ApiController]
    [Route("Aluno")]
    public class AlunoDataController : ControllerBase
    {
        private IAlunoRepository _alunoRepository;
        private IMapper _mapper;

        public AlunoDataController(IAlunoRepository alunoRepository, IMapper mapper)
        {
            _alunoRepository = alunoRepository;
            _mapper = mapper;
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
        public Aluno CreateAluno([FromBody] CreateAlunoDto aluno)
        {
            Aluno novoAluno = _mapper.Map<Aluno>(aluno);
            return _alunoRepository.CreateAluno(novoAluno);
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
