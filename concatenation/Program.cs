DateTime date1 = DateTime.Now;
Console.WriteLine(date1);
Console.WriteLine(date1.AddDays(5));



void PrintWord(string valueToPrint)
{
    Console.WriteLine(valueToPrint);
}

string PrintLine(string valueToPrint)
{
    Console.WriteLine(valueToPrint);
    return valueToPrint;
}


int CalculateSalary(int WorkingDays, int DaysOff)
{
    int sallry = 0;
    // calc 
    int allDaysMoney = WorkingDays * 10;
    int allDaysOffMoney = DaysOff * 5;
    sallry = allDaysMoney - allDaysOffMoney;
    return sallry;
}


//PrintWord("Hello Mohamed.. ");
//PrintWord("Hello Khaled.. ");
//Console.WriteLine(9 * 15 + 2 / 3);
//Console.WriteLine(213 * 1.2 + 9 / 13);
// Console.WriteLine((15 * 10) - (10 * 5 ) );



string GetFirstName(string n1, string c2, int g3, int i4)
{
    //  return  "Full Name is " + n1  + "  " + c2 +"  ";

    return $"Full Name is {n1} {c2} and my age is {g3}  and my Height is : {i4} ";
}
string x = GetFirstName("Ahmed", "Mohamed", 60, 901);

Console.Write(x);



//  Create Program To Define user details . 
//  1- Get >   Name , Phone  , Age  
//  2- Return  statment says ..
//  Hello [name] , your phone number is [phone] and you phone service provider is [service]
//  and your Qota will be ended at [ datetime ] and your age is [age]

//  etisalat qota ended afterr 3 days 
//  orange qota ended after 10 days 
//  we qota ended afer 5 days 
//  vodafone ended after 6 days 


// use . 
// console.wrtieline . 
// console.readline ..
// substring(0,3 )
// if condidtion 
// datetime.AddDays(00)
// datetime.tostring 

string name = "";
string phone = "";
string service = "";
DateTime datetime = DateTime.Now;
string age = "";

void askforname()
{
    Console.WriteLine("What's your name ? ");
    name = Console.ReadLine();
}
void askforphone()
{
    Console.WriteLine("What's your Phone Number ? ");
    phone = Console.ReadLine();

}
void CalculateTheServiceandQotaDate()
{

    string statrtphonenumber = phone.Substring(0, 3);

    if (statrtphonenumber == "010")
    {
        service = "vodafone";
        datetime = DateTime.Now.AddDays(3);
    }

    if (statrtphonenumber == "011")
    {
        service = "Etsalate";
        datetime = DateTime.Now.AddDays(7);
    }

    if (statrtphonenumber == "012")
    {
        service = "Orange";
        datetime = DateTime.Now.AddDays(9);
    }

    if (statrtphonenumber == "015")
    {
        service = "we";
        datetime = DateTime.Now.AddDays(4);
    }
}
void askForAge()
{

    Console.WriteLine("What is your age ?");
    age = Console.ReadLine();
}
void PrintTheMessage()
{
    string message = $"Hello {name} , your phone " +
        $"number is {phone} and you phone service provider is {service} " +
    $"and your Qota will be ended at {datetime} and your age is {age} ";
    Console.WriteLine(message);

    Console.WriteLine("Good Bye ..");
}




Console.WriteLine("Welcome To Central Elsa3ada ");
askForAge();
askforname();
askforphone();
CalculateTheServiceandQotaDate();
PrintTheMessage();
Console.ReadKey();
