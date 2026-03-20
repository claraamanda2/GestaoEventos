using GestaoEventos.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GestaoEventos.Data;

public class ApplicationDbContext : IdentityDbContext
{
//Passo 2 : Após criar Model, declarar ela no Context
public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
{
}
    //Aqui nós declaramos a Model que você acabou de criar!
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Local> Locais { get; set; }

    public DbSet<Evento> Eventos { get; set; }
}
//Passo 3 :
//Criar a migration que será responsável po
//fazer uma estrutura em SQL baseada Models
//Comandos:
// 1. add-migration AddCategorias
// 2. Update-database