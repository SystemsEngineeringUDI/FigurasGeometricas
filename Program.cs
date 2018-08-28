using System;
/*
 * 
 * Date 21/08/2018
 * autor Jhon velasco
 * @frediv0406
 * Description: This algorithm calculates different areas of geometrical figures
 * 
 */

namespace Prueba2
{
    class Program
    {
        //metodo encargado de validar valores mayores a 0 en las entradas
        static private double validacion()
        {
            double retorno=0;
            do
            {
                try
                {
                    retorno = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                }
                if (retorno <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Digite un valor correcto (Mayor entrada 0)");
                }

            } while (retorno <= 0);
            Console.Clear();
            return retorno;
        }
        //metodo encargado de comprobar si se desea permanecer en el programa o salir de este 
        static private int comprobacion()
        {
            int entrada=2;
            Boolean bamdera;
            do
            {
                bamdera = true;
                try
                {
                    Console.Clear();
                    Console.WriteLine("Seleccione una opcion\n1---------Calcular nueva area\n0---------Salir");
                    entrada = int.Parse(Console.ReadLine());
                }
                catch (Exception){
                }
                if (entrada < 0 || entrada > 1)
                {
                    Console.Clear();
                    Console.WriteLine("\n****Digite un valor correcto**** \n");
                    Console.WriteLine("\n\n\nPresione enter para continuar...");
                    Console.ReadLine();
                    bamdera = false;
                }
            } while (bamdera==false);
            return entrada;
        }
        static private double area(double ladoA, double ladoB) => ladoA * ladoB;
        static private double area(double ladoA) => ladoA * ladoA;
        static void Main(string[] args)
        {


            double enradaMenu=9, entradaUno, entradaDos, resultado;
            string entradaMenu;
            do
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("Sistema de claculo de areas\nPresione:\n1----Area de un retangulo\n2----Area de un circulo\n3----Area de un tirangulo\n4----Area de un cuadrado\n0----Salir");
                    entradaMenu = Console.ReadLine();
                    enradaMenu = double.Parse(entradaMenu);
                }
                catch (Exception) { }

                switch (enradaMenu)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Digite la base del Rectangulo");
                            entradaUno = validacion();
                            Console.WriteLine("Digite la altura del Rectangulo");
                            entradaDos = validacion();
                            resultado = area(entradaUno,entradaDos);
                            Console.WriteLine("Ancho: {0}\nAlto: {1}\nEl area del rectangulo es: {2} U^2",entradaUno,entradaDos,resultado);
                            Console.WriteLine("\n\n\nPresione enter para continuar...");
                            Console.ReadLine();
                            enradaMenu= comprobacion();
                            Console.Clear();
                        }

                        break;
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Digite el radio del circulo");
                            entradaUno = validacion();
                            double re = Math.PI * Math.Pow(entradaUno,2);
                            Console.WriteLine("Radio: {0}\nEl area del circulo es: {1} U^2", entradaUno, re);
                            Console.WriteLine("\n\n\nPresione enter para continuar...");
                            Console.ReadLine();
                            enradaMenu = comprobacion();
                            Console.Clear();
                        }

                        break;
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Digite la base del triangulo");
                            entradaUno = validacion();
                            Console.WriteLine("Digite la altura del triangulo");
                            entradaDos = validacion();
                            resultado = (entradaUno * entradaDos)/2;
                            Console.WriteLine("Ancho: {0}\nAlto: {1}\nEl area del triangulo es: {2} U^2", entradaUno, entradaDos, resultado);
                            Console.ReadLine();
                            enradaMenu = comprobacion();
                            Console.Clear();
                        }

                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Digite la base del Cuadrado");
                        entradaDos = area(entradaUno = validacion());
                        Console.WriteLine("El area del cuaddrado es: {0} U^2", entradaDos);
                        Console.WriteLine("\n\n\nPresione enter para continuar...");
                        Console.ReadLine();
                        enradaMenu = comprobacion();
                        Console.Clear();
                        break;
                    case 0:
                        enradaMenu = 0;
                        break;
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("\n****Digite un valor correcto**** \n");
                            Console.WriteLine("\n\n\nPresione enter para continuar...");
                            Console.ReadLine();
                        }
                        break;
                }
            } while (enradaMenu != 0);

        }
    }
}
