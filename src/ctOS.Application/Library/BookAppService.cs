using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ctOS.Library
{
    /// <summary>
    /// 
    /// </summary>
    public class BookAppService :
        CrudAppService<
            Book, //The Book entity
            BookDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateBookDto>, //Used to create/update a book
        IBookAppService //implement the IBookAppService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="repository"></param>
        public BookAppService(IRepository<Book, Guid> repository)
            : base(repository)
        {

        }
    }
}
