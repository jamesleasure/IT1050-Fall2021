using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit1 = new Fruit();
            fruit1.type = "Blueberry";

            Fruit fruit2 = new Fruit();
            fruit2.type = "Stawberry";

            Car car1 = new Car();
            car1.make = "Chevrolet";
            car1.model = "Cruze";
            Console.WriteLine("Car1 is a " + car1.make + " " + car1.model);

            Car car2 = new Car();
            car2.make = "Hyundai";
            car2.model = "Elantra";
            Console.WriteLine("Car2 is a " + car2.make + " " + car2.model);
            car2.setTopSpeed(70);
            int currentSpeed = 0;
            for (int i = 0; i < 16; i++)
            {
                currentSpeed = car2.accelerate();
            }
            Console.WriteLine(currentSpeed);
            car2.accelerate();
            car2.accelerate(100);
        }
    }
    class Car
    {
        public string make;
        public string model;
        private int speed = 0;
        private int topSpeed;

        public void setTopSpeed(int topSpeed)
        {
            this.topSpeed = topSpeed;
        }
        public int accelerate()
        {
            if (speed < topSpeed)
            {
                this.speed++;
            }
            return this.speed;
        }
        public int accelerate(int speed)
        {
            //this.speed = this.speed + speed;
            for (int i = 0; i < speed; i++)
            {
                this.accelerate();
            }
            return this.speed;
        }
        public void Display()
        {
            Console.WriteLine($"{make} {model} speed={speed} topSpeed={topSpeed}");
        }
    }

    class Fruit
    {
        public string type;
    }
}
