-- Cria a Database Desiree
--CREATE DATABASE "Desiree"
--    WITH 
--    OWNER = postgres
--    ENCODING = 'UTF8'
--    CONNECTION LIMIT = -1;

-- CREATE das Tabelas do Banco de dados

-- Tabela: Caixa;
CREATE TABLE "Caixa" (
    "CaixaID" serial NOT NULL,
    "Data_Abertura" timestamp without time zone NOT NULL,
    "Data_Fechamento" timestamp without time zone,
    "SaldoInicial" money NOT NULL,
    "SaldoFinal" money,
    "E_Dinheiro" money NOT NULL,
    "C_Debito" money NOT NULL,
    "C_Credito" money NOT NULL,
    "E_Cheque" money NOT NULL,
    "SaldoDinheiro" money NOT NULL,
    "S_Dinheiro" money NOT NULL,
    "S_Cheque" money NOT NULL,
    "Observacao" character varying(150),
    "Status" boolean NOT NULL
);

-- Tabela: Categoria;
CREATE TABLE "Categoria" (
    "CategoriaID" serial NOT NULL,
    "Nome" character varying(30)
);

-- Tabela: FormaPagamento;
CREATE TABLE "FormaPagamento" (
    "FormaPagamentoID" serial NOT NULL,
    "Nome" character varying(30) NOT NULL
);

-- Tabela: ItensPedido;
CREATE TABLE "ItensPedido" (
    "ItensPedidoID" serial NOT NULL,
    "Quantidade" numeric NOT NULL,
    "ValorUnitario" money NOT NULL,
    "ValorTotal" money NOT NULL,
    "Data" timestamp without time zone NOT NULL,
    "PedidoID" integer NOT NULL,
    "ProdutoID" integer NOT NULL,
    "Ordem" integer,
    "Desconto" money
);

-- Tabela: LancamentoCaixa;
CREATE TABLE "LancamentoCaixa" (
    "LancamentoCaixaID" serial NOT NULL,
    "Data" timestamp without time zone,
    "Descricao" character varying(30),
    "Entrada" money NOT NULL,
    "Saida" money NOT NULL,
    "Observacao" character varying(150),
    "Excluir" boolean NOT NULL,
    "CaixaID" integer NOT NULL,
    "FormaPagamentoID" integer NOT NULL,
    "PedidoID" integer
);

-- Tabela: Pedido;
CREATE TABLE "Pedido" (
    "PedidoID" serial NOT NULL,
    "Nome" character varying(30),
    "Data" timestamp without time zone NOT NULL,
    "SubTotal" money NOT NULL,
    "ValorTotal" money NOT NULL,
    "NumPessoas" integer NOT NULL,
    "Status" boolean NOT NULL,
    "Viagem" boolean,
    "Troco" money,
    "ValorPago" money,
    "TaxaS" boolean NOT NULL,
    "VlTaxaS" money NOT NULL
);

-- Tabela: PedidoPagamento;
CREATE TABLE "PedidoPagamento" (
    "PedidoPagamentoID" serial NOT NULL,
    "Data" timestamp without time zone NOT NULL,
    "Valor" money NOT NULL,
    "FormaPagamentoID" integer NOT NULL,
    "PedidoID" integer
);

-- Tabela: Produto;
CREATE TABLE "Produto" (
    "ProdutoID" serial NOT NULL,
    "Codigo" character varying(13),
    "Nome" character varying(41),
    "PrecoC" money,
    "PrecoV" money,
    "Vendavel" boolean,
    "ControlaEstoque" boolean NOT NULL,
    "UnidadeComID" integer NOT NULL,
    "CategoriaID" integer NOT NULL
);

-- Tabela: UnidadeCom;
CREATE TABLE "UnidadeCom" (
    "UnidadeComID" serial NOT NULL,
    "Nome" character varying(25),
    "Sigla" character varying(6)
);

-- Tabela: Estoque;
CREATE TABLE "Estoque" (
    "EstoqueID" serial NOT NULL,
    "EstoqueAtu" decimal,
    "EstoqueMin" decimal,
    "EstoqueIde" decimal,
    "ProdutoID" integer
);

-- Tabela: EstoqueEntrada; Talvez colocar valor
CREATE TABLE "EstoqueEntrada" (
    "EstoqueEntradaID" serial NOT NULL,
    "Quantidade" decimal,
    "Data" timestamp without time zone,
    "EstoqueID" integer
);

-- Tabela: EstoqueSaida;
CREATE TABLE "EstoqueSaida" (
    "EstoqueSaidaID" serial NOT NULL,
    "Quantidade" decimal,
    "Data" timestamp without time zone,
    "ValorUnitario" money,
    "Venda" boolean,
    "EstoqueID" integer
);

