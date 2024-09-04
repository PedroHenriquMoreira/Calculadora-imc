using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    internal class pessoa
    {
        public string nome;
        public string telefone;
        public string email;
        public double peso;
        public double altura;
        public double imc;
        public string clas;
        public void cadastrar()
        {
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu email");
            email = Console.ReadLine();
            Console.WriteLine("Digite seu telefone");
            telefone = Console.ReadLine();
            Console.WriteLine("Qual é seu peso?");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua altura");
            altura = double.Parse(Console.ReadLine());
            Console.ReadKey();
            imc = peso / (altura * altura);



        }
        public void dados()
        {
            Console.WriteLine("nome: {0}", nome);
            Console.WriteLine("telefone: {0}", telefone);
            Console.WriteLine("email: " + email);
        }

        public void dados2()
        {

            if (imc <= 16)
            {
                Console.WriteLine("Imc: {0} - Magreza Grave", imc);
            }
            else if (imc > 16 && imc <= 16.9)
            {
                Console.WriteLine("Imc: {0} - Magreza moderada", imc);
            }
            else if (imc > 17 && imc <= 18.5)
            {
                Console.WriteLine("Imc: {0} - Magreza Leve", imc);
            }
            else if (imc > 18.6 && imc <= 24.9)
            {
                Console.WriteLine("Imc: {0} - Peso Ideal", imc);
            }
            else if (imc > 25 && imc <= 29.9)
            {
                Console.WriteLine("Imc: {0} - Sobrepeso", imc);
            }
            else if (imc > 30 && imc <= 34.9)
            {
                Console.WriteLine("Imc: {0} - Obesidade Grau I", imc);
            }
            else if (imc > 35 && imc <= 39.9)
            {
                Console.WriteLine("Imc: {0} - Obesidade Grau II ou Severa", imc);
            }
            else if (imc > 40)
            {
                Console.WriteLine("Imc: {0} - Obesidade Grau III ou Mórbida", imc);
            }
        }

    }
}

    
