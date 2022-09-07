// Create Mall Using Console Application using these details .. 

// Print an info for user to read about the mall  (Include the date and time for mall founded at ) using new DateTime(1942,5,3)

// Ask For Client Name and Phone Number . 

// Create Array Of Products And Another Array Of Prices .. 

// Using For Loop Print For User List Of Products and pices using indexing ,, 

// Ask Client To Choose The Product From List You print before . 

// from the number client choosed you should print product name and prices 

// ask client to pay the ammount [] and write the amount for user.

// Check if have later and return money to client if needed .. 

// Print Full Bill For client .. Bill should contain ..
// [Client name , Phone Number , Product namne , Product Price , Client Paid , Late , Date time For Bill ]


DateTime n = new DateTime(1900, 10, 5);
pt($"welcome to elanabymall {n} ");
pt("what is your name?");
Console.Beep();
string name = Console.ReadLine();

pt("What is your phone number?");
Console.Beep();
string phonenumber = Console.ReadLine();



string[] products = { "molto", "cheese", "fish", "pepsi" };
int[] prices = { 10, 20, 30, 31 };
string[] size = { "XL", "M", "XL", "M" };




for (int i = 0; i < products.Length; i++)
{
    //pt(products[i]);
    //(prices[i].ToString());
    // pt($"{i}- The prices is {prices[i]} and The products is {products[i]} ");
    pt($"{i}- Name : {products[i]} > Price : {prices[i]} > Size : {size[i]} ");
}
Console.Beep();
string choisenumber = Console.ReadLine();
pt($"your choise is {products[int.Parse(choisenumber)]} and the prices is {prices[int.Parse(choisenumber)]}");
pt($"please pay the amount {prices[int.Parse(choisenumber)]}");
Console.Beep();
string prices1 = Console.ReadLine();
int clintpaid = Convert.ToInt16(prices1);
int productprices = prices[int.Parse(choisenumber)];
string productname = products[int.Parse(choisenumber)];


if (clintpaid == productprices)
{
    pt("Thanks");
}
if (clintpaid > productprices)
{
    int later = clintpaid - productprices;
    pt($"Your later is {later}");
}
if (clintpaid < productprices)
{
    pt("Sorry");
}
// Print Full Bill For client .. Bill should contain ..
// [Client name , Phone Number , Product namne , Product Price , Client Paid , Later , Date time For Bill ]..

string[] Bill = new string[7];


Bill[0] = $" Clint Name is :  {name}";
Bill[1] = $" Phone Number is :  {phonenumber}";
Bill[2] = $" Product name is :  {productname}";
Bill[3] = $" Product prices is :  {productprices}";
Bill[4] = $" Clint Paid is :  {clintpaid}";
Bill[5] = $" Clint Later is :  {clintpaid - productprices}";
Bill[6] = $" Bill Date is :  {DateTime.Now}";
pt("");
pt("");
pt("************* Bill information ************* ");

for (int i = 0; i < Bill.Length; i++)
{
    pt(Bill[i]);
}
pt("************* ************** ************* ");



void pt(string l)
{
    Console.WriteLine(l);
}