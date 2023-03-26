// See https://aka.ms/new-console-template for more information
using formula1;
bool opcion = true;
Circuito circuito = new Circuito("premio de malasia",5);

while(opcion==true){
Console.WriteLine("\nBienvenido que desea hacer?");
Console.WriteLine("1. Agregar Monoplaza");
Console.WriteLine("2. Sacar Monoplaza");
Console.WriteLine("3. Realizar prueba");
Console.WriteLine("4. Ver posiciones");
Console.WriteLine("5. Salir\n");

int opc=Int32.Parse(Console.ReadLine());



switch(opc){

    case 1:
    Console.WriteLine("\nIngrese la escuderia?");
Console.WriteLine("1. Mclaren");
Console.WriteLine("2. Ferrari");
Console.WriteLine("3. Redbull");
int escuderia = Int32.Parse(Console.ReadLine());
if(escuderia==1){
    McLaren mcLaren = new McLaren();
circuito.AgregarMonoplaza(mcLaren);
break;
}
if(escuderia==2){
    
Ferrari ferrari = new Ferrari();
    circuito.AgregarMonoplaza(ferrari);
    break;

}else{
    RedBull redBull = new RedBull();
    circuito.AgregarMonoplaza(redBull);
    break;

}
    case 2:
    circuito.SacarMonoplaza();
    break;
    case 3:
    circuito.RealizarPrueba();
    break;
    case 4:
    circuito.posiciones();
break;
case 5:
opcion=false;
break;

default:
Console.WriteLine("Ingrese una opcion correcta "); 
return;
}
}