using ProjetoMaresias.ConexoesBD;
using ProjetoMaresias.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaresias.Modelo
{
    class Produto
    {
        public int IdProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public Categoria Categoria { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public char Status { get; set; }

        public string Cadastrar(Produto produto) //Método que chama o comando de input do produto no banco de dados.
        {
            DALComandosProduto comandosProduto = new DALComandosProduto();
            return comandosProduto.Cadastrar(produto);
        }

        public Produto CarregarDados(int idProduto)  //Método que chama a coleta dos dados do produto através do código no banco de dados.
        {
            DALComandosProduto comandosProduto = new DALComandosProduto();
            return comandosProduto.CarregaDados(idProduto);
        }

        public string AlterarDados(Produto produto) //Método que chama o comando de update do produto no banco de dados.
        {
            DALComandosProduto comandosProduto = new DALComandosProduto();
            return comandosProduto.Alterar(produto);
        }

        public DataTable Consultar(string descProduto, string status) //Método que trás todos os dados da tabela no banco de dados.
        {
            DALComandosProduto comandosProduto = new DALComandosProduto();
            if (status == "Todos")
            {
                status = "";
            }
            return comandosProduto.ConsultarProduto(descProduto, status);
        }
    
        public Produto ProcuraProduto(string descricao)
        {
            DALComandosProduto comandosProduto = new DALComandosProduto();
            return comandosProduto.ProcuraProduto(descricao);
        }
    }
}
