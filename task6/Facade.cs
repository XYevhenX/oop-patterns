using System;

namespace Task6.Facade
{
    class TV
    {
        public void TurnOn() => Console.WriteLine("Телевізор увімкнено.");
        public void TurnOff() => Console.WriteLine("Телевізор вимкнено.");
    }

    class AudioSystem
    {
        public void PlayMusic() => Console.WriteLine("Музика грає.");
        public void StopMusic() => Console.WriteLine("Музика зупинена.");
    }

    class Lights
    {
        public void TurnOn() => Console.WriteLine("Світло увімкнено.");
        public void TurnOff() => Console.WriteLine("Світло вимкнено.");
    }

    class SmartHomeFacade
    {
        private TV tv = new TV();
        private AudioSystem audio = new AudioSystem();
        private Lights lights = new Lights();

        public void EveningRoutine()
        {
            Console.WriteLine("\nЗапуск вечірнього режиму...");
            lights.TurnOn();
            tv.TurnOn();
            audio.PlayMusic();
        }

        public void LeaveHome()
        {
            Console.WriteLine("\nРежим 'Вихід з дому'...");
            lights.TurnOff();
            tv.TurnOff();
            audio.StopMusic();
        }
    }

    class Program
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Facade ---");
            SmartHomeFacade smartHome = new SmartHomeFacade();
            smartHome.EveningRoutine();
            smartHome.LeaveHome();
        }
    }
}