using System;
using Persistencia;
using Dominio;
namespace Consola
{
    class Program
    {
        private static IRepositorioCliente _repoCliente= new RepositorioCliente(
            new Persistencia.Conexion());
        private static IRepositorioControles _repoControl= new RepositorioControles(
            new Persistencia.Conexion());   

        private static IRepositorioProducto _repoProducto= new RepositorioProducto(
            new Persistencia.Conexion());
        
        private static IRepositorioVideojuego _repoVideojuego= new RepositorioVideojuegocs(
            new Persistencia.Conexion());

        private static IRepositorioConsola _repoConsola = new RepositorioConsola(
            new Persistencia.Conexion());
        static void Main(string[] args)
        
        {
         //-------------------------------Parte cliente--------------------------
        //addCliente();
        //getCliente(2);
        //deleteCliente(1);
        //updateCliente();
        //-------------------------------Parte Controles--------------------------
        //---------Cliente-----------------------------    
        //addControl();
        //deleteControl(1);
        //getControl(1);
        //updateControl();
 
        //-----------------Producto---------
        //addProducto();
        //deleteProducto(1);
        //getProducto(1);
        //updateProducto();
        //--------------Video juego--------------
        //addVideojuego();
        //deleteVideojuego(1);
        //getVideojuego(1);
        //updateVideojuego();
        //----------------------------Parte Consola ----------------------------
        //addConsola();
        //deleteConsola(1);
        //getConsola(1);
        //updateConsola();

        }
        public static void addCliente(){
            var cliente = new Cliente(){
            Nombres="Jorge",
            Apellidos= "Leiton",
            TipoDocumento= "Cedula",
            NumeroDocumento ="100",
            Email="jleiton@gmail.com",
        
            };
            _repoCliente.addCliente(cliente);
        }
        public static void getCliente(int ClienteId){
	    var cliente= _repoCliente.readCliente(ClienteId);
	    if(cliente==null)
	    return;
	    Console.WriteLine(cliente.Nombres);
        }
        public static void deleteCliente(int ClienteId){
	     _repoCliente.deleteCliente(ClienteId);
        }
        public static void updateCliente(){
	    var cliente= new Cliente{
	    ClienteId=(2),
	    Nombres="Carlos",
	    Apellidos= "Arias",
        TipoDocumento="Tarjeta de I",
        Email="jorge.leiton@gmail.com",
        NumeroDocumento="123123"
	    };
	    _repoCliente.updateCliente(cliente);
        }
        
        //-------------------Controles-----------------------------
   
        public static void addControl(){
            var control = new Control(){
            TipoControl="Sony",
            NumeroControl= 1,
            PrecioCompra= 1.500,
            PrecioVenta =2.000,
        
            };
            _repoControl.addControl(control);
        }
        public static void deleteControl(int ControlId){
	     _repoControl.deleteControl(ControlId);
        }
        public static void getControl(int ControlId){
	    var control= _repoControl.readControl(ControlId);
	    if(control==null)
	    return;
	    Console.WriteLine(control.TipoControl);
        }
        public static void updateControl(){
	    var control= new Control{
	    ControlId=(1),
	    NumeroControl=2,
	    PrecioCompra=1200,
        PrecioVenta=3000,

	    };
	    _repoControl.updateControl(control);
        }
        public static void addProducto(){
            var producto = new Producto(){
            CantConsola=1,
            CantControl=2,
            CantVideojuego=2,
            FechaCompra="25/09/2021",
            FechaVenta="25/09/2021",

            };
        _repoProducto.addProducto(producto);
        }
        public static void deleteProducto(int ProductoId){
	     _repoProducto.deleteProducto(ProductoId);
        }
        public static void getProducto(int ProductoId){
	    var producto= _repoProducto.readProducto(ProductoId);
	    if(producto==null)
	    return;
	    Console.WriteLine(producto.FechaCompra);
        }
        public static void updateProducto(){
	    var producto= new Producto{
	    CantConsola=2,
        CantControl=3,
        CantVideojuego=1,
        FechaCompra="21/09/2021",
        FechaVenta="23/09/2021",
	    };
	    _repoProducto.updateProducto(producto);
        }
         //------------------Videojuego-----------------------------
        public static void addVideojuego(){
            var videojuego = new Videojuego(){
            Nombre="CDO",
            Version="II",
            Fabricante="Sony",
            Multiplataforma=true,
            PrecioCompra=12.333,
            PrecioVenta=16.400,

            };
            _repoVideojuego.addVideojuego(videojuego);
        } 
        public static void deleteVideojuego(int VideojuegoId){
	     _repoVideojuego.deleteVideojuego(VideojuegoId);
        }
        public static void getVideojuego(int VideojuegoId){
	    var Videojuego= _repoVideojuego.readVideojuego(VideojuegoId);
	    if(Videojuego==null)
	    return;
	    Console.WriteLine(Videojuego.Nombre);
        }
        public static void updateVideojuego(){
	    var videojuego = new Videojuego(){
            Nombre="CDOOO",
            Version="III",
            Fabricante="Xbox",
            Multiplataforma=true,
            PrecioCompra=15,
            PrecioVenta=19,
	    };
	    _repoVideojuego.updateVideojuego(videojuego);
        }
        
        //----------------------ParteConsola----------------------------------------------
        public static void addConsola()
        {
            var consola1 = new Consola1()
            {
                Nombre="PS4",
                Version= "Slim",
                Fabricante= "Sony",
                CapacidadAlmacenamiento ="1000",
                SSD =false,
                HDD =true,
                CantidadRam ="8",
                VelocidadProcesador ="1.6",
                PrecioCompra = 600000.0,
                PrecioVenta = 1200000.0,
            };
            _repoConsola.addConsola(consola1);
        }
        public static void deleteConsola(int Consola1Id)
        {
            _repoConsola.deleteConsola(Consola1Id);
        }
        public static void getConsola(int Consola1Id)
        {
	        var consola= _repoConsola.readConsola(Consola1Id);
	        if(consola==null)
	        return;
	        Console.WriteLine(consola.Nombre);
        }
        public static void updateConsola()
        {
            var consola1 = new Consola1()
            {
                Nombre = "Xbox One",
                Version = "S",
                Fabricante = "Microsoft",
                CapacidadAlmacenamiento = "500",
                SSD = false,
                HDD = true,
                CantidadRam = "10",
                VelocidadProcesador = "3.4",
                PrecioCompra = 500000,
                PrecioVenta = 1000000,
            };
            _repoConsola.updateConsola(consola1);
        }
        //comentario final
    }
}
        
    
