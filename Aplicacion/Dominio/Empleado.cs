namespace Dominio 
{
	public class Empleado : Persona
	{
		public int CodigoEmpleado {get; set;}
		public string Sucursal {get; set;}
		public string Usuario {get; set;}
		public string Contraseña {get; set;}
		public void CambioContraseña()
		{
		}
	}
}