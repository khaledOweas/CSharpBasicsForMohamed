
/* Market Poject  */
PT("Welcome To Market M-E");
PT("M-E Market Has These Products .. Please Enter Your Choise ..");

string[] MEProducts = { "Molto", "Tea", "Cheese", "Fish", "Milk", "Tmr" };
int[] MEProductsPrices = { 5, 7, 13, 40, 15, 20 };


for (int i = 0; i < MEProducts.Length; i++)
{
    PT($"{i}- Product : {MEProducts[i]} , Price : {MEProductsPrices[i]}");
}


// Ask User For New Index [ii]
string iiSting = AC(); // "4"  >> Fish  
int ii = int.Parse(iiSting); // 4

PT($" Your Choise is :  {ii}- Product : {MEProducts[ii]} , Price : {MEProductsPrices[ii]}");

PT($"Please Pay The Amount : {MEProductsPrices[ii]}");


string ClientPaied = AC();
int ClientPaiedInt = int.Parse(ClientPaied);


PT($"You Paied {ClientPaiedInt} and Produt price is {MEProductsPrices[ii]}");
if (ClientPaiedInt == MEProductsPrices[ii])
{
    PT("Thanks..");
}
if (ClientPaiedInt > MEProductsPrices[ii])
{
    int later = ClientPaiedInt - MEProductsPrices[ii];
    PT($"Please Take the later amount is : {later}");
    PT("Thanks..");
}
if (ClientPaiedInt < MEProductsPrices[ii])
{
    PT("Sorry , Your Amount not enough..");
}

void PT(string t1)
{
    Console.WriteLine(t1);
}


string AC()
{
    return Console.ReadLine(); 
}