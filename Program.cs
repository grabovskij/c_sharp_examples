using System;

namespace Example_1_classes
{
    public class Car
    {
        public static int count = 0;

        public String color;
        public int weels;

        public Car(String color, int weels)
        {
            count++;
            this.color = color;
            this.weels = weels;
        }

        public String toString()
        {
            return $"Автомоюиль цвета: {color}, число колес:  {weels}";
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            dynamic car1 = new Car("red",2);
            var car2 = new Car("blue",4);

            car1 = new Car("yellow", 3);
            car1 = "";


            

            if (car1 is Car) {
                Console.WriteLine((car1 as Car).toString());
            }


            Console.WriteLine(car2.toString());
            Console.WriteLine($"Спущено машин с конвеера:{Car.count}");

            Console.ReadLine();
        }
    }

}




