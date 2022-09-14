using AutoMapper;
using Domain.Entities.Lookup;
using Model.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dtos.LookupDtos.BookCategoryDtos
{
    public class GetAllBookCategoryResponseDto : IMapFrom<BookCategory>
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime LastUpdate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<BookCategory, GetAllBookCategoryResponseDto>()
                .ForMember(
                    o => o.LastUpdate,
                    opt => opt.MapFrom(e => e.UpdatedDate ?? e.CreatedDate)
                );
        }
    }
}
