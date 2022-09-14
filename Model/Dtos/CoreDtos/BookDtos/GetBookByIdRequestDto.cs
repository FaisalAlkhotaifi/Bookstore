using AutoMapper;
using Domain.Entities.Core;
using Model.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Lookup;

namespace Model.Dtos.CoreDtos.BookDtos
{
    public class GetBookByIdRequestDto : IMapFrom<Book>
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime PublishDate { get; set; }
        public double Price { get; set; }

        public DateTime LastUpdate { get; set; }

        public GetBookByIdCategoryRequestDto? BookCategory { get; set; }
        public GetBookByIdAuthorRequestDto? Author { get; set; }
        public int TotalBookstores { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Book, GetBookByIdRequestDto>()
                .ForMember(
                    o => o.LastUpdate,
                    opt => opt.MapFrom(e => e.UpdatedDate ?? e.CreatedDate)
                );
        }
    }

    public class GetBookByIdAuthorRequestDto : IMapFrom<Author>
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string Nationality { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
    }
    
    public class GetBookByIdCategoryRequestDto : IMapFrom<BookCategory>
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
