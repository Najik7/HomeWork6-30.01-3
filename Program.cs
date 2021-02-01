using System;

namespace Д.з_6_2__alif
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayable playable = new Player();
            IRecodable recodable = new Player();

            playable.Play();
            playable.Pause();
            playable.Stop();

            Console.WriteLine();
            recodable.Record();
            recodable.Pause();
            recodable.Stop();
        }
 
    }



    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();


    }

    public interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();

    }


    class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Play");
        }

        public void Pause()
        {
            Console.WriteLine("Pause");
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }



        public void Record()
        {
            Console.WriteLine("Record");
        }


    }

}
