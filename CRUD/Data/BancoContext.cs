using CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
<<<<<<< HEAD
        }

        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
=======

        }
        public DbSet<ContatoModel> Contatos { get; set; }
    }
}


>>>>>>> c04e1caf4da1818c7b5fadf6faf97706a6a258e5
