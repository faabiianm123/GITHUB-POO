namespace uno{
//creamos una classe para iniciar un trabajo


public class pez{
                                                 public static void Main(string [] args){




         concesionarios concesionarios2=  new concesionarios ();
                concesionarios2.setcolor1("AZUL");
                concesionarios2.setmodelo1("BWM");
                    concesionarios2.setcilindraje(45);
                    concesionarios2.setventasbmw(431);
                    concesionarios2.tostring();

                                                                            concesionarios concesionarios1= new concesionarios ();
                                                                            concesionarios1.setcilindraje(34);
                                                                            concesionarios1.setcolor("Gris");
                                                                           concesionarios1.setventastessla(437);
                                                                            concesionarios1.tostring();
                                                                            concesionarios1.setmodelo("TESLA");


    


        if ( concesionarios2.consultarventasbmw() >= concesionarios1.consultarventastessla()){

            Console.WriteLine("Las ventas en concecionario de Tesla son mas que las de BWM" );

        }
        else {
             Console.WriteLine("Las ventas en concecionario de Bwm son mas que las de tesla" );
        }
        }




            }

                                                 

    public class concesionarios{
    //Atributos
    // A partir de este punto se muestran los atributos privados de la clase concesionario
    private int ventasbmw; 
    private int ventastessla;
    //muestra el atrbituo ventasbmw
    private string modelo="";
     
     private string modelo1="";
    //muestra el atributo model
    private string  color="";
    private string color1="";

    //muestra el atributo color
    private int cilindraje , cilindraje1;
    //muestra el atributo cilindraje 

   
    //Metodos - creamos el listado de metodos para consultar y configurar
     public int consultarventasbmw () {
     return this.ventasbmw;  
     }
    //en esta linea encontramos la consulta de ventas bmw 
     public void setventasbmw (int ventasbmw){
     this.ventasbmw=ventasbmw;
     } 
     //en esta linea encontramos la configuracion de ventas bmw
     public int consultarventastessla () {
     return this.ventastessla;
     }
    //en esta linea encontramos la consulta de ventas tessla
     public void setventastessla ( int ventastessla ){
     this.ventastessla=ventastessla;
     } 
     public void consultarmodelo(){
     Console.WriteLine(this.modelo); 
    //en esta linea encontramos la consulta del modelo
    }
     public void setmodelo (string modelo){
     this.modelo=modelo;}
       public void setmodelo1 (string modelo1){
     this.modelo=modelo1;
    }
    public void consultarmodelo1(){
     Console.WriteLine(this.modelo); }
     //en esta linea encontramos la configuración del modelo
    public void Consultarcolor(){
     Console.WriteLine(this.color);
     //en esta linea encontramos la consulta del color
    }
     public void setcolor(string color){
     this.color=color;
     //en esta linea encontramos la configuracion del color
     }
    public void Consultarcolor1(){
     Console.WriteLine(this.color);
     //en esta linea encontramos la consulta del color
    }
        public void setcolor1(string color1){
     this.color=color1;
        }
     public int Consultarcilindraje () {
     return this.cilindraje;
     }
      public int Consultarcilindraje1 () {
     return this.cilindraje;
     }
     //en esta linea encontramos la consulta del cilindraje
    
     public void setcilindraje (int cilindraje){
     this.cilindraje=cilindraje;}