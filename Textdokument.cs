using System.Diagnostics.Contracts;

namespace HausaufgabeV03;

public class Textdokument
{
    private string _text;
    public string Text{protected set => _text = string.IsNullOrEmpty(value)? throw new Exception(""): value; get => _text; }

    public Textdokument(){
        _text = "";
    }

    public void ZeileZufügen(string zeile){
        if(zeile == null){
            throw new Exception("");

        }
        _text+= zeile;
    }
}
