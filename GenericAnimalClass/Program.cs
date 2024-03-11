using System;
namespace Generic
{
    public class Animal<T>
    {
        public T data;

        public Animal(T data)
        {
            this.data = data;
            Console.WriteLine("Data passed: " + this.data);
        }
        public T getAnimal()
        {
            return data;
        }
    }

    public class Program
    {
        static void Main()
        {
            Animal<string> animalName = new Animal<string>("Milo");

            Animal<string> animalHabitat = new Animal<string>("My Apartment");

            Animal<bool> endangered = new Animal<bool>(false);

            Animal<bool> extinct = new Animal<bool>(false);

            Animal<int> averageLifespan = new Animal<int>(15);
        }
    }
}