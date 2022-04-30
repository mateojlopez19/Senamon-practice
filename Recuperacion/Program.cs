using System;
using System.Collections.Generic;
using System.Text;


namespace Recuperacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreEntrenador, emailEntrenador;
            DateTime fechaNacimientoEntrenador;
            int opcion, opcionEntrenador, opcionSenamon, opcionEstadistica, opcionPeleaSenamon = 0, opcionPelea = 0, turno = 1, contUno=5, contDos = 5;
            bool verificacion, continuar = true;
            Senamon senamon;
            Entrenador entrenador;
            List<Senamon> mundoSenamon = new List<Senamon>();
            List<Entrenador> listaEntrenadores = new List<Entrenador>();

            senamon = new Senamon("Hitmonchan", "Pelea", 50.2, 105, 79, 2, "Pokemon 107");
            mundoSenamon.Add(senamon);
            senamon = new Senamon("Venasaur", "Hierva", 100, 80, 82, 3, "Pokemon 003");
            mundoSenamon.Add(senamon);
            senamon = new Senamon("Starmie", "Agua", 80, 75, 85, 1, "Pokemon 121");
            mundoSenamon.Add(senamon);
            senamon = new Senamon("Charizard", "Fuego", 90.5, 78, 84, 3, "Pokemon 006");
            mundoSenamon.Add(senamon);
            senamon = new Senamon("Scyther", "Volador", 56, 110, 80, 1, "Pokemon 123");
            mundoSenamon.Add(senamon);
            senamon = new Senamon("Beedrill", "Volador", 29.5, 90, 40, 3, "Pokemon 015");
            mundoSenamon.Add(senamon);
            senamon = new Senamon("Pidgeotto", "Volador", 30, 60, 55, 2, "Pokemon 017");
            mundoSenamon.Add(senamon);
            senamon = new Senamon("Blastoise", "Agua", 85.5, 83, 100, 3, "Pokemon 009");
            mundoSenamon.Add(senamon);
            senamon = new Senamon("Raichu", "Electrico", 30, 90, 55, 2, "Pokemon 026");
            mundoSenamon.Add(senamon);
            senamon = new Senamon("Sandslash", "Tierra", 29.5, 100, 110, 2, "Pokemon 028");
            mundoSenamon.Add(senamon);
            senamon = new Senamon("Ninetales", "Fuego", 19.9, 76, 75, 1, "Pokemon 038");
            mundoSenamon.Add(senamon);
            senamon = new Senamon("Golbat", "Volador", 55, 80, 70, 2, "Pokemon 042");
            mundoSenamon.Add(senamon);
            senamon = new Senamon("Dugtrio", "Tierra", 33.3, 100, 50, 2, "Pokemon 051");
            mundoSenamon.Add(senamon);
            senamon = new Senamon("Persian", "Tierra", 32, 60, 60, 2, "Pokemon 053");
            mundoSenamon.Add(senamon);
            senamon = new Senamon("Golduck", "Agua", 76.6, 82, 78, 2, "Pokemon 055");
            mundoSenamon.Add(senamon);
            senamon = new Senamon("Arcanine", "Fuego", 155, 110, 80, 2, "Pokemon 059");
            mundoSenamon.Add(senamon);
            senamon = new Senamon("Poliwrap", "Agua", 54, 95, 95, 3, "Pokemon 062");
            mundoSenamon.Add(senamon);
            senamon = new Senamon("Kadabra", "Psiquico", 56.5, 35, 30, 2, "Pokemon 064");
            mundoSenamon.Add(senamon);
            senamon = new Senamon("Machamp", "Lucha", 130, 130, 80, 3, "Pokemon 068");
            mundoSenamon.Add(senamon);
            senamon = new Senamon("Tentacruel", "Agua",55, 70, 65, 2, "Pokemon 073");
            mundoSenamon.Add(senamon);
            senamon = new Senamon("Golem", "Piedra", 300, 120, 130, 3, "Pokemon 076");
            mundoSenamon.Add(senamon);
            senamon = new Senamon("Gengar", "Veneno", 9, 65, 60, 3, "Pokemon 094");
            mundoSenamon.Add(senamon);

            //Ciclo para ingresar a cada entrenador y elegir sus 5 Senamones
            for (int i = 0; i < 2; i++)
            {           
                Console.Write($"Ingrese el nombre del entrenador Senamon {i+1}: ");
                nombreEntrenador = Console.ReadLine();

                Console.Write("Ingrese el email: ");
                emailEntrenador = Console.ReadLine();

                Console.Write("Ingrese la fecha de nacimiento: ");
                _ = DateTime.TryParse(Console.ReadLine(), out fechaNacimientoEntrenador);
                //atributos del objeto
                entrenador = new Entrenador(nombreEntrenador, emailEntrenador, fechaNacimientoEntrenador);

                //Mostrar los Senamones con su numero de posicion del mundoSenamon
                Console.WriteLine("\nDe la siguiente lista de Senamones elija 5 en base a su numero: \n");
                for (int k = 0; k < mundoSenamon.Count; k++)
                {
                    Console.WriteLine($" {k}: {mundoSenamon[k].Nombre}");
                }
                //Eleccion de los 5 Senamones por parte del entrenador
                for (int k = 0; k < 5; k++)
                {
                    while (true)
                    {
                        Console.Write("\n***** Va a ingresar el senamon #" + (k + 1) + " ***** \n   Digite la opcion: ");
                        verificacion = int.TryParse(Console.ReadLine(), out opcion); //casa

                        if (verificacion == true && opcion >= 0 && opcion < mundoSenamon.Count)
                        {
                            entrenador.setSenamon(mundoSenamon[opcion]);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("  Error, dato ingresado no valido");
                        }
                    }
                }
                Console.WriteLine("-----------------------------------------------------------------");
                listaEntrenadores.Add(entrenador);
            }

            //Mostrar Entrenadores
            for (int i = 0; i < listaEntrenadores.Count; i++)
            {
                Console.WriteLine($"\n\n>>Entrenador: {listaEntrenadores[i].getNombre().ToUpper()} \n- Email: " +
                    $"{listaEntrenadores[i].Email} \n- Fecha Nacimiento: {listaEntrenadores[i].FechaNacimiento.ToShortDateString()}" +
                    $" \n- Nivel Experiencia: {listaEntrenadores[i].NivelExperiencia} \n- Numero Victorias: {listaEntrenadores[i].NumVictorias}");
                Console.WriteLine("\n**Sus Senamones son: **");
                for (int k = 0; k < 5; k++)
                {
                    Console.WriteLine($"Nombre: {listaEntrenadores[i].getVectorSenamon()[k].Nombre}");
                }
            }

            //Menu de opciones
            while (continuar == true)
            {
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine("\nOpciones Generales:");
                Console.WriteLine("1- Cambiar Senamon  2- Aumentar Estadisticas Senanon  3- Iniciar Batalla  4- Finalizar");
                do
                {
                    Console.Write("\nDigite la opcion correspondiente: ");
                    verificacion = int.TryParse(Console.ReadLine(), out opcion);
                } while (!verificacion || opcion < 1 || opcion > 4);

                switch (opcion)
                {
                    case 1: //Cambiar Senamon
                        Console.Write($"  -Digite el numero del entrenador que cambiara sus Senamones" +
                            $" (1- {listaEntrenadores[0].getNombre()}  2- {listaEntrenadores[1].getNombre()}" +
                            $"  3- Cancelar): ");
                        do
                        {
                            Console.Write("   Digite el numero correspondiente: ");
                            verificacion = int.TryParse(Console.ReadLine(), out opcionEntrenador);
                        } while (opcionEntrenador != 1 && opcionEntrenador != 2 && opcionEntrenador != 3);
                        if (opcionEntrenador == 1)
                        {
                            Console.WriteLine("Digite el numero de Senamon que desea cambiar: ");
                            //imprime senamon
                            for (int k = 0; k < 5; k++)
                            {
                                Console.WriteLine($"   Senamon {k}: {listaEntrenadores[0].getVectorSenamon()[k].Nombre}");
                            }
                            //valida numero valido y elimina el senamon
                            do
                            {
                                Console.Write("\nDigite el numero correspondiente: ");
                                verificacion = int.TryParse(Console.ReadLine(), out opcionSenamon);
                            } while (!verificacion || opcionSenamon < 0 || opcionSenamon > 4);
                            listaEntrenadores[0].eliminarSenamon(opcionSenamon);
                            //imprime senamon y se elige el nuevo
                            Console.WriteLine("   \nSenamon que va a agregar, elija 1 en base a su numero: ");
                            for (int k = 0; k < mundoSenamon.Count; k++)
                            {
                                Console.WriteLine($"    {k}: {mundoSenamon[k].Nombre}");
                            }
                            do
                            {
                                Console.Write("   Digite el numero correspondiente: ");
                                verificacion = int.TryParse(Console.ReadLine(), out opcionSenamon);
                            } while (!verificacion || opcionSenamon < 0 || opcionSenamon >= mundoSenamon.Count);
                            listaEntrenadores[0].setSenamon(mundoSenamon[opcionSenamon]);
                        }
                        else if (opcionEntrenador == 2)
                        {
                            Console.WriteLine("   \nDigite el numero de Senamon que desea cambiar: ");
                            for (int k = 0; k < 5; k++)
                            {
                                Console.WriteLine($"   Senamon {k}: {listaEntrenadores[1].getVectorSenamon()[k].Nombre}");
                            }
                            do
                            {
                                Console.Write("   Digite el numero correspondiente: ");
                                verificacion = int.TryParse(Console.ReadLine(), out opcionSenamon);
                            } while (!verificacion || opcionSenamon < 0 || opcionSenamon > 4);
                            listaEntrenadores[1].eliminarSenamon(opcionSenamon);
                            Console.WriteLine("   \nDe la siguiente lista de Senamones elija 1 en base a su numero: ");
                            for (int k = 0; k < mundoSenamon.Count; k++)
                            {
                                Console.WriteLine($"    {k}: {mundoSenamon[k].Nombre}");
                            }
                            do
                            {
                                Console.Write("   Digite el numero correspondiente: ");
                                verificacion = int.TryParse(Console.ReadLine(), out opcionSenamon);
                            } while (!verificacion || opcionSenamon < 0 || opcionSenamon >= mundoSenamon.Count);
                            listaEntrenadores[1].setSenamon(mundoSenamon[opcionSenamon]);
                        }
                        else { Console.WriteLine("    Usted decidio no cambiar ningun Senamon"); }
                        break;

                    case 2: //Aumentar estadisticas
                        Console.Write($"  \nDigite el numero del entrenador que aumentara una estaditica de un Senamon\n" +
                            $" (1- {listaEntrenadores[0].getNombre()}  2- {listaEntrenadores[1].getNombre()}" +
                            $"  3- Cancelar): ");
                        do
                        {
                            Console.Write("\n   Digite el numero correspondiente: ");
                            verificacion = int.TryParse(Console.ReadLine(), out opcionEntrenador);
                        } while (opcionEntrenador != 1 && opcionEntrenador != 2 && opcionEntrenador != 3);
                        if (opcionEntrenador == 1)
                        {
                            if (listaEntrenadores[0].NivelExperiencia >= 200)
                            {
                                Console.WriteLine("   \nDigite el numero de Senamon que desea aumentar: ");
                                for (int k = 0; k < 5; k++)
                                {
                                    Console.WriteLine($"   Senamon {k}: {listaEntrenadores[0].getVectorSenamon()[k].Nombre}");
                                }
                                do
                                {
                                    Console.Write("   Digite el numero correspondiente: ");
                                    verificacion = int.TryParse(Console.ReadLine(), out opcionSenamon);
                                } while (!verificacion || opcionSenamon < 0 || opcionSenamon > 4);
                                Console.WriteLine($"   \nDigite el numero de la estadistica a aumentar: 1- Salud actual: {listaEntrenadores[0].getVectorSenamon()[opcionSenamon].Salud}" +
                                    $"  2- Ataque actual: {listaEntrenadores[0].getVectorSenamon()[opcionSenamon].Ataque}");
                                do
                                {
                                    Console.Write("   Digite el numero correspondiente: ");
                                    verificacion = int.TryParse(Console.ReadLine(), out opcionEstadistica);
                                } while (opcionEstadistica != 1 && opcionEstadistica != 2);

                                if (opcionEstadistica == 1) //aumentar salud
                                {
                                    senamon = new Senamon(listaEntrenadores[0].getVectorSenamon()[opcionSenamon].Nombre, listaEntrenadores[0].getVectorSenamon()[opcionSenamon].Tipo, listaEntrenadores[0].getVectorSenamon()[opcionSenamon].Peso, listaEntrenadores[0].getVectorSenamon()[opcionSenamon].Salud + 20, listaEntrenadores[0].getVectorSenamon()[opcionSenamon].Ataque, listaEntrenadores[0].getVectorSenamon()[opcionSenamon].Fase, listaEntrenadores[0].getVectorSenamon()[opcionSenamon].Descripcion);
                                    listaEntrenadores[0].eliminarSenamon(opcionSenamon);
                                    listaEntrenadores[0].setSenamon(senamon);

                                }
                                else //aumentar ataque
                                {
                                    senamon = new Senamon(listaEntrenadores[0].getVectorSenamon()[opcionSenamon].Nombre, listaEntrenadores[0].getVectorSenamon()[opcionSenamon].Tipo, listaEntrenadores[0].getVectorSenamon()[opcionSenamon].Peso, listaEntrenadores[0].getVectorSenamon()[opcionSenamon].Salud, listaEntrenadores[0].getVectorSenamon()[opcionSenamon].Ataque + 20, listaEntrenadores[0].getVectorSenamon()[opcionSenamon].Fase, listaEntrenadores[0].getVectorSenamon()[opcionSenamon].Descripcion);
                                    listaEntrenadores[0].eliminarSenamon(opcionSenamon);
                                    listaEntrenadores[0].setSenamon(senamon);

                                }
                                listaEntrenadores[0].NivelExperiencia = listaEntrenadores[0].NivelExperiencia - 200;
                            }
                            else { Console.WriteLine("   Usted no tiene suficiente experiencia para aumentar una estadistica."); }
                        }
                        else if (opcionEntrenador == 2)
                        {
                            if (listaEntrenadores[1].NivelExperiencia >= 200)
                            {
                                Console.WriteLine("   \nDigite el numero de Senamon que desea aumentar: ");
                                for (int k = 0; k < 5; k++)
                                {
                                    Console.WriteLine($"   Senamon {k}: {listaEntrenadores[1].getVectorSenamon()[k].Nombre}");
                                }
                                do
                                {
                                    Console.Write("   Digite el numero correspondiente: ");
                                    verificacion = int.TryParse(Console.ReadLine(), out opcionSenamon);
                                } while (!verificacion || opcionSenamon < 0 || opcionSenamon > 4);
                                Console.WriteLine($"   \nDigite el numero de la estadistica a aumentar: 1- Salud actual: {listaEntrenadores[1].getVectorSenamon()[opcionSenamon].Salud}" +
                                    $"  2- Ataque actual: {listaEntrenadores[1].getVectorSenamon()[opcionSenamon].Ataque}");
                                do
                                {
                                    Console.Write("   Digite el numero correspondiente: ");
                                    verificacion = int.TryParse(Console.ReadLine(), out opcionEstadistica);
                                } while (opcionEstadistica != 1 && opcionEstadistica != 2);
                                if (opcionEstadistica == 1) //aumentar salud
                                {
                                    senamon = new Senamon(listaEntrenadores[1].getVectorSenamon()[opcionSenamon].Nombre, listaEntrenadores[1].getVectorSenamon()[opcionSenamon].Tipo, listaEntrenadores[1].getVectorSenamon()[opcionSenamon].Peso, listaEntrenadores[1].getVectorSenamon()[opcionSenamon].Salud + 20, listaEntrenadores[1].getVectorSenamon()[opcionSenamon].Ataque, listaEntrenadores[1].getVectorSenamon()[opcionSenamon].Fase, listaEntrenadores[1].getVectorSenamon()[opcionSenamon].Descripcion);
                                    listaEntrenadores[1].eliminarSenamon(opcionSenamon);
                                    listaEntrenadores[1].setSenamon(senamon);
                                    //listaEntrenadores[1].getVectorSenamon()[opcionSenamon].aumentarSalud();
                                }
                                else //aumentar ataque
                                {
                                    senamon = new Senamon(listaEntrenadores[1].getVectorSenamon()[opcionSenamon].Nombre, listaEntrenadores[1].getVectorSenamon()[opcionSenamon].Tipo, listaEntrenadores[1].getVectorSenamon()[opcionSenamon].Peso, listaEntrenadores[1].getVectorSenamon()[opcionSenamon].Salud, listaEntrenadores[1].getVectorSenamon()[opcionSenamon].Ataque + 20, listaEntrenadores[1].getVectorSenamon()[opcionSenamon].Fase, listaEntrenadores[1].getVectorSenamon()[opcionSenamon].Descripcion);
                                    listaEntrenadores[1].eliminarSenamon(opcionSenamon);
                                    listaEntrenadores[1].setSenamon(senamon);
                                    //listaEntrenadores[1].getVectorSenamon()[opcionSenamon].aumentarAtaque();
                                }
                                listaEntrenadores[1].NivelExperiencia = listaEntrenadores[1].NivelExperiencia - 200;
                            }
                            else { Console.WriteLine("   Usted no tiene suficiente experiencia para aumentar una estadistica."); }
                        }
                        else { Console.WriteLine("    Usted decidio no cambiar ninguna estadistica de Senamon"); }
                        break;

                    case 3:
                        Console.WriteLine("\n****************************INICIARÁ BATALLA POKEMON****************************");

                        //Batalla
                        Random random = new Random();
                        int numero = random.Next(1, 3);

                        for (int i = 0; i < 1; i++)
                        {

                            Console.Write($"\n>>Entrenador senamon {listaEntrenadores[0].getNombre().ToUpper()}\n");
                            Console.Write($"\n-Senamones disponibles:\n");
                            for (int k = 0; k < 5; k++)
                            {
                                Console.WriteLine($"   Senamon {k}: {listaEntrenadores[0].getVectorSenamon()[k].Nombre}");
                            }

                            do
                            {
                                Console.Write("\nDigite el numero del senamon a pelear: ");
                                _ = int.TryParse(Console.ReadLine(), out opcionPelea);
                            } while (opcionPelea < 0 || opcionPelea > 4);

                            while (listaEntrenadores[0].getVectorSenamon()[opcionPelea].Salud <= 0)
                            {
                                Console.WriteLine($"**El senamon {listaEntrenadores[0].getVectorSenamon()[opcionPelea].Nombre}, no tiene salud**");
                                do
                                {
                                    Console.Write("\nDigite el numero de otro senamon a pelear: ");
                                    _ = int.TryParse(Console.ReadLine(), out opcionPelea);
                                } while (opcionPelea < 0 || opcionPelea > 4);
                            }

                            Console.WriteLine($"**peleador 1: {listaEntrenadores[0].getVectorSenamon()[opcionPelea].Nombre}**");
                        }

                        for (int i = 0; i < 1; i++)
                        {

                            Console.Write($"\n>>Entrenador senamon {listaEntrenadores[1].getNombre().ToUpper()}\n");
                            Console.Write($"\n-Senamones disponibles:\n");
                            for (int k = 0; k < 5; k++)
                            {
                                Console.WriteLine($"   Senamon {k}: {listaEntrenadores[1].getVectorSenamon()[k].Nombre}");
                            }

                            do
                            {
                                Console.Write("\nDigite el numero del senamon a pelear: ");
                                _ = int.TryParse(Console.ReadLine(), out opcionPeleaSenamon);
                            } while (opcionPeleaSenamon < 0 || opcionPeleaSenamon > 4);

                            while (listaEntrenadores[1].getVectorSenamon()[opcionPeleaSenamon].Salud <= 0)
                            {
                                Console.WriteLine($"**El senamon {listaEntrenadores[1].getVectorSenamon()[opcionPeleaSenamon].Nombre}, no tiene salud**");
                                do
                                {
                                    Console.Write("\nDigite el numero de otro senamon a pelear: ");
                                    _ = int.TryParse(Console.ReadLine(), out opcionPeleaSenamon);
                                } while (opcionPeleaSenamon < 0 || opcionPeleaSenamon > 4);
                            }

                            Console.WriteLine($"**peleador 2: { listaEntrenadores[1].getVectorSenamon()[opcionPeleaSenamon].Nombre}**");
                        }
                        Console.WriteLine("\n-----------------------------------------------------------------------------");

                        //sorteo
                        turno = numero;
                        if (turno == 1)
                        {
                            Console.WriteLine($"Se sorteo con una moneda, empezara el/la entrenador/a {listaEntrenadores[1].getNombre().ToUpper()}");
                        }
                        else
                        {
                            Console.WriteLine($"Se sorteo con una moneda, empezara el/la entrenador/a {listaEntrenadores[0].getNombre().ToUpper()}");
                        }
                        Console.WriteLine("\n-----------------------------------------------------------------------------\n");

                        //ataques
                        turno = numero;
                        while (listaEntrenadores[0].getVectorSenamon()[opcionPelea].Salud > 0 && listaEntrenadores[1].getVectorSenamon()[opcionPeleaSenamon].Salud > 0)
                        {
                            if (turno == 1)
                            {
                                Console.WriteLine($"    >>>Ataca {listaEntrenadores[1].getVectorSenamon()[opcionPeleaSenamon].Nombre}");
                                listaEntrenadores[0].getVectorSenamon()[opcionPelea].Salud -= listaEntrenadores[1].getVectorSenamon()[opcionPeleaSenamon].Ataque;
                                turno = 2;
                                Console.WriteLine($"Salud {listaEntrenadores[0].getVectorSenamon()[opcionPelea].Nombre} de {listaEntrenadores[0].getNombre().ToUpper()}: {listaEntrenadores[0].getVectorSenamon()[opcionPelea].Salud}");
                            }
                            else
                            {
                                Console.WriteLine($"    >>>Ataca {listaEntrenadores[0].getVectorSenamon()[opcionPelea].Nombre}");
                                listaEntrenadores[1].getVectorSenamon()[opcionPeleaSenamon].Salud -= listaEntrenadores[0].getVectorSenamon()[opcionPelea].Ataque;
                                turno = 1;
                                Console.WriteLine($"Salud {listaEntrenadores[1].getVectorSenamon()[opcionPeleaSenamon].Nombre} de {listaEntrenadores[1].getNombre().ToUpper()}: {listaEntrenadores[1].getVectorSenamon()[opcionPeleaSenamon].Salud}");
                            }
                        }
                        Console.WriteLine("\n---------------------------------------------------------------");

                        //contador batallas perdidas
                        if (listaEntrenadores[1].getVectorSenamon()[opcionPeleaSenamon].Salud <= 0)
                        {
                            Console.WriteLine($"\n*** El senamon { listaEntrenadores[0].getVectorSenamon()[opcionPelea].Nombre} de {listaEntrenadores[0].getNombre().ToUpper()}, ha ganado esta batalla. ***");
                            contDos -= 1;
                            Console.WriteLine($"\nPokemones restantes {listaEntrenadores[1].getNombre()}: {contDos}");
                            Console.WriteLine($"Pokemones restantes {listaEntrenadores[0].getNombre()}: {contUno}");
                        }
                        else
                        {
                            Console.WriteLine($"*** El senamon {listaEntrenadores[1].getVectorSenamon()[opcionPeleaSenamon].Nombre} de {listaEntrenadores[1].getNombre().ToUpper()}, ha ganado esta batalla. ***");
                            contUno -= 1;
                            Console.WriteLine($"\nPokemones restantes {listaEntrenadores[1].getNombre()}: {contDos}");
                            Console.WriteLine($"Pokemones restantes {listaEntrenadores[0].getNombre()}: {contUno}");
                        }

                        //Ganador
                        if (contDos == 2 || contUno == 2)
                        {
                            if (contDos == 2)
                            {
                                Console.WriteLine($"\n***** El ganador es {listaEntrenadores[0].getNombre().ToUpper()} *****");
                                listaEntrenadores[0].aumentarVictoria();
                                continuar = false;
                            }
                            else
                            {
                                Console.WriteLine($"\n***** El ganador es {listaEntrenadores[1].getNombre().ToUpper()} *****");
                                listaEntrenadores[1].aumentarVictoria();
                                continuar = false;
                            }
                        }
                        
                        break;

                    case 4:
                        continuar = false;
                        break;
                }
            }

            Console.WriteLine("\n------------------------------------------------------------------------");
            //Mostrar Entrenadores
            for (int i = 0; i < listaEntrenadores.Count; i++)
            {
                Console.WriteLine($"\n\n>>>Entrenador: {listaEntrenadores[i].getNombre()} \n- Email: " +
                    $"{listaEntrenadores[i].Email} \n- Fecha Nacimiento: {listaEntrenadores[i].FechaNacimiento.ToShortDateString()}" +
                    $" \n- Nivel Experiencia: {listaEntrenadores[i].NivelExperiencia} \n- Numero Victorias: {listaEntrenadores[i].NumVictorias}");
                Console.WriteLine("\n Sus Senamones son:");
                for (int k = 0; k < 5; k++)
                {
                    Console.WriteLine($"Nombre: {listaEntrenadores[i].getVectorSenamon()[k].Nombre}");
                }
            }


        }

    }
}