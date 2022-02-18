using ProjetoMaresias.ConexoesBD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaresias.Modelo
{
    class Quarto
    {
        public int Numero { get; set; }
        public string Descricao { get; set; }
        public int Andar { get; set; }
        public double Diaria { get; set; }

        public Quarto()
        {
        }

        public string Cadastrar(Quarto quarto)
        {
            DALComandosQuarto comandosQuarto = new DALComandosQuarto();
            return comandosQuarto.Cadastrar(quarto);
        }

        public Quarto CarregaDados(int numQuarto)
        {
            DALComandosQuarto comandosQuarto = new DALComandosQuarto();
            return comandosQuarto.CarregaDados(numQuarto);
        }

        public DataTable Consultar(string descricao)
        {
            DALComandosQuarto comandosQuarto = new DALComandosQuarto();
            return comandosQuarto.Consultar(descricao);
        }

        public string AlterarDados(Quarto quarto)
        {
            DALComandosQuarto comandosQuarto = new DALComandosQuarto();
            return comandosQuarto.Alterar(quarto);
        }

        public DataTable Disponibilidade(DateTime entrada, DateTime saida)
        {
            DALComandosQuarto comandosQuarto = new DALComandosQuarto();
            return comandosQuarto.Disponibilidade(entrada, saida);
        }
    }
}
