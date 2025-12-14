using MyPractice;
using MyPractice.Coupling;
using MyPractice.Encapsulation;
using MyPractice.EventsAndDelegates;
using MyPractice.Methods;
using Order = MyPractice.Order;
using OrderService = MyPractice.Coupling.Order;

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

Console.WriteLine("--------out-modifier-----------");
UseOutMod();

Console.WriteLine("--------Encapsulation-----------");
var p1 = new Person();
p1.SetBirthDate(new DateTime(1999, 8, 15));

Console.WriteLine("Birthday -> " + p1.GetBirthDate());


Console.WriteLine("--------Events and Delegates -----------");

var video = new Video() { Title = "Video1" };

var videoEncoder = new VideoEncoder(); //Publisher

var mailService = new MailService(); //Subscriber

var messageService = new MessageService(); //new Subscriber

videoEncoder.VideoEncoded += mailService.OnVideoEncoded;

videoEncoder.VideoEncoded += messageService.OnVideoEncoded;


videoEncoder.Encode(video);


Console.WriteLine("Placing Order");

OrderService orderService = new OrderService(new SmsService());
orderService.PlaceOrder();

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
    bool isParsed = int.TryParse("abc", out int num);
    if (isParsed)
    {
        Console.WriteLine(num);
    }
    else
    {
        Console.WriteLine("Conversion failed");
    }
}