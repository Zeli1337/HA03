using System.Runtime.CompilerServices;

namespace HausaufgabeV03;

public class Schulaufsatz : Aufsatz
{
    string _note;
    public string Note {
        get { return _note; }
        set { _note = String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value)  ? throw new Exception(""): value; }
    }

    public Schulaufsatz(string a, string b):base(a,b){
        Note = "offen";
    }

}
