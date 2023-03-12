using System;

namespace CALCULADORA
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("SELECCIONE OPCION:" + "\n" + "1 PARA SUMA" + "\n" + "2 PARA RESTA" + "\n" + "3 PARA MULTIPLICACIÓN" + "\n" + "OTRO SALIR");

            int x;
            x = int.Parse(Console.ReadLine());

            {
                //valor de a y b
                Console.WriteLine("SELECCIONE VALOR DE a");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("SELECCIONE VALOR DE b");
                b = int.Parse(Console.ReadLine());
                int suma = a + b;
                int resta = a - b;
                int multi = a * b;

                //OPCION DE USUARIO
                {
                    switch (x)
                    {
                        case 1:
                            
                            Console.WriteLine("SUMA = " + suma);

                            break;

                        case 2:
                            
                            Console.Write("RESTA =" + resta);
                            
                            break;

                        case 3:
                            
                            Console.Write("MULTIPLICACIÓN" + multi);
                            
                            break;                                                                                                            
                    }

                    Console.WriteLine("ADIOS...");
                    Console.ReadKey();
                }



            }



        }
    }
}
