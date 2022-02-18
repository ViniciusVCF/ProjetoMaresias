Create Table TB_Cliente(
ID_Cliente Int Identity(6000000, 1),
Nm_Cliente Varchar(200),
Nr_Celular Varchar(14),
Nr_RG Numeric(9),
Nr_CPF Numeric(11),
Ds_Email Varchar(100),

Primary Key(ID_Cliente)
);

Create Table TB_Funcionario(
Nr_Matricula Int Identity(20000, 1),
St_Ativo Char(1),
Nm_Funcionario Varchar(200),
Nr_RG Numeric(9),
Nr_CPF Numeric(11),
Dt_Nascimento Date,
Ds_Email Varchar(100),
Nr_Celular Varchar(14),
Nm_Departamento Varchar(100),
Nm_Cargo Varchar(100),
Vl_Salario Numeric(10,2),
Nr_CEP Numeric(8),
Nm_Rua Varchar(150),
Nr_Endereco Numeric(4),
Nm_Bairro Varchar(150),
Nm_Cidade Varchar(150),
Nm_Estado Char(2),
Dt_Admissao Date,
Dt_Demissao Date,

Primary Key(Nr_Matricula)
);

Create Table TB_Quarto(
Nr_Quarto Numeric(4),
Ds_Quarto Varchar(100),
Nr_Andar Numeric(2),
Vl_Diaria Numeric(10,2),

Primary Key(Nr_Quarto)
);

Create Table TB_Reserva(
Nr_Reserva Int Identity(1000,1),
ID_Cliente Int,
Nm_Cliente Varchar(200),
Dt_Entrada Date,
Dt_Saida Date,
Nr_Quarto Numeric(4),
Ds_Quarto Varchar(100),
St_Reserva Varchar(10),

Primary Key(Nr_Reserva),
Foreign Key(ID_Cliente) References TB_Cliente(ID_Cliente),
Foreign Key(Nr_Quarto) References TB_Quarto(Nr_Quarto)
);

Create Table TB_Hospedagem(
ID_Hospedagem Int Identity(1,1),
ID_Cliente Int,
Nm_Cliente Varchar(200),
Nr_Reserva Int,
Nr_DiasEstadia Int,
ID_Produto Int,
Ds_Produto Varchar(150),
Vl_Produto Numeric(10,2),
Qt_Consumo Int,
Vl_Hospedagem Numeric(10,2),
Nr_Acompanhantes Int,
Hr_Checkin Time(0),
Hr_Checkout Time(0),
Dt_Checkout Date,
St_Hospedagem Varchar(10),

Primary Key(ID_Hospedagem),
Foreign Key(ID_Cliente) References TB_Cliente(ID_Cliente),
Foreign Key(Nr_Reserva) References TB_Reserva(Nr_Reserva)
);

Create Table TB_Produto(
ID_Produto Int Identity(90000, 1),
Ds_Produto Varchar(150),
Ds_Categoria Varchar(10),
Vl_Produto Numeric(10,2),
Qt_Produto Int,
St_Produto Char(1),

Primary Key(ID_Produto)
);

Create Table TB_LoginFuncionario(
Nr_Matricula Int,
Ds_Usuario Varchar(15),
Ds_Senha Varchar(15),
St_Ativo char(1),

Primary Key(Nr_Matricula),
Foreign Key(Nr_Matricula) References TB_Funcionario(Nr_Matricula)
);

Create Table TB_Gastos(
ID_Gastos Int Identity (1,1),
ID_Produto Int,
Ds_Produto Varchar(150),
Qt_Produto Int,
Vl_Unitario Numeric(10,2),
Vl_Total Numeric (10,2),
Dt_Compra Date,

Primary Key(ID_Gastos),
Foreign Key(ID_Produto) References TB_Produto(ID_Produto)
);

Create Table TB_LoginCliente(
Nr_CPF numeric(11),
Ds_Usuario Varchar(50),
Ds_Senha Varchar(15),

Primary Key(Nr_CPF),
);
