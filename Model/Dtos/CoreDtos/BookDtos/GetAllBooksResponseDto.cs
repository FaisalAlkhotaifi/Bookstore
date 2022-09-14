using AutoMapper;
using Domain.Entities.Core;
using Model.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dtos.CoreDtos.BookDtos
{
    public class GetAllBooksResponseDto : IMapFrom<Book>
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime PublishDate { get; set; }
        public double Price { get; set; }

        public DateTime LastUpdate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Book, GetAllBooksResponseDto>()
                .ForMember(
                    o => o.LastUpdate,
                    opt => opt.MapFrom(e => e.UpdatedDate ?? e.CreatedDate)
                );
        }
    }
}
