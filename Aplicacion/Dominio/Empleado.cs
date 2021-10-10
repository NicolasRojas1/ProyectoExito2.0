using System.ComponentModel.DataAnnotations;
namespace Dominio
{
	public class Empleado : Persona
	{
		public int EmpleadoId {get; set;}
		public int CodigoEmpleado {get; set;}
		[Required(ErrorMessage="El campo Codigo de empleado es requerido")]
		public string Sucursal {get; set;}
		[Required(ErrorMessage="El campo Sucursal es requerido")]
		public string Usuario {get; set;}
		[Required(ErrorMessage="El campo Usuario es requerido")]
		public string Contraseña {get; set;}
		[Required(ErrorMessage="El campo Contraseña es requerido")]
		public NombreRol NombreRol {get; set;}
		public void CambioContraseña()
		{
		}
	}
}