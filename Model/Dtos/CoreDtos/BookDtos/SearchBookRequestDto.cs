using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dtos.CoreDtos.BookDtos
{
    public class SearchBookRequestDto
    {
        public string? Title { get; set; }
        public DateTime? PublishDate { get; set; }
    }
}
