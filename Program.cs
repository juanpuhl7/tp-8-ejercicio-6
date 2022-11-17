/*6) Precargar un arreglo con 10 valores enteros y programar un método de búsqueda en el
arreglo que permita determinar si un valor ingresado por el usuario existe dentro de dicho
arreglo.*/

using System;

namespace ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arreglo ={25, 32 , 1, 99, 100, 125, 951, 456, 754, 10};
            int num=0;
            string encontrado="";


            Console.WriteLine("Ingrese por favor el numero que desea buscar: ");
            num=Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<10; i++){
                  if(arreglo[i]==num){
                    encontrado="Se encuentra en el arreglo.";
                  }  
                  else{
                    encontrado="No se encuentra en el arreglo.";
                  }
            }
            Console.Clear();
            Console.WriteLine("Usted ingreso el numero: " + num + " " + encontrado);

        }
    }
}
