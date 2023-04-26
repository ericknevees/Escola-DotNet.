using AplicativoWeb.Models;//camada Model
using Microsoft.EntityFrameworkCore;//EF framework
using Microsoft.EntityFrameworkCore.Metadata.Builders;//fluent API
namespace AplicativoWeb.EntityConfigs;//Novo namespace

public class CursoEntityConfig : IEntityTypeConfiguration<Curso>
{
    public void Configure(EntityTypeBuilder<Curso> builder)
    {
        builder.ToTable("Curso");//nome da tabela
        builder.HasKey(c=>c.Id);//Chave primária
    
    //titulo marketing
        builder.Property(c=>c.TituloMarketing)
        .HasColumnType("nvarchar(80)")
        .IsRequired();
    
    //titulo interno
        builder.Property(c=>c.TituloInterno)
        .HasColumnType("nvarchar(80)")
        .IsRequired();

        builder.Property(c=>c.Descricao)
        .HasColumnType("text")
        .IsRequired();
    }
}