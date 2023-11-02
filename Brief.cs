using System.Runtime.CompilerServices;

namespace HausaufgabeV03;

public class Brief : Textdokument
{
    public Kontakt _adressat;
    public Kontakt _absender;

    public Kontakt Adressat{get => _adressat;}
    public Kontakt Absender{get => _absender;}

    public Brief(Kontakt Adressat,Kontakt Absender ):base(){
        //if(Absender == null || Adressat == null)
        _absender = Absender;
        _adressat = Adressat;
    }
}
