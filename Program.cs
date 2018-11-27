using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_6_exercicios_praticas_de_programação
{
    class Program
    {
             
        
        static void Main(string[] args)
        {

            Console.WriteLine("Boa noite professor Diego!");
            Console.WriteLine("Pressione qualquer tecla para iniciar a correção do exercício...");
            Console.ReadKey();
            Console.Write("Que a força esteja com você. {-_-}");
            Console.ReadKey();
            Console.Clear();

            //Exercicio 1
            //1. Uma empresa quer transmitir dados pelo telefone, mas está preocupada com a
            //interceptação telefônica. Todos os seus dados são transmitidos como inteiros de quatro
            //dígitos.Ela pediu para que você escreva um programa que criptografe seus dados, para
            //que eles possam ser transmitidos com mais segurança. Seu aplicativo deve ler um inteiro
            //de quatro dígitos fornecidos pelo usuário e criptografá-lo da seguinte forma: substitua cada
            //dígitos por(a soma desse dígitos mais 7) módulo 10.Em seguida, troque o primeiro dígito
            //pelo terceiro e troque o segundo dígito pelo quarto e imprima o inteiro criptografado.


            Console.Write("Insira um número de quarto digitos:");

            // primeiro digito
            int Entrada = Convert.ToInt32(Console.ReadLine());

            //resto da divisão de entrada por 1000        
            int temporario1 = Entrada / 1000;                       
            int resto1 = Entrada % 1000;                        
            int num1 = temporario1;


            //Segundo digito
            //temporario2 é valor de resto1 / por 100
            int temporario2 = resto1 / 100;     
            int resto2 = resto1 % 100;          
            int num2 = temporario2;


            //Terceiro digito
            //temporario é o valor de resto 2 / 10
            int temporario3 = resto2 / 10;
            int resto3 = resto2 % 10;
            int num3 = temporario3;

            int num4 = resto3;

            //soma criptografia
            var num_1_criptografado = (num1 + 7) % 10;
            var num_2_criptografado = (num2 + 7) % 10;
            var num_3_criptografado = (num3 + 7) % 10;
            var num_4_criptografado = (num4 + 7) % 10;

            Console.WriteLine("O numero criptografado é:");

            Console.Write("{0}{1}{2}{3}", num_3_criptografado, num_4_criptografado, num_1_criptografado, num_2_criptografado);

            Console.ReadLine();
            Console.Clear();

            
            //Exercicio 2
            //Crie um programa em C# que determina se o cliente de uma loja de departamentos
            //ultrapassou o limite de crédito em uma conta. Para cada cliente modelado em uma classe,
            //os seguintes dados estão disponíveis:
            //
            //a. Número da conta
            //b. O saldo no início do mês;
            //c. O total de todos os itens cobrados desse cliente no mês corrente;
            //d. O total de todos os créditos aplicados na conta desse cliente no mês corrente;
            //e. O limite de crédito permitido.
            //
            //O programa deve fornecer como valores inteiros cada um desses fatos, e através dos
            //métodos da classe cliente: calcular o novo saldo(= saldo inicial + cobranças - créditos),
            //exibir o novo saldo e determinar se o novo saldo ultrapassa o limite de crédito do cliente.
            //Para os clientes cujo limite de crédito foi ultrapassado, o programa deve exibir a
            //mensagem: “Limite de Crédito Excedido!”. Teste a classe criada, bem como os métodos
            //propostos na classe principal do seu programa. 

            int saldo  = 0;

            Console.WriteLine("Digite o saldo:");
            saldo = int.Parse(Console.ReadLine());

            Cliente_Exercicio2 client = new Cliente_Exercicio2(saldo, 2, 200, 300,4000);
            Console.WriteLine("Seu limite de credito é:");
            Console.Write(client.calcular_novo_saldo());

            client.atualizar_saldo();

            if (client.verificar_limite())
            {
               
            }
            else
            {
                
            }
            Console.ReadLine();
            Console.Clear();



          

            //Exercicio 3
            //Implemente em C# a função booleana Par que retorna verdadeiro se um número inteiro
            //passado como parâmetro for par ou falso caso ele seja ímpar.Teste seu programa
            //chamando a função para verificar os números de 0 à 10. 




            Console.WriteLine("Escreva o numero para verificar se ele é impar ou par :");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("o numero {0} é par", numero);
            }
            else
            {
                Console.WriteLine("o numero {0} é impar", numero);
            }



            Console.ReadKey();
            Console.Clear();

            

            //Exercicio 4
            //Escreva um programa que leia 3 números inteiros referente ao comprimento dos lados de
            //um triângulo e classifique como: triângulo equilátero, isósceles ou escaleno. 

            Console.Write("Insira o valor do primeiro lado do triângulo:");
            string triangulo_lado1 = Console.ReadLine();

            Console.Write("Insira o valor do segundo lado do triângulo:");
            string triangulo_lado2 = Console.ReadLine();

            Console.Write("Insira o valor do último lado do triângulo:");
            string triangulo_lado3 = Console.ReadLine();

            if (triangulo_lado1 == triangulo_lado2 && triangulo_lado2 == triangulo_lado3)
            {

                Console.WriteLine("este é um triangulo equilátero");

            }
            else if (triangulo_lado1 == triangulo_lado2 || triangulo_lado2 == triangulo_lado3 || triangulo_lado1 == triangulo_lado3)
            {

                Console.WriteLine("este é um triangulo isósceles");

            }
            else
            {

                Console.WriteLine("este é um triangulo escaleno");

            }
            Console.ReadLine();
            Console.Clear();
                            

            //Exercicio 5
            //Escreva um programa que leia apenas uma letra do alfabeto como entrada e classifique-a
            //como vogal ou consoante. Seu programa deverá aceitar como entrada apenas um
            //caractere, ou seja, se o usuário digitar dois ou mais caracteres, o sistema deverá informar
            //ao usuário a entrada rejeitada. 

            int verifica = 0;

            Console.Write("Digite uma(1) letra do alfabeto:");

            var letra = Console.ReadLine().ToArray();

            string[] vogais = new string[] { "a", "A", "e", "E", "i", "I", "o", "O", "u", "U" };

            if (letra.Length == 1)
            {
                for (int i = 0; i < vogais.Length; i++)
                {
                    if (letra[0].ToString() == vogais[i])
                    {
                        verifica = 1;
                    }
                }

                if (verifica == 1)
                {
                    Console.WriteLine("\nA letra digitada é uma Vogal");
                }

                else
                {
                    Console.WriteLine("\nA letra digitada é uma Consoante ou apenas um caractere");
                }

            }
            else
            {
                Console.WriteLine("Valor incorreto.");
            }

            Console.ReadKey();
            Console.Clear();
                                 
            //Exercicio 6
            //“Um número é primo se ele for divisível por 1 e por ele mesmo”. Escreva um programa C#
            //que verifica se um número é primo. 

            Console.WriteLine("Digite um número natural maior que 2 e verifique se ele um número Primo:\n");

            int numprimo = 0;
            int restodivisao = 0;
            int denominador = 0;
            int verificador = 0;

            numprimo = int.Parse(Console.ReadLine());

            for (denominador = 2; denominador < numprimo; denominador++)
            {
                restodivisao = numprimo % denominador;

                if (restodivisao == 0)
                {
                    verificador = 1;
                }
            }

            if (verificador == 1)
            {
                Console.WriteLine("O número inserido não é um número Primo.");
            }
            else
            {
                Console.WriteLine("O número inserido é um número Primo.");
            }
            Console.ReadKey();
            Console.Clear();
        }

    }
}
