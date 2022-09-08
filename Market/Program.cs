pt("Welcome to Hyper Eltanen");
pt("What is your name ?");
Console.Beep();
string name = Console.ReadLine();
pt("What is your phone number");
Console.Beep();
string phonenumber = Console.ReadLine();
pt($"Hello {name} What do u need?");
Console.Beep();
string[] products = { "pepsi", "molto", "cheese", "tomato", "banana " };
int[] prices = { 15, 56, 56, 4, 9 };

for (int i = 0; i < products.Length; i++)
{
    pt($"{i} - Name : {products[i]} *** Price : {prices[i]}");

}
Console.Beep();
string choise = Console.ReadLine();
pt($"Your choise is {products[int.Parse(choise)]} and The price is {prices[int.Parse(choise)]} ");
pt($"Please pay the amount {prices[int.Parse(choise)]}");
Console.Beep();
string pay = Console.ReadLine();
int pay2 = Convert.ToInt32(pay);
int productprices = prices[int.Parse(choise)];
if (pay2 == productprices)
{
    pt("Thanks");
}
if (pay2 > productprices)
{
    int residual = pay2 - productprices;
    pt($"You are paid {pay} and this is your residual {residual}");
}
if (pay2 < productprices)
{
    pt($"Sorry");
}

pt("************ ********* **************");
Console.Beep();
string[] Bill = new string[5];

Bill[0] = ($"clint name is {name}");
Bill[1] = ($"phonenumber is {phonenumber}");
Bill[2] = ($"The products is {products[int.Parse(choise)]}");
Bill[3] = ($"price is {prices[int.Parse(choise)]}");
Bill[4] = ($"Date time is {DateTime.Now}");

for (int i = 0; i < 5; i++)
{
    pt(Bill[i]);
}
pt($"We wish for u Have a nice day");
pt($"For complaints and suggestions call on This number 01002256653");

void pt(string l)
{
    Console.WriteLine(l);
}

Console.ReadKey();
