using System;

public class Story
{
    public void DisplayCurrentStory()
    {
        // CENTER
        if (Center.hasVisitedCenter)
        {
            Utility.SlowPrint("-------------------",100);
            Utility.SlowPrint("I 2022 udgjorde emballage 1.108.000 tons — svarende til cirka 189,6 kg pr. borger i Danmark.", 30);
            Utility.SlowPrint("Omkring 200.000 tons af dette kom fra plastikemballage — et materiale, der både er dyrt at producere og bliver downcyclet, hvilket betyder, at det til sidst ikke længere kan genanvendes.", 30);
            Utility.SlowPrint("-------------------",100);
        }
        else
        {
            Utility.SlowPrint("-------------------",100);
            Utility.SlowPrint("Du har ikke fundet dette avisudklip, udforsk øen for at finde det.", 30);
            Utility.SlowPrint("-------------------",100);
        }

        // EAST
        if (East.hasVisitedEast)
        {
            Utility.SlowPrint("-------------------",100);
            Utility.SlowPrint("Emballage har en vigtig funktion, da den beskytter produkter under transport og forlænger deres holdbarhed, hvilket hjælper med at reducere madspild.", 30);
            Utility.SlowPrint("Dette skaber et dilemma mellem behovet for funktionel emballage", 30);
            Utility.SlowPrint("-------------------",100);
        }
        else
        {
            Utility.SlowPrint("-------------------",100);
            Utility.SlowPrint("Du har ikke fundet dette avisudklip, udforsk øen for at finde det.", 30);
            Utility.SlowPrint("-------------------",100);
        }

        // NORTH
        if (North.hasVisitedNorth)
        {
            Utility.SlowPrint("-------------------",100);
            Utility.SlowPrint("Det bliver derfor tydeligt, at løsningen på emballageproblemet kræver en bredere indsats,", 30);
            Utility.SlowPrint("hvor både producenter og forbrugere spiller en rolle", 30);
            Utility.SlowPrint("i at finde en balance mellem funktionalitet og bæredygtighed.", 30);
            Utility.SlowPrint("-------------------",100);
        }
        else
        {
            Utility.SlowPrint("-------------------",100);
            Utility.SlowPrint("Du har ikke fundet dette avisudklip, udforsk øen for at finde det.", 30);
            Utility.SlowPrint("-------------------",100);
        }

        // FOREST
        if (Forest.hasVisitedForest)
        {
            Utility.SlowPrint("-------------------",100);
            Utility.SlowPrint("Selvom emballage og indpakning af pap og papir kan genanvendes, og træressourcer teknisk set er uendelige,", 30);
            Utility.SlowPrint("er vi begrænset af, at vi fælder omkring 10 milliarder flere træer hvert år, end vi planter. De træer, vi planter i dag, vil først kunne bruges om 10-20 år.", 30);
            Utility.SlowPrint("Det betyder, at en tilsyneladende uendelig og genanvendelig ressource stadig kan slippe op over tid.", 30);
            Utility.SlowPrint("-------------------",100);
        }
        else
        {
            Utility.SlowPrint("-------------------",100);
            Utility.SlowPrint("Du har ikke fundet dette avisudklip, udforsk øen for at finde det.", 30);
            Utility.SlowPrint("-------------------",100);
        }

        // SOUTH
        if (South.hasVisitedSouth)
        {
            Utility.SlowPrint("-------------------",100);
            Utility.SlowPrint("Ulempen ved træbaseret emballage er genanvendelsesprocessen, hvor fibrene kun kan genbruges op til syv gange.", 30);
            Utility.SlowPrint("En anden ulempe er brugen af PFAS-kemikalier i mange papir- og papproduktioner. PFAS er fluorforbindelser, der giver en vandafvisende effekt på tøj.", 30);
            Utility.SlowPrint("Nogle typer er skadelige for mennesker og kan forårsage leverskader og fertilitetsproblemer, og alle er svære at nedbryde i naturen.", 30);
            Utility.SlowPrint("-------------------",100);
        }
        else
        {
            Utility.SlowPrint("-------------------",100);
            Utility.SlowPrint("Du har ikke fundet dette avisudklip, udforsk øen for at finde det.", 30);
            Utility.SlowPrint("-------------------",100);
        }

        // OCEAN
        if (Ocean.hasVisitedOcean)
        {
            Utility.SlowPrint("-------------------",100);
            Utility.SlowPrint("Meget plastik ender som mikroplast i naturen, og på grund af dets styrke tager det ekstremt lang tid at nedbryde.", 20);
            Utility.SlowPrint("11 millioner tons plastaffald finder vej til vores oceaner gennem fejlsortering og dumpning af affald i havet. Disse 11 millioner tons,", 20);
            Utility.SlowPrint("er kun et lille tilskud til de allerede 200 millioner tons, der allerede findes i verdens oceaner. Med denne produktion og affaldsrate vil der i 2050 være mere plastik end fisk i havet.", 30);
            Utility.SlowPrint("-------------------",100);
        }
        else
        {
            Utility.SlowPrint("-------------------",100);
            Utility.SlowPrint("Du har ikke fundet dette avisudklip, udforsk øen for at finde det.", 30);
            Utility.SlowPrint("-------------------",100);
        }

        // WEST
        if (West.hasVisitedWest)
        {
            Utility.SlowPrint("-------------------",100);
            Utility.SlowPrint("Det giver et problem for os mennesker, siden forbruget af naturlige ressourcer er steget over de sidste 50 år,", 30);
            Utility.SlowPrint("og det vil blive ved med at stige globalt fremover. Udover det er vores udnyttelse af genanvendelse af det affald, der bliver produceret, ikke god nok.", 30);
            Utility.SlowPrint("Det betød, at vi i de sidste 5 måneder af 2018 overtrak mængden af Jordens ressourcer.", 30);
            Utility.SlowPrint("Forbruget svarede til 1.7 jordkloder, hvis ressourcerne skulle fornyes.", 30);
            Utility.SlowPrint("-------------------",100);
        }
        else
        {
            Utility.SlowPrint("-------------------",100);
            Utility.SlowPrint("Du har ikke fundet dette avisudklip, udforsk øen for at finde det.", 30);
            Utility.SlowPrint("-------------------",100);
        }
    }
}
