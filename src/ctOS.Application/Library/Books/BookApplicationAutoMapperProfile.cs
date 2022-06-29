using AutoMapper;

namespace ctOS.Library.Books
{
    /// <summary>
    /// 
    /// </summary>
    public class BookApplicationAutoMapperProfile : Profile
    {
        /// <summary>
        /// 
        /// </summary>
        public BookApplicationAutoMapperProfile()
        {
            CreateMap<Book, BookDto>();

            CreateMap<CreateUpdateBookDto, Book>();

            CreateMap<BookDto, CreateUpdateBookDto>();
        }
    }
}
