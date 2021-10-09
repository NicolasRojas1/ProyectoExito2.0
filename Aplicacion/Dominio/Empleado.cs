namespace Dominio 
{
	public class Empleado : Persona
	{
		public int EmpleadoId {get; set;}
		public int CodigoEmpleado {get; set;}
		public string Sucursal {get; set;}
		public string Usuario {get; set;}
		public string Contraseña {get; set;}
		public NombreRol NombreRol {get; set;}
		
		public void CambioContraseña()
		{
		}
	}
}
//falta el required