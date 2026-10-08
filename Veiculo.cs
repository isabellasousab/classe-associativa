public class Veiculo{
    private string _modelo ="";
    private string _placa ="";

    public string Modelo{

    get{return _modelo;}
    set{_modelo = value;}
    }

    public string Placa{
    
    get{return _placa;}
    set{_placa = value;}
    }

    public Veiculo(string modelo, string placa)
    {
        this.Modelo = modelo;
        this.Placa = placa;
    }
}