-- Tabela: Empresa;
CREATE TABLE "Empresa" (
	"EmpresaID" serial NOT NULL,
    "NomeFantasia" character varying(150),
	"RazaoSocial" character varying(150),
	"Endereco" character varying(150),
	"Numero" character varying(7),
	"Cidade" character varying(30),
	"UF" character varying(2),
	"Telefone1" character varying(11),
    "Telefone2" character varying(11),
	"CNPJ" character varying(14),
	"IE" character varying(30)
);

-- Tabela: Operador;
CREATE TABLE "Operador" (
	"OperadorID" serial NOT NULL,
	"Nome" character varying(50),
	"Login" character varying(20),
	"Senha" character varying(20),
	"Adm" boolean
);

-- Tabela: Logs;
CREATE TABLE "Logs" (
	"LogsID" serial NOT NULL,
	"Data" timestamp without time zone,
	"Operador" character varying(50),
    "Acao" character varying(150)
);

-- Chaves Primárias

-- PKEY: Caixa > CaixaID
ALTER TABLE ONLY "Caixa"
    ADD CONSTRAINT "Caixa_pkey" PRIMARY KEY ("CaixaID");

-- PKEY: Categoria > CategoriaID
ALTER TABLE ONLY "Categoria"
    ADD CONSTRAINT "Categoria_pkey" PRIMARY KEY ("CategoriaID");

-- PKEY: FormaPagamento > FormaPagamentoID
ALTER TABLE ONLY "FormaPagamento"
    ADD CONSTRAINT "FormaPagamento_pkey" PRIMARY KEY ("FormaPagamentoID");

-- PKEY: ItensPedido > ItensPedidoID
ALTER TABLE ONLY "ItensPedido"
    ADD CONSTRAINT "ItensPedido_pkey" PRIMARY KEY ("ItensPedidoID");

-- PKEY: LancamentoCaixa > LancamentoCaixaID
ALTER TABLE ONLY "LancamentoCaixa"
    ADD CONSTRAINT "LancamentoCaixa_pkey" PRIMARY KEY ("LancamentoCaixaID");

-- PKEY: Pedido > PedidoID
ALTER TABLE ONLY "Pedido"
    ADD CONSTRAINT "Pedido_pkey" PRIMARY KEY ("PedidoID");

-- PKEY: Produto > ProdutoID
ALTER TABLE ONLY "Produto"
    ADD CONSTRAINT "Produto_pkey" PRIMARY KEY ("ProdutoID");

-- PKEY: UnidadeCom > UnidadeComID
ALTER TABLE ONLY "UnidadeCom"
    ADD CONSTRAINT "UnidadeCom_pkey" PRIMARY KEY ("UnidadeComID");

-- PKEY: Estoque > EstoqueID
ALTER TABLE ONLY "Estoque"
    ADD CONSTRAINT "Estoque_pkey" PRIMARY KEY ("EstoqueID");

-- PKEY: EstoqueEntrada > EstoqueEntradaID
ALTER TABLE ONLY "EstoqueEntrada"
    ADD CONSTRAINT "EstoqueEntrada_pkey" PRIMARY KEY ("EstoqueEntradaID");

-- PKEY: EstoqueSaida > EstoqueSaidaID
ALTER TABLE ONLY "EstoqueSaida"
    ADD CONSTRAINT "EstoqueSaida_pkey" PRIMARY KEY ("EstoqueSaidaID");

-- PKEY: Empresa > EmpresaID
ALTER TABLE ONLY "Empresa"
    ADD CONSTRAINT "Empresa_pkey" PRIMARY KEY ("EmpresaID");

-- PKEY: Operador > OperadorID
ALTER TABLE ONLY "Operador"
	ADD CONSTRAINT "Operador_pkey" PRIMARY KEY ("OperadorID");

-- PKEY: Logs > LogsID
ALTER TABLE ONLY "Logs"
	ADD CONSTRAINT "Logs_pkey" PRIMARY KEY ("LogsID");

-- PKEY: PedidoPagamento > PedidoPagamentoID
ALTER TABLE ONLY "PedidoPagamento"
    ADD CONSTRAINT "PedidoPagamento_pkey" PRIMARY KEY ("PedidoPagamentoID");

-- Chaves Estrangeiras

--FKEY: ItensPedido.PedidoID > Pedido.PedidoID
ALTER TABLE ONLY "ItensPedido"
    ADD CONSTRAINT "FK_ItensPedido_Pedido" FOREIGN KEY ("PedidoID") REFERENCES "Pedido"("PedidoID");

--FKEY: ItensPedido.PedidoID > Produto.ProdutoID
ALTER TABLE ONLY "ItensPedido"
    ADD CONSTRAINT "FK_ItensPedido_Produto" FOREIGN KEY ("ProdutoID") REFERENCES "Produto"("ProdutoID");

--FKEY: LancamentoCaixa.CaixaID > Caixa.CaixaID
ALTER TABLE ONLY "LancamentoCaixa"
    ADD CONSTRAINT "FK_LancamentoCaixa_Caixa" FOREIGN KEY ("CaixaID") REFERENCES "Caixa"("CaixaID");

