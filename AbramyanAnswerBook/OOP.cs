// namespace AbramyanAnswerBook;
//
// public class OOP
// {
//     static Random rnd = new Random();
//     public static void Main()
//     {
//         Car car = new Car { Color = "Red", Model = "Toyota", Year = 2022 };
//         Car c = new Car();
//         c.Color = "Blue";
//         c.Model = "Honda";
//         c.Year = 2020;
//         car.SetSpeed(300);
//         Console.WriteLine($"Car 1: {car.Color}, {car.Model}, {car.Year}, Max speed: {car.GetSpeed()} km/h");
//         
//         Car c2 = new Car("Black", "Ford", 2021);
//
//         int[] array = new int[10];
//         for (int i = 0; i < array.Length; i++)
//         {
//             array[i] = rnd.Next(0, 11);
//             Console.WriteLine($"[{i}] = {array[i]}");
//         }
//
//         List<int> list = new List<int>(10);
//
//     }
// }
//
// public interface ICar
// {
//     public void StartEngine();
//     
//     public void StopEngine();
//
//     public int GetSpeed();
//
//     public void Drive();
// }
//
// class Car : ICar
// {
//     public Car()
//     {
//         
//     }
//     public Car(string color, string model, int year)
//     {
//         Color = color;
//         Model = model;
//         Year = year;
//     }
//
//     private int maxSpeed;
//
//     public void SetSpeed(int speed)
//     {
//         if (speed >= 0)
//             maxSpeed = speed;
//     }
//     
//    
//     public string Color { get; set; }
//     public string Model { get; set; }
//     public int Year { get; set; }
//
//
//     public void StartEngine()
//     {
//         Console.WriteLine("Engine started");
//     }
//
//     public void StopEngine()
//     {
//         Console.WriteLine("Engine stopped");
//     }
//
//     public int GetSpeed()
//     {
//         return maxSpeed;
//     }
//
//     public void Drive()
//     {
//         StartEngine();
//         Console.WriteLine($"Driving at {maxSpeed} km/h");
//     }
// }