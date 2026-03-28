using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        //Sobrescrever o construtor padrão 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; } // Define um DbSet para a entidade Cliente, permitindo que o Entity Framework Core gerencie as operações de banco de dados relacionadas a essa entidade, como consultas, inserções, atualizações e exclusões, facilitando o acesso e manipulação dos dados dos clientes na aplicação.
    }
}
