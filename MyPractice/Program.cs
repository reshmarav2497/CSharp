using MyPractice;
using MyPractice.Methods;

var customer = new Customer(1, "Max");

//customer.Name = "customer1";
//customer.Id = 1;


customer.Orders.Add(new Order());
customer.Orders.Add(new Order());

Console.WriteLine($"Customer 1 details {customer.Name} {customer.Id}");
Console.WriteLine($"Orders Count {customer.Orders.Count}");

Console.WriteLine("--------Methods-----------");

UsePoints();

Console.WriteLine("--------params-----------");

UseParams();
return;

static void UsePoints()
{
    try
    {
        var point = new Point(10, 20);
        //point.Move(null);
        point.Move(new Point(40, 60));
        Console.WriteLine($"Pont is at {point.X} {point.Y}");
    }
    catch (Exception e)
    {
        Console.WriteLine("An Error Occured" + e);
    }
}

static void UseParams()
{
    Calculator cal = new Calculator();
    Console.WriteLine(cal.Add(1, 2));
    Console.WriteLine(cal.Add(1, 2, 3));
    Console.WriteLine(cal.Add(1, 2, 4, 5));
    Console.WriteLine(cal.Add(new int[] { 1, 2, 3 }));
}

static void UseOutMod()
{
    int num;
    bool isParsed = int.TryParse("abc", out num);
    if (isParsed)
    {
        Console.WriteLine(num);
    }
    else
    {
        Console.WriteLine("Conversion failed");
    }
}