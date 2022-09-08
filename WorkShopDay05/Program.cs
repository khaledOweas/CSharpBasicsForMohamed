// Write a Programe to Solve Engineering Consultant Office Issue 
// First You need To Define Some Engineers { Name , phone , salary }  [In App RunTime Not In Code .. ] 
// Second You  Ask The Client About { Building Type , Floors Number , Area }  
// And Suggest On Client All [ Engineers and there Salaries ] you Defined before 
// Client Should Choose the Engineer and Salary ............
// you provide Engineer Name and Phone to client to contact ---
// ask client to pay a consumtion for Consultant Office ====
// Give Client Business Card Include Name , Email , Phone Number ---
// Print a BILL For Client Include [Engineer Name ,  Phone , Salary  ]----

// All Collections Should Be By List<DataType> [] 
// All Conditions Should Be By Swich Case  not if 
// We Should Handle All Erros using Try Catch Statment 
// Color The Printed Lines 
// Do NOT Foget BEEEB() 

void pt(string text, ConsoleColor color = ConsoleColor.White)
{
    Console.ForegroundColor = color;
    Console.WriteLine(text);
    Console.ForegroundColor = ConsoleColor.White;
}
List<string> listname = new List<string>();
List<string> listphone = new List<string>();
List<int> listsalary = new List<int>();
pt("Welcome to the Elhiah...");
askinformation:
Console.Beep();
pt("Enter Engineername ");
string name = Console.ReadLine();
pt($"Your name is {name}...");
Console.Beep();
pt("Enter Phone ");
string phone = Console.ReadLine();
pt($"Your phone is {phone}...");
Console.Beep();
pt("Enter Salary ");
string salary = Console.ReadLine();
pt($"your salary is {salary}...");
int salaryint = int.Parse(salary);
listname.Add(name);
listphone.Add(phone);
listsalary.Add(salaryint);
pt("Do you need to add more? [y/n]");
string bo = Console.ReadLine();
switch (bo)
{
    case "y":
        goto askinformation;
        break;
    case "n":
        pt("Okay");
        break;
}
pt("Information the clint");
pt("What is your name?");
string name2 = Console.ReadLine();
pt("What is your Building Type");
string build = Console.ReadLine();
pt("How many floors number ?");
string foorsnumber = Console.ReadLine();
pt("Where is the area");
string area = Console.ReadLine();

pt("Engineers");
for(int i = 0; i < listname.Count; i++)
    {
    pt($"{i}-Name engineer is{listname[i]}---- Phone{listphone[i]}---- Salary{listsalary[i]}" );
}
string choose = Console.ReadLine();
int choose2 = int.Parse(choose);
pt($"{listname[choose2]}");
pt("Please paid 400$");
string mk = Console.ReadLine();
switch (mk)
{
    case "400":
        pt("Thanks");
        break;
    default:
        pt("Sorry you shoul paid 400$");
        break;
}
pt("This is Book company");
pt("Email Address : book@gmail.com");
pt("Phone Number : 0100112222");


pt($"This is your name {name2} ");
pt($"This is your {build} ");
pt($"This is your {foorsnumber} ");
pt($"This is Engineer name {listname[choose2]} ");
pt($"This is Engineer salary {listsalary[choose2]} ");
pt($"This is Engineer phone {listname[choose2]}");
pt($"You paid {mk}");















