using System;

namespace HomeSweetHome
{
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier amp = new Amplifier("Amplifier");
            Tuner tuner = new Tuner("Tuner", amp);
            DvdPlayer dvd = new DvdPlayer("Dvd Player", amp);
            CdPlayer cd = new CdPlayer("Cd Player", amp);
            Projector projector = new Projector("Projector", dvd);
            Screen screen = new Screen("Large Screen");
            TheaterLights lights = new TheaterLights("Lights");
            PopcornPopper popper = new PopcornPopper("Popcorn Popper");

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(amp, tuner, dvd, cd, projector, screen, lights, popper);

            homeTheater.WatchMovie("Tonari No Totoro");
            homeTheater.EndMovie();

            Console.ReadLine();
        }
    }
}
