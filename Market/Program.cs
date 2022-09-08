using System.Globalization;

void MohamedProject()
{
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

    int residual = 0; // initial Value .. 

    if (pay2 == productprices)
    {
        pt("Thanks");
    }
    if (pay2 > productprices)
    {
        residual = pay2 - productprices;

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
    Bill[5] = ($"price is residual is {residual}");

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

}
// MohamedProject();

// array  >> length 
// list  >> without length 


void KhaledProject()
{

    List<string> ClientProductsList = new List<string>();
    List<int> ClientsPiricesList = new List<int>();


    pt("Welcome to Hyper ElFa4eee5", ConsoleColor.Cyan);
    pt("What is your name ?");
    Console.Beep();
    string name = Console.ReadLine();
WriteNumber:
    pt("What is your phone number");
    Console.Beep();
    string phonenumber = Console.ReadLine();
    if (phonenumber.Length != 11)
    {
        pt("you sould write the corrent number ", ConsoleColor.Red);
        goto WriteNumber;
    }


WhatDoYouNeedSection:
    pt($"Hello {name} What do u need?", ConsoleColor.Yellow);
    Console.Beep();
    // string[] products = { "pepsi", "molto", "cheese", "tomato", "banana " };


    List<string> productsList = new List<string>() { "pepsi", "molto", "cheese", "tomato", "banana " };

    int[] prices = { 15, 40, 20, 10, 90 };

    for (int i = 0; i < productsList.Count; i++)
    {
        pt($"{i} - Name : {productsList[i]} *** Price : {prices[i]}", ConsoleColor.DarkGreen);
    }



    Console.Beep();
ReChoise:
    pt($"Enter Your Choise From 0 to {productsList.Count}", ConsoleColor.Blue);
    string choise = Console.ReadLine();
    int CI = int.Parse(choise);
    if (CI > productsList.Count)
    {
        pt($"you should Choose from 0 to {productsList.Count}", ConsoleColor.Red);
        goto ReChoise;
    }

    pt($"Your choise is {productsList[CI]} and The price is {prices[CI]} ");


    // Add To Cart 
    ClientProductsList.Add(productsList[CI]);
    ClientsPiricesList.Add(prices[CI]);

AskForAnyThingElse: // new  <<<< 
    pt("do you need anything else (y/n)?");
    string anythingReply = Console.ReadLine();

    // validation  
    if (anythingReply == "y" || anythingReply == "n")
    {
        // New
        switch (anythingReply)
        {
            case "y":
                goto WhatDoYouNeedSection;
            case "n":
                pt("you are welcome ..", ConsoleColor.Blue);
                break;
        }
    }
    else
    {
        pt("Please wite correct answer [y or n]");
        goto AskForAnyThingElse; // New  <<<< 
    }



    // New 
    int total = 0;

    for (int i = 0; i < ClientsPiricesList.Count; i++)
        total = total + ClientsPiricesList[i];



    pt($"Please pay the amount {total}");
    Console.Beep();
RePay:
    string pay = Console.ReadLine(); // "iuiouh"
    int pay2 = 0;

    try // new 
    {
        pay2 = Convert.ToInt32(pay);
    }
    catch (Exception)
    {
        pt("Your Payment Sould be in numbers ", ConsoleColor.Red);
        pt("Write Your Correct Payment .. ", ConsoleColor.Green);
        goto RePay;
    }




    int residual = 0; // initial Value .. 

    if (pay2 == total)
        pt("Thanks");

    if (pay2 > total)
    {
        residual = pay2 - total;
        pt($"You are paid {pay} and this is your residual {residual}");
    }


    if (pay2 < total)
    {
        pt($"Sorry");
        goto RePay;
    }

    pt("************ ********* **************");
    Console.Beep();
    //string[] Bill = new string[6];
    List<string> Bill = new List<string>(); // New 

    Bill.Add($"clint name is {name}");
    Bill.Add($"phonenumber is {phonenumber}");

    for (int i = 0; i < ClientProductsList.Count; i++)
    {
        Bill.Add($"The products is {ClientProductsList[i]}");
    }
    Bill.Add($"Total is {total}");
    Bill.Add($"Date time is {DateTime.Now}");
    Bill.Add($"price is residual is {residual}");

    for (int i = 0; i < Bill.Count; i++)
    {
        pt(Bill[i], ConsoleColor.Magenta);
    }
    pt($"We wish for u Have a nice day");
    pt($"For complaints and suggestions call on This number 01002256653");



    void pt(string l, ConsoleColor color = ConsoleColor.White)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(l);
    }

    Console.ReadKey();
}

KhaledProject();