

using System;
class Program
{
    static void Main(string[] args)
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Conversion de Tipos");
            Console.WriteLine("2. Operaciones con tipos de datos");
            Console.WriteLine("3. Uso de char y string");
            Console.WriteLine("4. Uso de tipos de datos numericos");
            Console.WriteLine("5. Salir");

            Console.Write("Por favor, seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Ha seleccionado la Opción 1.");

                            // Solicitar al usuario un número entero y caracter
                            Console.Write("\nIngresa un número entero: ");
                            int entero = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Ingresa un carácter: ");
                            char caracter = Console.ReadKey().KeyChar;

                            // conversiones
                            decimal NumDec = Convert.ToDecimal(entero);
                            float NumFlo = (float)NumDec;
                            int NumEnt = (int)NumFlo;
                            int entchar = (int)caracter;
                            char char1 = (char)entero;

                            //impresion de resultados
                            Console.WriteLine("\n\nEl número decimal es: " + NumDec.ToString("F2"));
                            Console.WriteLine("El número flotante es: " + NumFlo.ToString("F2"));
                            Console.WriteLine("El número entero equivalente al flotante es: " + NumEnt);
                            Console.WriteLine($"El valor entero del carácter '{caracter}' es: {entchar}");
                            Console.WriteLine($"El carácter equivalente al número entero {entero} es: {char1}");
    
                            Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("Ha seleccionado la Opción 2.");
                    
                            // Solicitar al usuario dos números.
                            Console.Write("\nIngresa un número entero: ");
                            int Num1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("\nIngresa un número entero: ");
                            int Num2 = Convert.ToInt32(Console.ReadLine());

                            // proceso
                            //suma
                            int suma = Num1 + Num2;

                            // resta de decimales
                            //conversion
                            decimal NumDec1 = Convert.ToDecimal(Num1);
                            decimal NumDec2 = Convert.ToDecimal(Num2);
                            //proceso
                            decimal RestaDec = NumDec1 - NumDec2;

                            // multiplicacion de flotantes
                            //conversion 
                            float NumFlo1 = (float)Num1;
                            float NumFlo2 = (float)Num2;
                            //proceso
                            float Multflo = NumFlo1 * NumFlo2;

                            //proceso division entre enteros
                            int divi = Num1 / Num2;

                            //proceso modulo de enteros
                            int rest = Num1 % Num2;

                            //impresion de resultados
                            Console.WriteLine("\n\nLa suma de los números enteros es: " + suma);
                            Console.WriteLine("La resta de los números decimales es: " + RestaDec.ToString("F2"));
                            Console.WriteLine("La multiplicacion con resultado flotante es: " + Multflo.ToString("F2"));
                            Console.WriteLine("La Division de los números enteros es: " + divi);
                            Console.WriteLine("La Resto de los números enteros es: " + rest);


                    break;
                case "3":
                    Console.WriteLine("Ha seleccionado la Opción 3.");
                            
                            // Solicitar al usuario una palabra y caracter a buscar.
                            Console.Write("Ingresa una palabra: ");
                            string palabra = Console.ReadLine();
                            Console.Write("Ingresa una caracter a buscar: ");
                            string buschar = Console.ReadLine();
                            Boolean result;
                            string palabra2;
                            string palabra3;
                            string palinv = "";
                            int contador = 0;

                            //proceso mayuscula
                            palabra2 = palabra.ToUpper();

                            //proceso minuscula
                            palabra3 = palabra.ToLower();

                            //procesos invertir palabra
                            for (int x = palabra.Length -1;x >= 0; x -- )
                            {
                                palinv += palabra[x]; 
                            }

                            //proceso buscar palabra
                            result = palabra.Contains(buschar);
                            if (result == true)
                            {
                                buschar = "El caracter si se encuentra en la cadena de texto";
                            }
                            else 
                            {
                                buschar = "El caracter no se encuentra en la cadena de texto";
                            }

                            //proceso buscar vocal
                            for (int i = 0;i < palabra.Length; i ++ )
                            {
                                if (palabra[i] == 'a'|| palabra[i] == 'e'|| palabra[i] == 'i'|| palabra[i] == 'o'|| palabra[i] == 'u')
                                {
                                    contador++;
                                }
                            }

                            //impresion de resultados
                            Console.WriteLine("\n\n " + palabra2);
                            Console.WriteLine(palabra3);    
                            Console.WriteLine(palinv);
                            Console.WriteLine(buschar);  
                            Console.WriteLine("La cantidad de vocales de la palabra es de: " + contador + "vocales");   
                            


                    break;
                    case "4":
                    Console.WriteLine("Ha seleccionado la Opción 3.");
                   
                            // area de triangulo
                            Console.Write("\n\nIngresa base del triagulo: ");
                            int baset = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Ingresa altura del triagulo: ");
                            int altu = Convert.ToInt32(Console.ReadLine());

                            // volumen de esfera
                            Console.Write("\n\nIngresa el valor del radio: ");
                            Double radio = Double.Parse(Console.ReadLine());     
                            
                            // distancia entre puntos
                            Console.Write("\n\nIngresa el primer valor de X: ");
                            int x1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Ingresa el segundo valor de X: ");
                            int x2 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Ingresa el primer valor de Y: ");
                            int y1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Ingresa el segundo valor de Y: ");
                            int y2 = Convert.ToInt32(Console.ReadLine());

                            // Fahrenheit a Celsius         
                            Console.Write("\n\nIngresa la temperatura en Fahrenheit: ");
                            float fh = float.Parse(Console.ReadLine());
                            
                            //  Celsius a Fahrenheit         
                            Console.Write("\n\nIngresa la temperatura en Centigrados: ");
                            float cs = float.Parse(Console.ReadLine());

                            // procesos
                            int triangu = (baset * altu)/2;
                            Double volumenes = (4.0/3.0)* Math.PI*(Math.Pow(radio,3));
                            double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
                            Double c = (fh-32) /1.8;
                            Double f = (cs * 9/5) + 32;

                            //impresion de resultados
                            Console.WriteLine("\n\nEl área del triangulo es de:  " + triangu);
                            Console.WriteLine("El volumen de la esfera es de:  " + volumenes);
                            Console.WriteLine("La distancia entre dos puntos es de:  " + d);
                            Console.WriteLine("La temperatura en grados Centigrados es de:  " + c);
                            Console.WriteLine("La temperatura en grados Fahrenheit es de:  " + f);


                    break;
                case "5":
                    Console.WriteLine("Saliendo del programa...");
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }

            Console.WriteLine(); // fin 
        }
    }
}

 


