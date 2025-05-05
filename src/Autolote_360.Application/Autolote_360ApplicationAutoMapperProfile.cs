using AutoMapper;
using Autolote_360.Books;

namespace Autolote_360;

public class Autolote_360ApplicationAutoMapperProfile : Profile
{
    public Autolote_360ApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
