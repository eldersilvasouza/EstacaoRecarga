using EstacaoRecarga.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EstacaoRecarga.Data
{
    public partial class EstacaoContext : DbContext
    {
        public EstacaoContext(DbContextOptions<EstacaoContext> options)
            : base(options)
        {

        }


        public virtual DbSet<Estacao> Estacoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Localiza todas as configurações que estão nos dbsets
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EstacaoContext).Assembly);

            ///Desativando o delete cascade
            foreach (IMutableForeignKey relationship in modelBuilder.Model.GetEntityTypes().SelectMany(x => x.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;
            }


            OnModelCreatingPartial(modelBuilder);
        }

        private void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            throw new NotImplementedException();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {

                return await base.SaveChangesAsync(true, cancellationToken);

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
