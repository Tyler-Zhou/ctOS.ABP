using System.Threading.Tasks;
using ctOS.Library.Books;
using Microsoft.AspNetCore.Mvc;

namespace ctOS.Web.Pages.Library.Books
{
    public class CreateModalModel : ctOSPageModel
    {
        [BindProperty]
        public CreateUpdateBookDto Book { get; set; }

        private readonly IBookAppService _bookAppService;

        public CreateModalModel(IBookAppService bookAppService)
        {
            _bookAppService = bookAppService;
        }

        public void OnGet()
        {
            Book = new CreateUpdateBookDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _bookAppService.CreateAsync(Book);
            return NoContent();
        }
    }
}
