using AcademiaFacil.Data.DTO;
using AcademiaFacil.Models.Entidades;
using AutoMapper;

namespace AcademiaFacil.Profiles;

public class AlunoProfile : Profile
{
    public AlunoProfile()
    {
        CreateMap<CreateAlunoDto, Aluno>();
    }
}
