using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Kolokwium.Model.DataModels;
using Kolokwium.ViewModels.VM;

namespace Kolokwium.Services.Interfaces
{
    public interface IBookService
    {
        BookVm AddOrUpdateBook(AddOrUpdateBookVm addOrUpdateBookVm);
        BookVm GetBook(Expression<Func<Book, bool>> filterExpression);
        IEnumerable<BookVm> GetBooks(Expression<Func<bool>> filterExpression = null);
    }
}
