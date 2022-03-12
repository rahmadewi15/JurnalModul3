using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3_1302201132
{
    internal class PosisiKarakterGame
    {
        enum State { TombolIS, TombolIW, Exit};

        public static void Mulai()
        {
            Console.WriteLine("Masukan State");
            State state = State.TombolIS;
            while (state != State.Exit)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "TombolIS":
                        Console.WriteLine("tombol arah bawah ditekan");
                        Console.WriteLine();
                        break;
                    case "TombolIW":
                        Console.WriteLine("tombol arah atas ditekan");
                        Console.WriteLine();
                        break;
                    case "Exit":
                        state = State.Exit;
                        break;
                    default:
                        Console.WriteLine("Masukan Ulang State");
                        break;

                }
            }
        }
    }
}
