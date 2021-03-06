using System;
using System.Threading.Tasks;
using BooksApi.DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace BooksApi.DataBase.Context
{
    public interface IContext
    {
        DbSet<TokenDB> Tokens { get; set; }
        DbSet<AuthorDB> Authors { get; set; }
        DbSet<BookDB> Books { get; set; }
        DbSet<GenreDB> Genres { get; set; }
        DbSet<UserDB> Users { get; set; }
        DatabaseFacade DataBaseFacade { get; }
        Task SaveChangesAsync();
    }
}