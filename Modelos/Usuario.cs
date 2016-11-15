using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// version 1 
//23/11/2015




namespace Modelos
{
   public class Usuario
    {
        private int idUsuario;
            
        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        private string nombre;

        public string NombreUsuario
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string pass;

        public string PassUsuario
        {
            get { return pass; }
            set { pass = value; }
        }

        public Usuario()
        {
        }


/// <summary>
/// constructor completo de Usuario( idUsuario,nombre,Contraseña)
/// </summary>
/// <param name="id"></param>
/// <param name="nom"></param>
/// <param name="pas"></param>

        public Usuario(int id, string nom, string pas)
        {
            IdUsuario = id;NombreUsuario = nom;pass = pas;
        }


    }
}
