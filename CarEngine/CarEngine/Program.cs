using System;

namespace CarEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            CarEngine engine = CarEngine.Instance;
            Console.WriteLine(engine.model + "\n" + engine.maxSpeed + "\n" + engine.Year);
            engine.DoSomething();
        }
    }

    public class CarEngine
    {
        private static CarEngine instance = null;
        private CarEngine() { }

        public static CarEngine Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CarEngine();
                }
                return instance; 
            }
        }

        public int maxSpeed = 4600;
        public int Year = 2002;
        public string model = "Volvo D5 engine";

        public void DoSomething()
        {
            Console.WriteLine("Vroom Vroom");
        }
    }
}