--FKEY: LancamentoCaixa.FormaPagamentoID > FormaPagamento.FormaPagamentoID
ALTER TABLE ONLY "LancamentoCaixa"
    ADD CONSTRAINT "FK_LancamentoCaixa_FormaPagamento" FOREIGN KEY ("FormaPagamentoID") REFERENCES "FormaPagamento"("FormaPagamentoID");

--FKEY: LancamentoCaixa.PedidoID > Pedido.PedidoID
ALTER TABLE ONLY "LancamentoCaixa"
    ADD CONSTRAINT "FK_LancamentoCaixa_Pedido" FOREIGN KEY ("PedidoID") REFERENCES "Pedido"("PedidoID");

--FKEY: Produto.CategoriaID > Categoria.CategoriaID
ALTER TABLE ONLY "Produto"
    ADD CONSTRAINT "FK_Produto_Categoria" FOREIGN KEY ("CategoriaID") REFERENCES "Categoria"("CategoriaID");

--FKEY: Produto.UnidadeComID > UnidadeCom.UnidadeComID
ALTER TABLE ONLY "Produto"
    ADD CONSTRAINT "FK_Produto_UnidadeCom" FOREIGN KEY ("UnidadeComID") REFERENCES "UnidadeCom"("UnidadeComID");

--FKEY: Estoque.ProdutoID > Produto.ProdutoID
ALTER TABLE ONLY "Estoque"
    ADD CONSTRAINT "FK_Estoque_Produto" FOREIGN KEY ("ProdutoID") REFERENCES "Produto"("ProdutoID");

--FKEY: EstoqueEntrada.EstoqueID > Estoque.EstoqueID
ALTER TABLE ONLY "EstoqueEntrada"
    ADD CONSTRAINT "FK_EstoqueEntrada_Estoque" FOREIGN KEY ("EstoqueID") REFERENCES "Estoque"("EstoqueID");

--FKEY: EstoqueSaida.EstoqueID > Estoque.EstoqueID
ALTER TABLE ONLY "EstoqueSaida"
    ADD CONSTRAINT "FK_EstoqueSaida_Estoque" FOREIGN KEY ("EstoqueID") REFERENCES "Estoque"("EstoqueID");

--FKEY: PedidoPagamento.PedidoID > Pedido.PedidoID
ALTER TABLE ONLY "PedidoPagamento"
    ADD CONSTRAINT "FK_PedidoPagamento_Pedido" FOREIGN KEY ("PedidoID") REFERENCES "Pedido"("PedidoID");

--FKEY: PedidoPagamento.FormaPagamentoID > FormaPagamento.FormaPagamentoID
ALTER TABLE ONLY "PedidoPagamento"
    ADD CONSTRAINT "FK_PedidoPagamento_FormaPagamento" FOREIGN KEY ("FormaPagamentoID") REFERENCES "FormaPagamento"("FormaPagamentoID");

-- INSERT Campos Pré-definidos

-- INSERT Tabela Operador > Operador administrador padrão
INSERT INTO public."Operador"("Nome", "Login", "Senha", "Adm") VALUES ('ADMINISTRADOR', 'ADM', 'ADM', true);

-- INSERT Tabela Empresa > Empresa inicial padrão
INSERT INTO public."Empresa"("EmpresaID", "NomeFantasia", "RazaoSocial", "Endereco", "Numero", "Cidade", "UF", "Telefone1", "Telefone2", "CNPJ", "IE") VALUES (1, 'Nome Fantasia', 'Razão Social', 'Endereço', '1111', 'Cidade', 'UF', '99999999999', '', '11111111111111', '111111111');

-- INSERT Tabela Categoria
-- INSERT INTO public."Categoria"("CategoriaID", "Nome") VALUES (1, 'Salgado P');

-- INSERT Tabela FormaPagamento
INSERT INTO public."FormaPagamento"("FormaPagamentoID", "Nome") VALUES (1, 'Dinheiro');
INSERT INTO public."FormaPagamento"("FormaPagamentoID", "Nome") VALUES (2, 'Cartão-Débito');
INSERT INTO public."FormaPagamento"("FormaPagamentoID", "Nome") VALUES (3, 'Cartão-Crédito');
INSERT INTO public."FormaPagamento"("FormaPagamentoID", "Nome") VALUES (4, 'Cheque');
INSERT INTO public."FormaPagamento"("FormaPagamentoID", "Nome") VALUES (5, 'Saldo Inicial');

-- INSERT Tabela UnidadeCom
--INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('Unidade(s)', 'UN');
--INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('Grama(s)', 'G');
--INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('Quilograma(s)', 'KG');
--INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('Litro(s)', 'L');

--INSERT Tabela UnidadeCom -> Desiree Salgados
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('UNIDADE', 'UN');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('CAIXA', 'CX');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('GRAMAS', 'G');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('QUILOGRAMA', 'KG');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('MILILITRO', 'ML');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('LITRO', 'L'); 