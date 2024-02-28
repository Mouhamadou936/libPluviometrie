using libPluviometrie;



int[] Dijon = { 35, 38, 40, 24, 18, 11, 5, 4, 12, 19, 21, 29 };
int[] Beaune = { 31, 35, 38, 25, 19, 10, 6, 5, 13, 17, 20, 27 };
int[] Montbard = { 36, 36, 39, 23, 15, 9, 4, 3, 14, 20, 22, 28 };


Pluviometrie Cotedor = new Pluviometrie(Dijon, Beaune, Montbard);
Console.WriteLine("***********************************************************" +
    "\n1 - Voulez vous connaitre la pluviosité par mois ?" +
    "\n2 - Voulez vous connaitre la pluviosité par region ?" +
    "\n3 - Voulez vous connaitre la pluviosité annuelle ?" +
    "\n***********************************************************");


                 
string choix = Console.ReadLine();

switch (choix)
{
    case "1":
       Cotedor.PluviositeAnnee();

        break;

    case "2":
        Cotedor.PluviositeMois();

        break;

    case "3":
        Cotedor.PluviositeRegion();

        break;
}
