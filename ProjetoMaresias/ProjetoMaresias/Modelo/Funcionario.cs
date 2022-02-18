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
    class Funcionario : Pessoa
    {
        public int IdFuncionario { get; set; }
        public char Status { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Departamento { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string NumeroEndereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime DataDemissao { get; set; }

        public Funcionario()
        {
        }

        public string Cadastrar(Funcionario funcionario)
        {
            DALComandosFuncionario comandosFuncionario = new DALComandosFuncionario();
            return comandosFuncionario.Cadastrar(funcionario);
        }

        public DataTable Consultar(string nome, string status)
        {
            DALComandosFuncionario comandosFuncionario = new DALComandosFuncionario();
            if(status == "Todos")
            {
                status = "";
            }
            return comandosFuncionario.Consultar(nome, status);
        }

        public Funcionario CarregaDados(int idFuncionario)
        {
            DALComandosFuncionario comandosFuncionario = new DALComandosFuncionario();
            return comandosFuncionario.CarregaDados(idFuncionario);
        }

        public string AlterarDados(Funcionario funcionario)
        {
            DALComandosFuncionario comandosFuncionario = new DALComandosFuncionario();
            return comandosFuncionario.Alterar(funcionario);
        }
    }
}
