using AcademiaFacil.Models;
using Microsoft.EntityFrameworkCore;

namespace AcademiaFacil.Data;

public class AcademiaDBContext : DbContext
{
    public AcademiaDBContext(DbContextOptions<AcademiaDBContext> options) : base(options) { }

    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Equipamento> Equipamentos { get; set; }
    public DbSet<TipoExercicio> TiposExercicio { get; set; }
}