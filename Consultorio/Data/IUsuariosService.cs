using System.Collections.Specialized;

namespace Consultorio.Data
{
    public interface IUsuariosService
    {
        List<Usuarios> GetUsuarios();

        Usuarios GetUsuario(string id);

        void UpdateUsuario(Usuarios usuario);
        void AddUsuario(Usuarios usuario);
        void DeleteUsuario(string id);
    }
}
