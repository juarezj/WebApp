using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models.DTOS.Request
{
    public class MusicaRequest
    {
        public int usuario_id { get; set; }

        public int? musica_id{ get; set; }

        public string name { get; set; }

        public string author { get; set; }

       

    }
}
