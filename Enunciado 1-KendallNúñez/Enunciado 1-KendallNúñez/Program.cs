using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enunciado_1_KendallNúñez
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool bombillo= false;
            //if(bombillo)
            //{
            //    Console.WriteLine("Encencido");
            //}
            //else
            //{
            //    Console.WriteLine("Apagado");
            //}
            //    Console.ReadLine();

            //int hayCarro = 0, hayGasolina = 1;
            //if (hayCarro == 1 && hayGasolina == 1)
            //{
            //    Console.WriteLine("Hay paseo");
            //}
            //else
            //{
            //    Console.WriteLine("No hay paseo");
            //}
            //Console.ReadLine();

            //int hayCarro = 0, hayMoto = 0;
            //if (hayCarro == 1 || hayMoto == 1)
            //{
            //    Console.WriteLine("Hay paseo");
            //}
            //else
            //{
            //    Console.WriteLine("No hay paseo");
            //}
            //Console.ReadLine();

            //int num1;
            //Console.WriteLine("Digite el número");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //if (num1 % 2 == 0)
            //{
            //    Console.WriteLine("El numero" + " par");
            //}
            //else
            //{
            //    Console.WriteLine("El numero" + " impar");
            //}
            //Console.ReadLine();


            //for (int i =1; i <= 100; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.WriteLine(i + " par");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i + "impar");
            //    }

            //}
            //Console.ReadLine();

            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("1.Sumar");
                Console.WriteLine("2.Resta");
                Console.WriteLine("3.Division");
                Console.WriteLine("4.Multi");
                Console.WriteLine("0.Salir");
                int num1, num2, resultado;
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Digite el primer numero");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite el segundo numero");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        resultado = num1 + num2;
                        Console.WriteLine("El resultado es: " + resultado);
                        Console.WriteLine("Presione cualquier tecla para salir");
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Digite el primer numero");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite el segundo numero");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        resultado = num1 - num2;
                        Console.WriteLine("El resultado es: " + resultado);
                        Console.WriteLine("Presione cualquier tecla para salir");
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Digite el primer numero");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite el segundo numero");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        resultado = num1 * num2;
                        Console.WriteLine("El resultado es: " + resultado);
                        Console.WriteLine("Presione cualquier tecla para salir");
                        Console.ReadLine();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Digite el primer numero");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite el segundo numero");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        resultado = num1 / num2;
                        Console.WriteLine("El resultado es: " + resultado);
                        Console.WriteLine("Presione cualquier tecla para salir");
                        Console.ReadLine();
                        break;
                }
            } while (op != 0);
            
        }
    }
}