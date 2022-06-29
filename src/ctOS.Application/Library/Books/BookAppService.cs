using ctOS.Permissions;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ctOS.Library.Books
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
            GetPolicyName = ctOSPermissions.Library.Books.Default;
            GetListPolicyName = ctOSPermissions.Library.Books.Default;
            CreatePolicyName = ctOSPermissions.Library.Books.Create;
            UpdatePolicyName = ctOSPermissions.Library.Books.Edit;
            DeletePolicyName = ctOSPermissions.Library.Books.Delete;
        }

    }
}
