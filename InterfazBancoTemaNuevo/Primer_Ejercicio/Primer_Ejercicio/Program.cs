

using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Xml.Schema;
//Jorge Wang Wang
Boolean bucle = true;
while (bucle)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("                                                          X X X X X X X X X");
    Console.WriteLine("                                                        X X X X X X X X X X X");
    Console.Write("                                                      X X X "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0 0"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(" X X X X X X X X");
    Console.Write("                                   X X X X X X X      X X "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0 0 0 0 "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine ("X X X X X X X X");
    Console.Write("      X X X X X              X X X              X X X X X "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0 0 0 0 0"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(" X X X X X X X");
    Console.Write("   X X X X X X X X X     X X                            X X X X "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0 0 0 "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("X X X X X X");
    Console.Write("  X X X X X X X X X X X  X X                                X X "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0 0 0 0 0 0"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine ("X X X");
    Console.Write("X X X X X X X X X X X X X                                     X X "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0 0 0 0 0 "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("X X X");
    Console.Write("X X X X X"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0 0 0"); Console.ForegroundColor = ConsoleColor.White; Console.Write(" X X X X                                         X X "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0 0 0 0 "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("X X X");
    Console.Write("X X X X X "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0 0"); Console.ForegroundColor = ConsoleColor.White; Console.Write(" X X X X                                             X X "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0 0 0 "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("X X X");
    Console.Write("X X X X "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0 0 0"); Console.ForegroundColor = ConsoleColor.White; Console.Write(" X X X                                                   X X"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" 0 0"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(" X X");
    Console.Write("X X X X "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0 0 0"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(" X X                                                     X X X X");
    Console.Write("X X X"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" 0 0 0"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("X X X                                                     X X X");
    Console.Write("X X X "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0 0"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(" X X X                                                         X X");
    Console.Write("X X "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0 0 0"); Console.ForegroundColor = ConsoleColor.White; ; Console.WriteLine(" X X X                                                           X");
    Console.Write("X X "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0 0"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(" X X X                                                             X");
    Console.WriteLine("  X X X X X X                                      X X X                  X");
    Console.WriteLine("    X X X X X                                  X X X X X X X                X");
    Console.WriteLine("          X X                                  X X X X X X X X              X");
    Console.WriteLine("          X         X X X X X                X X X X X X X X X X            X");
    Console.Write("          X        X X X X X X X             X X "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("0 0 "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("X X X X X X            X");
    Console.Write("          X       X X X X X X X X            X X "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("0 0 "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("X X X X X X            X");
    Console.Write("          X      X X X X X X"); Console.ForegroundColor = ConsoleColor.Green; Console.Write(" 0 0"); Console.ForegroundColor = ConsoleColor.White; Console.Write(" X             X "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("0 0"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(" X X X X X X            X");
    Console.Write("          X      X X X X X X "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("0 0"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(" X    X X X X    X X X X X X X X            X");
    Console.Write("          X      X X X X X X "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("0 0 "); Console.ForegroundColor = ConsoleColor.White; Console.Write("X   X "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("0 0 "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("X X    X X X X X X X            X");
    Console.WriteLine("          X      X X X X X X X X X  X X X X X X      X X X X X            X");
    Console.WriteLine("          X      X X X X X X X X X    X X X X                             X");
    Console.WriteLine("          X      X X X X X X X X          X                             X");
    Console.WriteLine("            X      X X X X X X            X                           X");
    Console.WriteLine("            X        X X X X        X     X X      X                X");
    Console.WriteLine("              X                        X X X X X X             X X");
    Console.Write("                X X                      X "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("0 0"); ; Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(" X             X");
    Console.WriteLine("            X X X                          X X         X X X     X X X X X");
    Console.WriteLine("          X X     X X X X                      X X X X       X   X X X X X X");
    Console.WriteLine("          X X X X         X X X X X X X X X X X              X X X X X X X X");
    Console.WriteLine("        X X X X X X                                            X X X X X X X");
    Console.Write("        X X X X X X X"); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(":]"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\"); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("[:"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine ("X X X X X X X");
    Console.Write("        X X X X X X X"); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(":]         "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("1.Ejercicio Vocales"); Console.Write("          "); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("[::"); Console.ForegroundColor = ConsoleColor.White;Console.WriteLine("X X X X X X X");
    Console.Write("        X X X X X X X"); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(":]");  Console.Write("                                      "); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("[::]");Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("X X X X X X");
    Console.Write("        X X X X X X X"); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write (":]         "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("2.Ejercicio Impares");  Console.Write("          "); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("[::]");Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("  X X X");
    Console.Write("          X X X X X"); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("[::]"); Console.Write("                                      [::]      "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("X");
    Console.Write("          X X X X  "); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("[::]         "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write ("3.Ejercicio Semana");  Console.Write("           "); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("[::]");Console.ForegroundColor = ConsoleColor.White;Console.WriteLine ("      X");
    Console.Write("            X X    "); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("[::]");Console.Write("                                      "); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("[::]"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("      X");
    Console.Write("            X X X X X"); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(":]         "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("4.Ejercicio multiplicacion"); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("   [::]");Console.ForegroundColor = ConsoleColor.White;Console.WriteLine("X X X X X X");
    Console.Write("           X X X X X X X X                                   "); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("[:"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("X X X X X X X X");
    Console.Write("         X X X X X X"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" 0 0"); Console.ForegroundColor = ConsoleColor.White; Console.Write(" X X    "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("5.Salir"); Console.ForegroundColor = ConsoleColor.White; Console.Write("                      X X X "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0 0"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(" X X X X X");
    Console.Write("         X X X "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0 0 0 0 0"); Console.ForegroundColor = ConsoleColor.White; Console.Write(" X X X"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/"); Console.ForegroundColor = ConsoleColor.White; Console.Write("X "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0 0 "); Console.ForegroundColor = ConsoleColor.White; Console.Write( "X"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" 0 0 "); Console.ForegroundColor = ConsoleColor.White; Console.Write("X"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" 0 0 "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("X X");
    Console.Write("         X X X "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0 0"); Console.ForegroundColor = ConsoleColor.White; Console.Write(" X X X "); Console.Write("0 0"); Console.ForegroundColor = ConsoleColor.White; Console.Write(" X                             X "); Console.Write("0 0 "); Console.ForegroundColor = ConsoleColor.White; Console.Write("X X X X "); Console.Write("0 0 "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("X X");
    Console.Write("         X "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0"); Console.ForegroundColor = ConsoleColor.White; Console.Write(" X X X X X X "); Console.Write("0 0 "); Console.ForegroundColor = ConsoleColor.White; Console.Write("X X                         X X X X X X X X X X "); Console.Write("0 "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("X");
    Console.Write("         X "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0 0 "); Console.ForegroundColor = ConsoleColor.White; Console.Write("X X X "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0 0 "); Console.ForegroundColor = ConsoleColor.White; Console.Write("X X X X                         X X X X X "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0 0 "); Console.ForegroundColor = ConsoleColor.White; Console.Write("X X "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0 0 "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("X");
    Console.Write("         X X X X X "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0 0 0 0 0"); Console.ForegroundColor = ConsoleColor.White; Console.Write(" X X                         X X X X "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0 0 0 0 "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("X X X X");
    Console.Write("         X X X X "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0 0 0 0 0 0 "); Console.ForegroundColor = ConsoleColor.White; Console.Write("X X         X X X X         X X X"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" 0 0 0 0 0 "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("X X X X");
    Console.Write("         X X X X "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0 0 0 0 0 0 "); Console.ForegroundColor = ConsoleColor.White; Console.Write("X X   X X X         X X X X X X "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0 0 0 0 0 0 "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("X X X");
    Console.Write("         X X X X X "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0 0 0 0 0 "); Console.ForegroundColor = ConsoleColor.White; Console.Write("X X X                   X X X X X "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0 0 0 0"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(" X X X X");
    Console.Write("           X X X X X "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0 0 0 "); Console.ForegroundColor = ConsoleColor.White; Console.Write("X X X                       X X X X X "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("0 0 "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("X X X X");
    Console.WriteLine("             X X X X X X X X                             X X X X X X X X X");
    Console.WriteLine("                                    Jorge Wang Wang\n");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("                           Pon el Ejercicio que quiera realizar: ");


    string datos = Console.ReadLine();
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;


    switch (datos)
    {
        case "1"://Primer Ejercicio
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("[/---------------------------------------------------\\]");
            Console.Write("[|__________()"); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("Ejercicio de Contar Vocales"); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.WriteLine("()__________|]");
            Console.WriteLine("[\\---------------------------------------------------/]");
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.Write("Escriba una frase: ");
            string texto = Console.ReadLine().ToLower();
            int cantidada = 0;
            int cantidade = 0;
            int cantidadi = 0;
            int cantidado = 0;
            int cantidadu = 0;


            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == 'a' || texto[i] == 'á')
                {
                    cantidada++;
                }
                else if (texto[i] == 'e' || texto[i] == 'é')
                {
                    cantidade++;
                }
                else if (texto[i] == 'i' || texto[i] == 'í')
                {
                    cantidadi++;
                }
                else if ((texto[i] == 'o') || texto[i] == 'ó')
                {
                    cantidado++;
                }
                else if (texto[i] == 'u' || texto[i] == 'ú' || texto[i] == 'ü')
                {
                    cantidadu++;
                }
            }
            int total = cantidada + cantidade + cantidadi + cantidado + cantidadu;
            Console.WriteLine("---------------------------------------------\nLa cantidad de vocales que hay en la frase es: \na: " + cantidada + "\ne: " + cantidade + "\ni: " + cantidadi + "\no: " + cantidado + "\nu: " + cantidadu + "\nEn su totalalidad hay "+ total+"\n-----------------------------------------------");
            Console.WriteLine("Pulse cualquier tecla para volver al menu");
            Console.ReadKey();
            break;
        case "2"://segundo Ejercicio
            int contador = 0;
            int final = 10;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("[/---------------------------------------------------\\]");
            Console.Write("[|____________()"); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("Ejercios Numeros Impares"); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.WriteLine("()___________|]");
            Console.WriteLine("[\\---------------------------------------------------/]");
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 1 )
                {
                    contador++;
                    Console.Write(i + " | ");
                    
                }

                if (i == 0)
                {
                    Console.Write("     | ");
                }
                if (i % 10 == 0 && i != 0)
                {

                    Console.Write($"\n----------------------------------\n     | ");
                }

            }
            Console.WriteLine("\n\nHay un total de " + contador + " numeros impares\n");
            Console.WriteLine("Pulse cualquier tecla para volver al menu");
            Console.ReadKey();
            break;
        case "3"://tercer Ejercicio
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("[/---------------------------------------------------\\]");
            Console.Write("[|____________()"); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("Ejercicio Fin de Semana"); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.WriteLine("()____________|]");
            Console.WriteLine("[\\---------------------------------------------------/]");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[/\\/\\(Lunes---Martes---Miercoles---Jueves---Viernes---Sabado---Domingo)/\\/\\]");
            Console.Write("Escribe un dia de la semana: ");
            String dia = Console.ReadLine().ToLower();

            switch (dia)
            {
                case "lunes":
                case "martes":
                case "miercoles":
                case "miércoles":
                case "jueves":
                case "viernes":
                    Console.WriteLine("Es un dia de Entre Semana");
                    break;

                case "sabado":
                case "sábado":
                case "domingo":
                    Console.WriteLine("Es Fin del semana");
                    break;
                 default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("[::::::::::::::::Errror::::::::::::::::]");
                    Console.WriteLine("      No existe ese dia de la semana");
                    break;
                
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Pulse cualquier tecla para volver al menu");
            Console.ReadKey();
            break;
        case "4"://cuarto Ejercicio
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("[/---------------------------------------------------\\]");
            Console.Write("[|__________()"); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("Ejercicio de Multiplicación"); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.WriteLine("()__________|]");
            Console.WriteLine("[\\---------------------------------------------------/]");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Elija un numero que quiera multiplicar: ");
            string multiplicador = Console.ReadLine();

            try
            {
                int vmulti = int.Parse(multiplicador);
                if (vmulti >= 0 && vmulti <= 10)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"[::::::::::: tabla del {vmulti} :::::::::::]");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    for (int i = 1; i < 11; i++)
                    {
                        Console.WriteLine($"            {vmulti} x {i} = {vmulti * i}");
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"[:::::::::: tabla del {vmulti} ::::::::::::]");

                    
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("[::::::::::::::::::Error:::::::::::::::::]");
                    Console.WriteLine("      Solo admite un rango del [0-10]");
                }
                Console.ForegroundColor= ConsoleColor.Cyan;    
                Console.WriteLine("Pulse cualquier tecla para volver al menu");
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[::::::::::::::Error:::::::::::::]");
                Console.WriteLine("         No es un numero");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Pulse cualquier tecla para volver al menu");
                Console.ReadKey();

            }
            break;
        case "5":
            bucle = false;
            break;
        default:
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("[:::::::::::::::::::: Error ::::::::::::::::::::]");
            Console.WriteLine("    Solo admite un numero del rango de [1-5]");
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine("Pulse cualquier tecla para volver al menu");
            Console.ReadKey();
            break;
    }


}
Console.WriteLine("Pulse cualquier tecla para finalizar...");
Console.ReadKey();
