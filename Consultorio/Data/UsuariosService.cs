using System.Runtime.ConstrainedExecution;

namespace Consultorio.Data
{
    public class UsuariosService : IUsuariosService
    {
        private List<Usuarios> usuarios = new List<Usuarios>()
        {
            new Usuarios
            {
                Id       = "1",
                Nome     = "Tyson",                
                User     = "tyson",
                Password = "123",
                Tipo     =  "Paciente",
                CPF     = "888888888",
                CEL     = "+55116666666",
                Endereco = "Rua XPTO, 2",
            },
            new Usuarios
            {
                Id       = "3",
                Nome     = "Adm",                
                User     = "adm",
                Password = "123",
                Tipo     =  "Medico",
                CPF     = "888888888",
                CEL     = "+55116666666",
                Endereco = "Rua XPTO, 2",
            },
            new Usuarios
            {
                Id   = "2",
                Nome = "Lolla",               
                User     = "lolla",
                Password = "123",
                Tipo     =  "Medico",
                CPF     = "99999999999",
                CEL     = "+55115555",
                Endereco = "Rua XPTO, 2", 

            }
         };
        public List<Usuarios> GetUsuarios()
        {
            return usuarios;
        }

        public Usuarios GetUsuario(string id)
        {
            return usuarios.SingleOrDefault(x => x.Id == id);
        }

        public void UpdateUsuario(Usuarios usuario)
        {
            var getOldUsuario = GetUsuario(usuario.Id);
            getOldUsuario.Nome = usuario.Nome;
        }

        public void AddUsuario(Usuarios usuario)
        {
            var id = Guid.NewGuid();
            usuario.Id = id.ToString();
            usuarios.Add(usuario);
        }

        public void DeleteUsuario(string id)
        {
            var usuario = GetUsuario(id);
            usuarios.Remove(usuario);
        }
    }
}
