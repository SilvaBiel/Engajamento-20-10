using System.Collections.Generic;
using System;

class Carros {
  public string Modelo;
  double Consumo;

  public List<Carro> Modelos;

  public Carros () {
    Modelo = "Uno Mile";
    Consumo = 10.00;
    Modelos = new List<Carro>();
  }

  public Carros (string n, double p) {
    Modelo = n;
    Consumo = p;
    Modelos = new List<Carro>();
  }




}