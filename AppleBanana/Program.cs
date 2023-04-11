// See https://aka.ms/new-console-template for more information
using AppleBanana;


Apple a1 = new Apple { Name = "Apple 1", Price = 2.5F };
Apple a2 = new Apple { Name = "Apple 2", Price = 2.5F };
Apple a3 = new Apple { Name = "Apple 3", Price = 2.5F };

Banana b1 = new Banana { Name = "Banana 1", Price = 2.5F };
Banana b2 = new Banana { Name = "Banana 2", Price = 2.5F };
Banana b3 = new Banana { Name = "Banana 3", Price = 2.5F };

Pineapple p1 = new Pineapple { Name = "Pineapple 1", Price = 2.5F };
Pineapple p2 = new Pineapple { Name = "Pineapple 2", Price = 2.5F };
Pineapple p3 = new Pineapple { Name = "Pineapple 3", Price = 2.5F };

Console.WriteLine(a1.SayName());
Fruit[] fruits = new Fruit[] { a1, a2, a3, b1, b2, b3, p1, p2, p3 };

float totalPrice = 0;
// TODO: make a loop that adds the price of each fruit to the total price
foreach (var fruit in fruits)
{
    totalPrice += fruit.Price;
}


Console.WriteLine(totalPrice);