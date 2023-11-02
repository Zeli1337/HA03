namespace HausaufgabeV03;

public class Aufsatz : Textdokument
{
    private string _autor;
    private string _titel;

    public string Titel{
        get =>  _titel;
        protected set => _titel = String.IsNullOrEmpty(value)|| String.IsNullOrWhiteSpace(value)? throw new Exception(""):value;
        
    }
    public string Autor{
        get =>  _autor;
        protected set => _autor = String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value)? throw new Exception(""):value;
    }

    public Aufsatz(string autor, string titel):base(){
        Autor = autor;
        Titel = titel;

    }

}
