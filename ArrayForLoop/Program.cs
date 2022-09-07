// See https://aka.ms/new-console-template for more information

string name = "khaled";
int age = 22;

DateTime Birthday = DateTime.Now;
DateTime FoundedAt = new DateTime(1952, 3, 4); // New 
Console.WriteLine($"Welcocem e ,sd vsd vs  {FoundedAt} ");
string FloorNumber = "15";
// This is a String we can not Sum Or Substract or multipli or divid
// these string we should convert to int to create math operations 

int FN = Convert.ToInt32(FloorNumber);
int FN1 = int.Parse(FloorNumber);  // New 

string FnStr = FN.ToString(); // New 

string birthdate = "2022-01-01";

DateTime MaryamBirthDate = Convert.ToDateTime(birthdate); // New 
DateTime MaryamBirthDate2 = DateTime.Parse(birthdate); // New 

string datasttr = MaryamBirthDate.ToString(); // New 



// variable ..  متغير 
int x = 5; // Number 
string myname = "ahmed"; //   text 
DateTime currentDate = new DateTime(2022, 5, 1, 11, 55, 33); // Date And Time 

//Array  // New 
string[] FamilyMembers = new string[5];

string[] FamilyMembers2 = { "Aya", "Mahmoud", "..  ", " 33 ", " 123", " 32 3", " 23 23", " 23 23" };

FamilyMembers[0] = "khaled";
FamilyMembers[1] = "Ahmed";
FamilyMembers[2] = "Medo";
FamilyMembers[3] = "Shady";
FamilyMembers[4] = "Maryam";


int[] myFlags = new int[2];

myFlags[0] = 1;
myFlags[1] = 34;

int[] classRooms = { 2, 6, 85, 5 };










// For Loop  
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
}

for (int i = 0; i < FamilyMembers.Length; i++)
{
    Console.WriteLine(FamilyMembers[i]);
}


// Parse  ..   From sting           >>>>> >>>>     to any data Type
// Stringfy .. From any data Type   >>>>> >>>>     to String .





// Function and Calling F

string name2 = AC("Welcome Write Your Name .. ");




void PT(string t)
{
    Console.WriteLine(t);
}


string AC(string t)
{
    PT(t);
    return Console.ReadLine();
}



