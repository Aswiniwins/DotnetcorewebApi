using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetcorewebApi.Models
{
    public class Bookbyid
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "";

        public string AuthorName { get; set; } = "";
        public int Copiessold { get; set; } = 0;

    }
}
