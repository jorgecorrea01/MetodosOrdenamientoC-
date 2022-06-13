using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa3_JorgeCorrea
{
    class Program
    {
        static void Main(string[] args)
        {

            menu:
            Console.Clear();
            Console.WriteLine("BIENVENIDO A LA APLICACIÓN DE ORDENAMIENTO \n\n");
            Console.WriteLine("Seleccione una de las siguientes opciones:");
            Console.WriteLine("1. Método de búrbuja");
            Console.WriteLine("2. Método de inserción");
            Console.WriteLine("3. Método de selección");
            Console.WriteLine("4. Método de shell");
            Console.WriteLine("5. Salir de la aplicación");
            Console.Write("Ingrese su opción: ");
            string opcion = Console.ReadLine();

            try
            {
                int opcionNro = int.Parse(opcion);

                if (opcionNro >= 1 && opcionNro <= 5)
                {
                    switch (opcion)
                    {
                        case "1":
                            Burbuja burbuja = new Burbuja();
                            burbuja.cargarNumerosVector();
                            burbuja.ordenarVector();
                            Console.WriteLine("El vector ordenado por el método búrbuja es: \n");
                            burbuja.mostrarNumerosVector();
                            burbuja.guardarVectorArchivo();
                            goto menu;                    
                        case "2":
                            Insercion insercion = new Insercion();
                            insercion.cargarNumerosVector();
                            insercion.ordenarVector();
                            Console.WriteLine("El vector ordenado por el método inserción es: \n");
                            insercion.mostrarNumerosVector();
                            insercion.guardarVectorArchivo();
                            goto menu;
                        case "3":
                            Seleccion seleccion = new Seleccion();
                            seleccion.cargarNumerosVector();
                            seleccion.ordenarVector();
                            Console.WriteLine("El vector ordenado por el método selección es: \n");
                            seleccion.mostrarNumerosVector();
                            seleccion.guardarVectorArchivo();
                            goto menu;
                        case "4":
                            Shell shell = new Shell();
                            shell.cargarNumerosVector();
                            shell.ordenarVector();
                            Console.WriteLine("El vector ordenado por el método shell es: \n");
                            shell.mostrarNumerosVector();
                            shell.guardarVectorArchivo();
                            goto menu;
                        case "5":
                            Console.WriteLine("Gracias por utilizar la aplicación de ordenamiento!");
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("Se ingresó una opción incorrecta del menú");
                            Console.ReadKey();
                            Console.Clear();
                            goto menu;                           
                    }
                    
                }
                else
                {
                    Console.WriteLine("No se ingresó una opción numérica válida entre 1 y 5, por lo tanto, el programa no continuará!");
                    Console.ReadKey();
                    Console.Clear();                    
                    goto menu;

                }
            }
            catch (Exception)
            {
                Console.WriteLine("No se ingresó una opción numérica válida entre 1 y 5, por lo tanto, el programa no continuará!");
                Console.ReadKey();
                Console.Clear();
                goto menu;
            }                                  

        }
    }
}
