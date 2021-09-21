using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MagazynEdu.ApplicationServices.API.Domain;
using MagazynEdu.DataAccess;
using MagazynEdu.DataAccess.Entities;
using MediatR;

namespace MagazynEdu.ApplicationServices.API.Handlers
{
    class GetBooksHandler : IRequestHandler<GetBooksRequest, GetBooksResponse>
    {
        private readonly IRepository<Book> bookRepository;

        public GetBooksHandler(IRepository<DataAccess.Entities.Book> bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public Task<GetBooksResponse> Handle(GetBooksRequest request, CancellationToken cancellationToken)
        {
            var books = this.bookRepository.GetAll();
            var domainBooks = books.Select(x => new Domain.Models.Book()
            {
                Id = x.Id,
                Title = x.Title
            });
            var response = new GetBooksResponse()
            {
                Data = domainBooks.ToList()
            };
            return Task.FromResult(response);
        }
    }
}
