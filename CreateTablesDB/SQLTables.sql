CREATE TABLE InfoBasica
(
	infoID int IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	nome varchar(50) NOT NULL,
	cadastro bigint NOT NULL,
	email varchar(50) NOT NULL,
	telefone bigint NOT NULL,
	funcao int NOT NULL
)

CREATE TABLE Fornecedor
(
	infoID int PRIMARY KEY FOREIGN KEY REFERENCES dbo.InfoBasica(infoID),
	senha varchar(32) NOT NULL
)

CREATE TABLE Gerente
(
	infoID int PRIMARY KEY FOREIGN KEY REFERENCES dbo.InfoBasica(infoID),
	senha varchar(32) NOT NULL
)

CREATE TABLE Carrinho
(
	carrinhoID int IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	preco_total float NOT NULL,
	infoID int NOT NULL
)

CREATE TABLE Cliente
(
	infoID int PRIMARY KEY FOREIGN KEY REFERENCES dbo.InfoBasica(infoID),
	facial_data varchar(50) NOT NULL,
	endereco_cobranca varchar(150) NOT NULL,
	nro_cartao_de_credito bigint NOT NULL,
	carrinhoID int NOT NULL FOREIGN KEY REFERENCES dbo.Carrinho(carrinhoID),
	onStore bit NOT NULL
)

CREATE TABLE Produto
(
	productID int IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	nome varchar(50) NOT NULL,
	preco float NOT NULL,
	fornecedorID int NOT NULL FOREIGN KEY REFERENCES dbo.Fornecedor(infoID),
	quantidade int NOT NULL,
	prateleira int NOT NULL,
	validade date NOT NULL
)

CREATE TABLE Sacola
(
	sacolaID int IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	carrinhoID int NOT NULL FOREIGN KEY REFERENCES dbo.Carrinho(carrinhoID),
	productID int NOT NULL FOREIGN KEY REFERENCES dbo.Produto(productID),
	quantidade int NOT NULL,
)

CREATE TABLE Oferta
(
	productID int PRIMARY KEY FOREIGN KEY REFERENCES dbo.Produto(productID),
	desconto float,
	duracao date
)

CREATE TABLE Venda
(
	carrinhoID int PRIMARY KEY FOREIGN KEY REFERENCES dbo.Carrinho(carrinhoID),
	nota_fiscal bigint NOT NULL
)