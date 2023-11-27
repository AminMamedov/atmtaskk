using System.Xml;

Console.WriteLine(  "Hos gelmisiz,zehmet olmasa username daxil edin:");
 string username   = Console .ReadLine();
Console.WriteLine(  "Zehmet olmasa parolunuzu daxil edin:");
 string password  = Console .ReadLine();
decimal  balans = 100;
decimal mebleg = 0; 
if (username == "Amin"  && password == "Parol123")
{
    Console.WriteLine("Her vaxtiniz xeyir ,xos gelmisiniz:");
    Console.WriteLine(" ");
    Console.WriteLine("1) Balansinizi artrin");
    Console.WriteLine("2) Balansiniz'dan pul cekin");
    Console.WriteLine("3) Balansiniza baxin");
    Console.WriteLine("4) Cixis edin");
    Console.WriteLine(" ");
    Console.WriteLine("Etmek istediyiniz emeliyyati secin:");
    int i = Convert.ToInt32(Console.ReadLine());
    while (i != 4)

    {
        if (i == 1)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Neqeder pul artirmaq isteyirsiniz:");
            mebleg = Convert.ToDecimal(Console.ReadLine());
            balans = balans + mebleg;
            Console.WriteLine(" ");
            Console.WriteLine("Etmek istediyiniz emeliyyati secin:");
            Console.WriteLine("1) Balansinizi artrin");
            Console.WriteLine("2) Balansiniz'dan pul cekin");
            Console.WriteLine("3) Balansiniza baxin");
            Console.WriteLine("4) Cixis edin");
            i = Convert.ToInt32(Console.ReadLine());
        }
        else if (i == 2)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Neqeder pul cekmek  isteyirsiniz:");
            mebleg = Convert.ToDecimal(Console.ReadLine());
            balans = balans - mebleg;
            Console.WriteLine(" ");
            Console.WriteLine("Etmek istediyiniz emeliyyati secin:");
            Console.WriteLine("1) Balansinizi artrin");
            Console.WriteLine("2) Balansiniz'dan pul cekin");
            Console.WriteLine("3) Balansiniza baxin");
            Console.WriteLine("4) Cixis edin");
            i = Convert.ToInt32(Console.ReadLine());
        }
        else if (i == 3)
        {
            Console.WriteLine(" ");
            Console.WriteLine(  "Balans :");
            Console.WriteLine(balans);
            Console.WriteLine( " ");
            Console.WriteLine("Etmek istediyiniz emeliyyati secin:");
            Console.WriteLine("1) Balansinizi artrin");
            Console.WriteLine("2) Balansiniz'dan pul cekin");
            Console.WriteLine("3) Balansiniza baxin");
            Console.WriteLine("4) Cixis edin");
            i = Convert.ToInt32(Console.ReadLine());

        }
        else if (i == 4)
        {
            Console.WriteLine("Hos gunler arzulayiriq:)");
            break;
        }
        

    }
    




}
else
{   
    Console.WriteLine(  "Zehmet olmasa duzgun username ve parol yazin");
}


