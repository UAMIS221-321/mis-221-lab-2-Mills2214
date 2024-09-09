// See https://aka.ms/new-console-template for more information
const double SANDWICH_COST = 4.75;
const double TOPPING_COST = 0.55;
const double DISCOUNT = 0.1;

int numOfSandwiches = 0;
int numOfToppings = 0;    //com
double tipAmmount = 0;

Console.WriteLine("How many sandwhiches would you like to purchase: ");
numOfSandwiches = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter number of toppings: ");
numOfToppings = int.Parse(Console.ReadLine());

Console.WriteLine("Enter tip ammount: ");
tipAmmount = double.Parse(Console.ReadLine());


double sandwhichCost = 0;
sandwhichCost = SANDWICH_COST * numOfSandwiches;

double toppingCost = 0;
toppingCost = TOPPING_COST * numOfToppings;

double cost = 0;
cost = sandwhichCost + toppingCost;

double orderCost = 0;
orderCost = Math.Round(cost * (1 - DISCOUNT) + tipAmmount, 2);

Console.WriteLine("orderCost Total is:" + orderCost);
