Dictionary<string, string> sizeOptions = new Dictionary<string, string>() {
    { "1", "small" },
    { "2", "medium" },
    { "3", "large" }
};

Dictionary<string, string> baseOptions = new Dictionary<string, string>() {
    { "1", "thin" },
    { "2", "thick" }
};

Dictionary<string, string> toppingOptions = new Dictionary<string, string>() {
    { "1", "pepperoni" },
    { "2", "chicken" },
    { "3", "extra cheese" },
    { "4", "mushroom" },
    { "5", "spinach" },
    { "6", "olives" }
};

Dictionary<string, string> orderActions = new Dictionary<string, string>() {
    { "1", "confirm" },
    { "2", "alter" },
    { "3", "cancel" }
};

OrderPizzas();

void OrderPizzas()
{
    Console.Write("What size pizza do you want? (1) small, (2) medium, (3) large: ");
    string size = sizeOptions[Console.ReadLine()!];

    Console.Write("What base do you want? (1) thin, (2) thick: ");
    string baseType = baseOptions[Console.ReadLine()!];

    Console.Write("How many toppings do you want?: ");
    int toppingAmount = Convert.ToInt32(Console.ReadLine());

    List<string> toppings = new List<string>();

    for (int j = 0; j < toppingAmount; j++)
    {
        Console.Write("What topping do you want? (1) pepperoni, (2) chicken, (3) extra cheese, (4) mushroom, (5) spinach, (6) olives: ");
        toppings.Add(toppingOptions[Console.ReadLine()!]);
    }

    Pizza newPizza = new Pizza();
    newPizza.Size = size;
    newPizza.BaseType = baseType;
    newPizza.Toppings = toppings;

    Console.Write("How would you like to proceed? (1) confirm, (2) alter, (3) cancel: ");
    string orderAction = orderActions[Console.ReadLine()!];

    switch (orderAction)
    {
        case "confirm":
            Console.WriteLine($"Your order has been confirmed! Order number is {new Random().Next(101)}.");
            break;
        case "alter":
            Console.WriteLine("Restarting order...");
            OrderPizzas();
            break;
        case "cancel":
            Console.WriteLine("Your order has been cancelled!");
            break;
    }
}

struct Pizza
{
    public string Size;
    public string BaseType;
    public List<string> Toppings;
}