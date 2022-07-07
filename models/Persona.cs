using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace models
{
    public class Persona
    {
        string nome;
        int idade;
        float altura;

        public Persona(string nome, int idade, float altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
        }

        public bool verificarMaiorIdade()
        {
            if (idade >= 18)
            {
                return true;
            }
            return false;
        }
    }
}