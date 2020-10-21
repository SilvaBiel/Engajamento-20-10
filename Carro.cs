using System;

class Carro {
    string Modelo; //nome da Carro
    int Consumo;


    public Carro(){
        /*construtor*/
      Modelo = "Uno Mile";
      Consumo = 18;
    }
   
    public Carro(string m, int c){
      Modelo = m;
      Consumo = c;
    }
    
    public string GetCarro(){
      return Modelo;
    }
    public int GetConsumo(){
      return Consumo;
    }
}