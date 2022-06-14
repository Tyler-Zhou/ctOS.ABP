using AutoMapper;

namespace ctOS.Library
{
    /// <summary>
    /// 
    /// </summary>
    public class LibraryApplicationAutoMapperProfile : Profile
    {
        /// <summary>
        /// 
        /// </summary>
        public LibraryApplicationAutoMapperProfile()
        {
            CreateMap<Book, BookDto>();
            CreateMap<CreateUpdateBookDto, Book>();
        }
    }
}
