namespace HausaufgabeV03;

public struct Kontakt
{
    private string _name;
    private string _adresse;

    public string Name{private set => _name = String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value)? throw new Exception(""): value; get=> _name;}
    public string Adresse{private set => _adresse = String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value)? throw new Exception(""): value; get=> _adresse;}

    public Kontakt(string name, string adresse){
        Name = name;
        Adresse = adresse;
    }

    public string Darstellung(){
        return $"{Name} : {Adresse}";
    }
}
