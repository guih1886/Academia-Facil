using AcademiaFacil.Models;
using AcademiaFacil.Models.Entidades;
using AcademiaFacil.Models.Tipos;
using Microsoft.EntityFrameworkCore;

namespace AcademiaFacil.Data;

public class AcademiaDBContext : DbContext
{
    public AcademiaDBContext(DbContextOptions<AcademiaDBContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Equipamento>().HasOne(e => e.RelacaoCargas).WithMany().HasForeignKey(e => e.RelacaoCargasId).OnDelete(DeleteBehavior.Restrict);
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<RelacaoCargas> RelacaoCargas { get; set; }
    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Professor> Professores { get; set; }
    public DbSet<Treino> Treinos { get; set; }
    public DbSet<Exercicio> Exercicios { get; set; }
    public DbSet<Equipamento> Equipamentos { get; set; }
    public DbSet<TipoExercicio> TiposExercicio { get; set; }
}