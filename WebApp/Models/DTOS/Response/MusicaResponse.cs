using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models.DTOS.Response
{
    public class MusicaResponse
    {

        public int musica_id { get; set; }

        public int persona_id { get; set; }
        public string name { get; set; }

        public string author { get; set; }
    }
}
