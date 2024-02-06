// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;

Console.WriteLine("Hello, World!");

//Degiskenler();
Vatandas vatandas1 = new Vatandas();


static void Degiskenler()
{
    string mesaj = "Selam";
    double tutar = 100000;
    int sayi = 100;
    bool girisYapmisMi = false;

    string ad = "Ferhat";
    string soyad = "Turuç";
    int dogumYili = 1999;
    long tcNo = 12345678910;

    Console.WriteLine(mesaj);

    Console.WriteLine(tutar);
    Console.WriteLine(tutar * 1.18);
}

Person person = new Person();

SelamVer(isim: "Ferhat");
SelamVer(isim: "Muhammet");
SelamVer(isim: "Faruk");
SelamVer();

//Diziler / Arrays

string ogrenci1 = "Ferhat";
string ogrenci2 = "Faruk";
string ogrenci3 = "Muhammet";

Console.WriteLine(ogrenci1);
Console.WriteLine(ogrenci2);
Console.WriteLine(ogrenci3);

string[] ogrenciler = new string[4];
ogrenciler[0] = "Ferhat";
ogrenciler[1] = "Faruk";
ogrenciler[2] = "Muhammet";
ogrenciler[3] = "Ramazan";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = new[] { "Bursa", "Konya", "Urfa" };
sehirler2 = sehirler1;
sehirler1[0] = "Adana";

Console.WriteLine(sehirler2[0]);

foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

//MyList
List<string> yeniSehirler1 = new List<string> { "Ankara", "İstanbul", "İzmir" };
yeniSehirler1.Add(item: "İzmir 1");

foreach (var sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}

Person person1 = new Person();
person1.FirstName = "FERHAT";
person1.LastName = "TURUÇ";
person1.DateOfBirthYear = 1999;
person1.NationalIdentity = 123;


Person person2 = new Person();
person2.FirstName = "Faruk";

int sonuc = Topla(5,3);

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

Console.ReadLine();
static void SelamVer(string isim="isimsiz")
{
    Console.WriteLine("Merhaba" + isim);
}
static int Topla(int sayi1, int sayi2)
{
    int sonuc = sayi1 + sayi2 ;
    Console.WriteLine("Toplam :" + sonuc);
    return sonuc;
}
public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long tcNo { get; set; }
}