using System;
using System.Threading.Tasks;
using BooksApi.CQRS.Commands;
using BooksApi.CQRS.Commands.Abstractions;
using BooksApi.DataBase.Context;
using BooksApi.DataBase.Entities;

namespace BooksApi.DataBase.CQRS.TokenImpl
{
    public class WriteTokenCommandHandler: ICommandHandler<WriteTokenCommand>
    {
        private readonly IContext _context;

        public WriteTokenCommandHandler(IContext context)
        {
            _context = context;
        }

        public async Task HandleAsync(WriteTokenCommand handled)
        {
            _context.Tokens.Add(new TokenDB
            {
                Id = handled.Id,
                TokenValue = handled.Token,
                UserId = handled.UserId,
                Active = true,
            });

            await _context.SaveChangesAsync();
        }
    }
}