using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;
using WebApp.Models.DTOS;
using WebApp.Models.DTOS.Request;
using WebApp.Models.DTOS.Response;

namespace WebApp.Controllers
{
    [Route("api/v1/[controller]")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    public class UsuariosController : ControllerBase
    {



        [HttpPost]

        public UsuarioResponse AltaUsuario(UsuarioRequest usuario)
        {

            UsuarioResponse nuevoUsuario = new UsuarioResponse();

            return nuevoUsuario;


        }


        [HttpPut]

        public UsuarioResponse ActualizaUsuario(UsuarioRequest usuario)
        {

            UsuarioResponse nuevoUsuario = new UsuarioResponse();

            return nuevoUsuario;

        }



        [HttpDelete("{usuarioId}")]

        public UsuarioResponse EliminaUsuario(string usuarioId)
        {

            UsuarioResponse nuevoUsuario = new UsuarioResponse();

            return nuevoUsuario;

        }


        [HttpGet("{usuarioId}")]

        public UsuarioResponse ObtenerUsuarioPorId(int usuarioId)
        {

            UsuarioResponse usuario = new UsuarioResponse();

            return usuario;


        }



        [HttpPost("gustos")]

        public MusicaResponse AltaGustos(MusicaResponse usuario)
        {

            MusicaResponse nuevoUsuario = new MusicaResponse();

            return nuevoUsuario;


        }


        [HttpPut("gustos")]

        public MusicaResponse ActualizacionGustos(MusicaResponse usuario)
        {

            MusicaResponse nuevoUsuario = new MusicaResponse();

            return nuevoUsuario;
            

        }


        [HttpDelete("gustos")]

        public MusicaResponse EliminacionGustos(MusicaResponse usuario)
        {

            MusicaResponse nuevoUsuario = new MusicaResponse();

            return nuevoUsuario;


        }


        [HttpGet("gustos/{usuarioId}")]

        public UsuarioResponse EliminacionGustos(string usuarioId)
        {

            UsuarioResponse nuevoUsuario = new UsuarioResponse();

            return nuevoUsuario;


        }






    }
}
