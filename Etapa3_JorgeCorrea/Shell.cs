using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa3_JorgeCorrea
{
    class Shell
    {
        private int[] vector;

        public Shell()
        {
            Console.Clear();
            Console.WriteLine("BIENVENIDO AL MÉTODO DE ORDENAMIENTO SHELL \n\n");
        }

        public void cargarNumerosVector()
        {
            Console.Write("Ingrese la cantidad de número a ordenar: ");
            bool existe = false;

            try
            {

                int nroElementos = int.Parse(Console.ReadLine());

                if (nroElementos > 0)
                {
                    this.vector = new int[nroElementos];
                    int valor = 0;

                    for (int i = 0; i < this.vector.Length; i++)
                    {
                    repetir:
                        Console.Write("Ingrese el número " + (i + 1) + ": ");
                        valor = int.Parse(Console.ReadLine());

                        existe = existeNumero(valor);

                        if (existe == true)
                        {
                            Console.WriteLine("El número " + valor.ToString() + " ya existe en el vector, ingrese uno diferente!");
                            existe = false;
                            goto repetir;
                        }

                        this.vector[i] = valor;
                        valor = 0;
                        existe = false;
                    }

                    Console.WriteLine("¿Desea ver los números ingresados? (S/N):");
                    string opcion = Console.ReadLine();

                    if (opcion.Equals("S"))
                    {
                        this.mostrarNumerosVector();
                    }
                }
                else
                {
                    Console.WriteLine("No se ingresó una cantidad válida, por lo tanto, el programa no continuará!");
                    Console.ReadKey();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No se ingresó una cantidad válida, por lo tanto, el programa no continuará!");
                Console.ReadKey();
            }
        }

        private bool existeNumero(int numero)
        {
            bool existe = false;
            int numeroVector;

            for (int i = 0; i < this.vector.Length; i++)
            {
                numeroVector = this.vector[i];

                if (numeroVector.ToString().Equals(numero.ToString()))
                {
                    existe = true;
                    break;
                }
            }

            return existe;
        }

        public void mostrarNumerosVector()
        {
            for (int i = 0; i < this.vector.Length; i++)
            {
                Console.WriteLine("Número en la posición " + (i + 1) + ": " + this.vector[i].ToString());
            }
            Console.WriteLine("Presione ENTER para continuar!");
            Console.ReadKey();
        }

        public void ordenarVector()
        {
            int salto = 0;
            int a = 0;
            int auxi = 0;
            int e = 0;
            salto = this.vector.Length / 2;
            while (salto > 0)
            {
                a = 1;
                while (a != 0)
                {
                    a = 0;
                    e = 1;
                    while (e <= (this.vector.Length - salto))
                    {
                        if (this.vector[e - 1] > this.vector[(e - 1) + salto])
                        {
                            auxi = this.vector[(e - 1) + salto];
                            this.vector[(e - 1) + salto] = this.vector[e - 1];
                            this.vector[(e - 1)] = auxi;
                            a = 1;
                        }
                        e++;
                    }
                }
                salto = salto / 2;
            }

            Console.WriteLine("Los números fueron ordenados correctamente. Presione ENTER para continuar!");
            Console.ReadKey();
        }

        public void guardarVectorArchivo()
        {
            string nombreArchivo = "Shell.txt";
            StreamWriter writer = File.AppendText(nombreArchivo);

            for (int i = 0; i < this.vector.Length; i++)
            {
                writer.WriteLine(this.vector[i] + "  ");
            }

            writer.Close();
            Console.WriteLine("El vector ordenado por el método shell fue guardado correctamente en el archivo!");
            Console.ReadKey();
        }

    }
}
