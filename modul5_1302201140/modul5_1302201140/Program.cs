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

            SayaTubeUser namaUser = new SayaTubeUser("Agista Hidayatillah Suparno Putri");

            film1.IncreasePlayCount(1);
            film2.IncreasePlayCount(3);
            film3.IncreasePlayCount(5);
            film4.IncreasePlayCount(3);
            film5.IncreasePlayCount(1);
            film6.IncreasePlayCount(2);
            film7.IncreasePlayCount(2);
            film8.IncreasePlayCount(3);
            film9.IncreasePlayCount(5);
            film10.IncreasePlayCount(2);

            namaUser.AddVideo(film1);
            namaUser.AddVideo(film2);
            namaUser.AddVideo(film3);
            namaUser.AddVideo(film4);
            namaUser.AddVideo(film5);
            namaUser.AddVideo(film6);
            namaUser.AddVideo(film7);
            namaUser.AddVideo(film8);
            namaUser.AddVideo(film9);
            namaUser.AddVideo(film10);

            film1.PrintVideoDetails();

            namaUser.PrintAllVideoPlaycount();
        }
    }
}
