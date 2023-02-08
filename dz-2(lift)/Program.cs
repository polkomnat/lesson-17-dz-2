using System;


namespace dz_2_lift_
{
    internal class Program
    {
        static void Main(string[] args)
        {

                bool exit = false;
                Elevator elevatoR = new Elevator(18);
                Console.WriteLine("Этаж 1");


            do
            {
                int capacity = elevatoR.IsAllowablewWeight(0);
                int maxFloor = elevatoR.IsAllowableFloor(0);
                int currentFloor = elevatoR.MoveToFloor(maxFloor);
                Console.WriteLine(" E - Exit \n Enter - для продолжения");
                string key = Console.ReadLine();
                    switch (key)
                    {
                        case "e":
                            exit = true;
                            break;

                    }
                    if (exit == true) break;

                    

                
            }
            while(true);




        }
        public class Elevator
        {
            public int currentFloor { get; set; }
            public int capacity { get; set; }
            public int maxFloor { get; set; }
            Elevator[] elevator;


            public Elevator()
            {
                elevator = new Elevator[18];
            }
            public Elevator(int floor)
            {
                currentFloor = floor;
            }
            public Elevator(int floor, int count)
            {
                currentFloor = floor;
                maxFloor = count;
            }

            public int MoveToFloor(int floor)
            {
                int[] elevator = new int[floor];
                Array.Sort(elevator);
                foreach (int x in elevator) Console.WriteLine();
                Console.WriteLine("лифт прибыл на этаж " + floor);
                return floor;
            }
            public int IsAllowablewWeight(int capacity)
            {
                Console.WriteLine("Введите перевозимый вес");
                capacity = Convert.ToInt32(Console.ReadLine());
                if (capacity > 200)
                {
                    Console.WriteLine("Вес больше 200");
                    return IsAllowablewWeight(capacity);

                }
                else
                {
                    Console.WriteLine("Вес допустимый");
                }
                return capacity;
            }
            public int IsAllowableFloor(int maxFloor)
            {
                Console.WriteLine("Введите желаемый этаж");
                maxFloor = Convert.ToInt32(Console.ReadLine());
                if (maxFloor > 18 && maxFloor > -1)
                {
                    Console.WriteLine("Такого этажа не существует");
                    return IsAllowableFloor(maxFloor);
                }
                
                else
                {
                    return maxFloor;
                }

                

             
            }
            public int this[int index]
            {
                get
                {
                    Elevator floor = null;
                    for(int i = 0; i < elevator.Length; i++)
                    {
                        if(i == index)
                        {
                            floor = elevator[index];
                            break;
                        }
                    }
                    return floor.currentFloor;
                }
                set
                {
                    for(int i = 0; i < elevator.Length; i++)
                    {
                        if (i == index)
                        {
                            elevator[index].currentFloor = value;
                            break;
                        }
                    }
                }
            }
        }
    }
}


