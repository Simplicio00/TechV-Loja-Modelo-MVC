using Classes.Canal;
using Classes.Categoria;
using Classes.Estoque;
using Classes.Historico;
using Classes.Imagem;
using Classes.Produto;
using Classes.Registro;
using Classes.Usuario;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Data.Contexts
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> op): base(op)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Imagem> Imagem { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<HistoricoCompra> HistoricoCompra { get; set; }
        public DbSet<Registro> Registro { get; set; }
        public DbSet<Canal> Canal { get; set; }
        public DbSet<CanalUser> CanalUser { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relacao in modelBuilder.Model.GetEntityTypes().SelectMany(ent => ent.GetForeignKeys()))
            {
                relacao.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }




    }
}