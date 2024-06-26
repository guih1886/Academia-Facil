using AcademiaFacil.Models;
using Microsoft.EntityFrameworkCore;

namespace AcademiaFacil.Data;

public class AcademiaDBContext : DbContext
{
    public AcademiaDBContext(DbContextOptions<AcademiaDBContext> options) : base(options) { }

    public DbSet<Aluno> Aluno { get; set; }
}