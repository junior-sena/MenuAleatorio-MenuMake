using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuAleatorio
{
    public class MenuAleatorio
    {
        // A classe Ramdomizar possui tres (string) para armazenar as tres matrizes(Diferentes) de texto que contem os igredientes do sanduíche
        public Random Randomizar; // Randomizar = escolher aleatoriamente ou aleatorio
        String[] Carnes = { "Carne moída", "Pesunto", "Peru", "Salami" };
        String[] Coberturas = { "Mustarda", "Maionese", "Ketchup" };
        String[] Paes = { "Pão Arabe", "Pão Françes ", "Pão de Alho" };


        // O método retorna uma senquecia de caracteres formando um sanduíche com elementos aleatorios das 3 matrizes
        public String getMenuAleatorio()
        {
            String CarneAleatoria = Carnes[Randomizar.Next(Carnes.Length)];
            String CoberturaAleatoria = Coberturas[Randomizar.Next(Coberturas.Length)];
            String PaoAleatorio = Paes[Randomizar.Next(Paes.Length)];
            return "Sanduíche de: " + PaoAleatorio + " com " + CarneAleatoria + " e cobertura de " + CoberturaAleatoria;
        }
    }

}

