// See https://aka.ms/new-console-template for more information
using kamp1.Business;
using kamp1.Entities;

Console.WriteLine("Hello, World!");

string message = "Krediler";
string message1 = "Krediler";
string message2 = "Krediler";
string message3 = "Krediler";
string message4 = "Krediler";
string message5 = "Krediler";
string message6 = "Krediler";


int term = 12;
double amount = 10000.5;


bool isAthenticated = false;//backendden gelen data veri
Console.WriteLine(message1);


//condition 

if(isAthenticated)
{
    Console.WriteLine("Hoşgeldin Taha");
}
else
{
    Console.WriteLine("Sisteme Giriş Yap");


}
string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6" };
//string[] loans2 = new string[6];
//loans2[0] = "Kredi 1";

Console.WriteLine("Kod bitti");
        //start   condition      increment
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}


CourseManager courseManager = new CourseManager();
Course[] courses2 = courseManager.GetAll();


for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + "/ " + courses2[i].Price);

}


