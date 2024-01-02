// See https://aka.ms/new-console-template for more information
using Fun_With_Delegates;

Console.WriteLine("Hello, World!");

IList<Apple> totalApples = new List<Apple>() {
	new Apple() {Name = "Granny Smith", Price = 1.00M },
	new Apple() {Name = "Fuji", Price = 1.5M },
	new Apple() {Name = "Granny Smith", Price = 1.00M },
	new Apple() {Name = "Honeycrisp", Price = 1.350M },
	new Apple() {Name = "Honeycrisp", Price = 1.350M },
	new Apple() {Name = "McIntosh", Price = 1.25M }
};

Action<string> printTotalAppleOfType = PrintTotalApplesByCategory;
printTotalAppleOfType("Honeycrisp");

Func<string, int> numberOfApplesToOrder = NumberOfApplesToOrder;
Console.WriteLine($"you need to order {numberOfApplesToOrder("Honeycrisp")} of these apples");
void CountApplesByType(string name)
{

}

void PrintTotalApplesByCategory(string appleName)
{
	decimal sum = totalApples.Where(a => a.Name == appleName)
		.Sum(p => p.Price);

	Console.WriteLine($"Total price of all {appleName} apples is " + sum.ToString());
}

int NumberOfApplesToOrder(string appleName)
{
	int count = totalApples.Where(a => a.Name == appleName).Count();
	return 3 - count;
}


