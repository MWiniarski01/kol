using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AutoMapper;
using Kolokwium.DAL;
using Kolokwium.Model.DataModels;
using Kolokwium.Services.Interfaces;
using Kolokwium.ViewModels.VM;
using Microsoft.Extensions.Logging;

namespace Kolokwium.Services.ConcreteServices
{
    public class BookService : BaseService, IBookService
    {
        public BookService(
            ApplicationDbContext dbContext,
            IMapper mapper,
            ILogger logger
        ) :
            base(dbContext, mapper, logger)
        {
        }

        public BookVm GetBook(Expression<Func<Book, bool>> filterExpression)
        {
            throw new NotImplementedException();
        }
    }
}
