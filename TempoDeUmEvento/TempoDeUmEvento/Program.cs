using System;

namespace TempoDeUmEvento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double segundoDia = 86400.00;
            const double segundoHora = 3600.00;
            const double segundoMinuto = 60.00;


            Console.Write("Dia ");
            double diaInicio = int.Parse(Console.ReadLine());
            string[] horarioInicio = Console.ReadLine().Split(':');
            double horaInicio = int.Parse(horarioInicio[0]);
            double minutoInicio = int.Parse(horarioInicio[1]);
            double segundoInicio = int.Parse(horarioInicio[2]);

            Console.Write("Dia ");
            double diaFinal = int.Parse(Console.ReadLine());
            string[] horarioFinal = Console.ReadLine().Split(':');
            double horaFinal = int.Parse(horarioFinal[0]);
            double minutoFinal = int.Parse(horarioFinal[1]);
            double segundoFinal = int.Parse(horarioFinal[2]);

            double tempoDecorridoInico = (diaInicio * segundoDia) + (horaInicio * segundoHora) + (minutoInicio * segundoMinuto) + segundoInicio;
            double tempoDecorridoFinal = (diaFinal * segundoDia) + (horaFinal * segundoHora) + (minutoFinal * segundoMinuto) + segundoFinal;

            double duracaoEvento = tempoDecorridoFinal - tempoDecorridoInico;
            double duracaoDia, duracaoHora, duracaoMinuto, duracaoSegundo;

            if (duracaoEvento >= segundoDia)
            {
                duracaoDia = Math.Floor(duracaoEvento / segundoDia);
                duracaoEvento = duracaoEvento - duracaoDia * segundoDia;
                if (duracaoEvento >= segundoHora)
                {
                    duracaoHora = Math.Floor(duracaoEvento / segundoHora);
                    duracaoEvento = duracaoEvento - duracaoHora * segundoHora;
                    if (duracaoEvento >= segundoMinuto)
                    {
                        duracaoMinuto = Math.Floor(duracaoEvento / segundoMinuto);
                        duracaoEvento = duracaoEvento - duracaoMinuto * segundoMinuto;
                        duracaoSegundo = duracaoEvento;
                    }
                    else
                    {
                        duracaoMinuto = 0;
                        duracaoSegundo = duracaoEvento;
                    }
                }
                else
                {
                    duracaoHora = 0;
                    if (duracaoEvento >= segundoMinuto)
                    {
                        duracaoMinuto = Math.Floor(duracaoEvento / segundoMinuto);
                        duracaoEvento = duracaoEvento - duracaoMinuto * segundoMinuto;
                        duracaoSegundo = duracaoEvento;
                    }
                    else
                    {
                        duracaoMinuto = 0;
                        duracaoSegundo = duracaoEvento;
                    }
                }
            }
            else
            {
                duracaoDia = 0;
                if (duracaoEvento >= segundoHora)
                {
                    duracaoHora = Math.Floor(duracaoEvento / segundoHora);
                    duracaoEvento = duracaoEvento - duracaoHora * segundoHora;
                    if (duracaoEvento >= 60)
                    {
                        duracaoMinuto = Math.Floor(duracaoEvento / segundoMinuto);
                        duracaoEvento = duracaoEvento - duracaoMinuto * segundoMinuto;
                        duracaoSegundo = duracaoEvento;
                    }
                    else
                    {
                        duracaoMinuto = 0;
                        duracaoSegundo = duracaoEvento;
                    }
                }
                else
                {
                    duracaoHora = 0;
                    if (duracaoEvento >= segundoMinuto)
                    {
                        duracaoMinuto = Math.Floor(duracaoEvento / segundoMinuto);
                        duracaoEvento = duracaoEvento - duracaoMinuto * segundoMinuto;
                        duracaoSegundo = duracaoEvento;
                    }
                    else
                    {
                        duracaoMinuto = 0;
                        duracaoSegundo = duracaoEvento;
                    }
                }

            }
            Console.WriteLine(duracaoDia + " dia(s)");
            Console.WriteLine(duracaoHora + " hora(s)");
            Console.WriteLine(duracaoMinuto + " minuto(s)");
            Console.WriteLine(duracaoSegundo +" segundo(s)");

            Console.ReadKey();
        }
    }
}
