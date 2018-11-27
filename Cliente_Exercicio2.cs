using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_6_exercicios_praticas_de_programação
{
    class Cliente_Exercicio2
    {
        ///atributos
        private int saldo;
        private int conta;
        private int totalCobrancas;
        private int totalCredito;
        private int limiteCredito;

        ///construtor padrão
        /// construtor utiliza o mesmo nome da classe
        public Cliente_Exercicio2()
        {
            ///aqui dentro faço a inicialização dos atributos da classe

         saldo = 0;
         conta = 0;
         totalCobrancas = 0;
         totalCredito = 0;
         limiteCredito = 0;


        }

        ///construtor com valores do usuario
        ///utiliza o mesmo nome da classe

        public Cliente_Exercicio2(int saldo, int conta, int totalCobrancas, int totalCredito, int limiteCredito)
        {
            this.saldo = saldo;
            this.conta = conta;
            this.totalCobrancas = totalCobrancas;
            this.totalCredito = totalCredito;
            this.limiteCredito = limiteCredito;
        }

        ///Metodo calcular novo saldo
        public int calcular_novo_saldo()    
        {
            return this.saldo + this.totalCobrancas - this.totalCredito;
        }


        ///Metodo atualizar saldo
        public void atualizar_saldo()
        {
            this.saldo = calcular_novo_saldo();
        }


        ///verificar limite ultrapassado
        public bool verificar_limite()
        {
            return this.saldo > this.limiteCredito;
        }





    }

}
