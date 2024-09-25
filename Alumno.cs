using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.DataAnnotations;
using AlumnoBD = Chamorro.Datos.Alumno;
using ClasePersistente = Chamorro.Entidades.Alumno;
namespace Chamorro.Negocio
{
    public class Alumno
    {

        public static List<ClasePersistente> RecuperarTodos()
        {
            AlumnoBD alumnoBD = new AlumnoBD();

            return alumnoBD.RecuperarTodos();
        }

        public static ClasePersistente RecuperarUno(string DNI)
        {
            if (DNI.IsNullOrEmpty()) throw new Exception("El DNI ingresado está vacío.");

            AlumnoBD alumnoBD = new AlumnoBD();

            return alumnoBD.RecuperarUno(DNI);
        }

        public static void Agregar(ClasePersistente alumno)
        {
            AlumnoBD alumnoBD = new AlumnoBD();

            alumnoBD.Agregar(alumno);
        }

        public static bool EsMailValido(string Mail)
        {
            if (string.IsNullOrEmpty(Mail.Trim())) return false;

            if (!Mail.Contains('@')) return false;
            if (!Mail.Contains('.')) return false;
            if(Mail.Length < 5) return false;

            return true;
        }

        public static bool NombreValido(string Nombre)
        {
            if (Nombre.IsNullOrEmpty()) throw new Exception("Debe ingresar un nombre.");
                return true;
        }

        public static bool NotaValida(string Nota)
        {

            if (Nota.Length == 0) throw new Exception("Debe ingresar una Nota");
            if (!Decimal.TryParse(Nota, out decimal decNota)) throw new Exception("Debe ingresar un decimal valido en el campo Nota.");
            return true;
        }

        public static bool DNIValido(string DNI)
        {
            if (DNI.IsNullOrEmpty()) throw new Exception("Debe ingresar un DNI.");
            return true;
        }

        public static bool FechaValida(DateTime Fecha)
        {
            if (Fecha >= DateTime.Now) throw new Exception("La fecha de nacimiento debe ser menor a hoy");
            return true;
        }
        
    }
}