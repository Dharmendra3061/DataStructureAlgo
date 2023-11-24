namespace ArraysDemo {
    using System;

    internal class Arrays {
        private string[] _cities;
        public string[] Cities { get; }

        public Arrays(int size)
        {
            _cities = new string[size];
        }
        
        public void InsertAt (int index, string city) {
            _cities[index] = city;          
        }

        public void Delete (string cityToDelete) {
            int indexOfCityToDelete = IndexOf(cityToDelete);
            if(indexOfCityToDelete >= 0){
                for(int i=indexOfCityToDelete; i<_cities.Length-1; i++){
                    _cities[i] = _cities[i+1];
                }
            }
        }

        public void Traversing() {
            foreach(var city in _cities)
            {
                Console.WriteLine(city);
            }
        }

        public int IndexOf(string city){
            for(int i=0; i<_cities.Length; i++){
                if(_cities[i] == city)
                    return i;
            }
            return -1;
        }
    }

    public class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Arrays implementation");
            Console.WriteLine();
            Arrays array = new Arrays(5); 
            array.InsertAt(0,"Delhi");
            array.InsertAt(1,"Mumbai");
            array.InsertAt(2,"Kolkata");
            array.InsertAt(3,"Banglore");
            array.InsertAt(3,"Pune");

            array.Traversing();

            array.Delete("Kolkata");
            Console.WriteLine("After deleting Kolkata");
            array.Traversing();
            // Console.WriteLine(queue.Dequeue());
            // Console.WriteLine(queue.Dequeue());
            // Console.WriteLine(queue.Peek());
            // queue.Display();

            // queue.Enqueue("F");
            // Console.WriteLine(queue.Peek());
            // queue.Display();
        }
    }
}