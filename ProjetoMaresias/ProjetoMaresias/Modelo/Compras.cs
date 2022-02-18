using ProjetoMaresias.ConexoesBD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaresias.Modelo
{
    class Compras : Produto
    {
        public double ValorTotal { get; set; }
        public DateTime DataPagamento { get; set; }

        public string Cadastrar(Compras compras) //Método que chama o comando de input do produto no banco de dados.
        {
            DALComandosCompras comandosCompras = new DALComandosCompras();
            return comandosCompras.Cadastrar(compras);
        }

        public DataTable ConsultarProduto()
        {
            DALComandosCompras comandosCompras = new DALComandosCompras();
            return comandosCompras.ConsultarProduto();
        }

        public DataTable Relatorio(DateTime inicio, DateTime fim)
        {
            DALComandosCompras comandosCompras = new DALComandosCompras();
            return comandosCompras.Relatorio(inicio, fim);
        }
    }
}
