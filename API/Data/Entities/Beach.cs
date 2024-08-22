using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data.Entities
{
    public class Beach
    {
        public int Id { get; set; }
        public string? BeachName { get; set; }
        public string? Place { get; set; }
        public string? ImageUrl { get; set; }
    }
}