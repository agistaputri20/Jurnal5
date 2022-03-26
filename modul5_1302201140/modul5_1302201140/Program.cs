using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302201140
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo film1 = new SayaTubeVideo("Review Film 1 oleh Agista Hidayatillah Suparno Putri");
            SayaTubeVideo film2 = new SayaTubeVideo("Review Film 2 oleh Agista Hidayatillah Suparno Putri");
            SayaTubeVideo film3 = new SayaTubeVideo("Review Film 3 oleh Agista Hidayatillah Suparno Putri");
            SayaTubeVideo film4 = new SayaTubeVideo("Review Film 4 oleh Agista Hidayatillah Suparno Putri");
            SayaTubeVideo film5 = new SayaTubeVideo("Review Film 5 oleh Agista Hidayatillah Suparno Putri");
            SayaTubeVideo film6 = new SayaTubeVideo("Review Film 6 oleh Agista Hidayatillah Suparno Putri");
            SayaTubeVideo film7 = new SayaTubeVideo("Review Film 7 oleh Agista Hidayatillah Suparno Putri");
            SayaTubeVideo film8 = new SayaTubeVideo("Review Film 8 oleh Agista Hidayatillah Suparno Putri");
            SayaTubeVideo film9 = new SayaTubeVideo("Review Film 9 oleh Agista Hidayatillah Suparno Putri");
            SayaTubeVideo film10 = new SayaTubeVideo("Review Film 10 oleh Agista Hidayatillah Suparno Putri");
            film1.PrintVideoDetails();
            film2.PrintVideoDetails();
            film3.PrintVideoDetails();
            film4.PrintVideoDetails();
            film5.PrintVideoDetails();
            film6.PrintVideoDetails();
            film7.PrintVideoDetails();
            film8.PrintVideoDetails();
            film9.PrintVideoDetails();
            film10.PrintVideoDetails();
        }
    }
}
