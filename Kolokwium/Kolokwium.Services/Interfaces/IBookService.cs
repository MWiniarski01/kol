using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Kolokwium.Model.DataModels;
using Kolokwium.ViewModels.VM;

namespace Kolokwium.Services.Interfaces
{
    public interface IBookService
    {
        // BookVm AddOrUpdateProduct(AddOrUpdateBookVm addOrUpdateProductVm);
        BookVm GetBook(Expression<Func<Book, bool>> filterExpression);

        // IEnumerable<BookVm>
        // GetBookVms(
        //     Expression<Func<Book, bool>> filterExpression = null
        // );
    }
}
