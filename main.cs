using System;

class MainClass {
  public static void Main () {

    Carros automovel = new Carros("uno Mile 1.0", 15);
    Carro Carro_1= new Carro();

    string continuar = "S";
    string Modelo;
    string MaisEconomico;
    int Consumo, MenorConsumo;
    MenorConsumo = 0;
    MaisEconomico="";
    double ValorViagem;
    ValorViagem=0;

    while (continuar=="S"){
      Console.WriteLine("Digite o modelo do novo carro >> ");
      Modelo = Console.ReadLine();
      Console.WriteLine("Digite o consumo do novo carro >>");
      Consumo = int.Parse(Console.ReadLine());

      Carro_1= new Carro(Modelo, Consumo);
      automovel.Modelos.Add(Carro_1);

      Console.WriteLine("Deseja continuar? (S ou N) ");
      continuar = Console.ReadLine();
    }

    Console.WriteLine("Total de Carros {0}", automovel.Modelos.Count);

    Console.WriteLine("\n");

    for (int i=0;i<automovel.Modelos.Count;i++){
    Console.WriteLine("Carro {0} - Consumo {1} ",automovel.Modelos[i].GetCarro(), automovel.Modelos[i].GetConsumo());
      if(automovel.Modelos[i].GetConsumo() > MenorConsumo){
        MenorConsumo = automovel.Modelos[i].GetConsumo();
        MaisEconomico = automovel.Modelos[i].GetCarro();
    }
    }
    Console.WriteLine("O mais é economico é o {0} e roda {1}km/L", MaisEconomico, MenorConsumo);
    Console.WriteLine("\n");

    for (int i=0;i<automovel.Modelos.Count;i++){
      ValorViagem = (1000/automovel.Modelos[i].GetConsumo())*4.89;
      Console.WriteLine("Carro {0} - Consumo para viajar 1000KM R${1} ",automovel.Modelos[i].GetCarro(), ValorViagem);
    
    }
  }
}