using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models.DTOS.Response;

namespace WebApp.Models.DTOS
{
    public class UsuarioResponse
    {
        public int usuario_id { get; set; }

        public Details details{ get; set; }

        public List<MusicaResponse>? gustos { get; set; }
    }


    public class Details
    {
        public string usuario { get; set; }

        public string email { get; set; }

        public string rol { get; set; }

        public string telefono { get; set; }

        public string nombre { get; set; }

        public string genero { get; set; }

        public string fecha_nacimiento { get; set; }

    }
}
