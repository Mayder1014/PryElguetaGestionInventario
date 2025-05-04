using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryGestionDeInventario
{
    public class clsUsuario
    {
        public int Id { get; set; }
        public string usuario {  get; set; }
        public string contraseña {  get; set; }
        public int estado {  get; set; }
        public DateTime ultConexion {  get; set; }

        static public clsUsuario usuarioActual { get; set; } //Utilizado para mantener los datos del usuario logueado durante toda la ejecución del programa, hasta que se desconecte.

        public clsUsuario(int Id, string usuario, string contraseña, int estado, DateTime ultConexion)
        {
            this.Id = Id;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.estado = estado;
            this.ultConexion = ultConexion;
        }
    }
}
