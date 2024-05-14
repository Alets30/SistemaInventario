using SistemaInventario.Modelos;
using SistemaInventario.Modelos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.Repositorio.IRepositorio
{
    public interface IUsuarioAplicacionRepositorio : IRepositorio<UsuarioAplicacion>
    {
        void IUsuarioAplicacionRepositorio(UsuarioAplicacion usuarioAplicacion);
    }
}
