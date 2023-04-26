using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using AplicativoWeb.Models;
using AplicativoWeb.EntityConfigs;

public class AppDbContextdot : DbContext{
    //DbContext representa o banco de dados
    //DbSet representa a tabela

    //

public DbSet<Curso> Cursos => Set<Curso>();
    protected override void OnConfiguring(DbContextOptionsBuilder builder){
        builder.UseSqlServer("Server=LAB-F08-19;Database=EscolaDotNet;User Id=sa;Password=senai@123;TrustServerCertificate=True");

    }
    protected override void OnModelCreating(ModelBuilder builder){
        builder.ApplyConfiguration(new CursoEntityConfig());
    }

}