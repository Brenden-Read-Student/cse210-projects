using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order("Gary","Indiana", "USA", "6119 corgi drive");
        order1.SetCostumer("Mark");
        order1.ItemCost("musterd", 335467, 3.45, 2);
        order1.ItemCost("A10-Warthog", 883542, 500346.34, 16);
        order1.ItemCost("Trumpet", 233475, 3540, 4);


        Order order2 = new Order("Ford","Montana", "USA", "6119 freeman drive");
        order2.SetCostumer("Ben");
        order2.ItemCost("pool noodle", 225487, 5.25, 2);
        order2.ItemCost("Screw driver", 634542, 13.34, 16);
        order2.ItemCost("chip", 246535, 3540, 1);

        
        Order order3 = new Order("revrend","montial", "Jordan", "6119 penman road");
        order3.SetCostumer("Trevor");
        order3.ItemCost("nail clipers", 576937, 5.25, 5);
        order3.ItemCost("water bottel", 634342, 2.34, 2);
        order3.ItemCost("corn on cob", 326535, 7.32, 68);


        order1.Display();
        Console.WriteLine(" ");
        order2.Display();
        Console.WriteLine(" ");
        order3.Display();
    }
}