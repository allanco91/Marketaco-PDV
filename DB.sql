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
    "V_Alimentacao" money NOT NULL,
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
    "Desconto" money,
    "Ordem" integer
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
    "ValorTotal" money NOT NULL,
    "NumPessoas" integer NOT NULL,
    "Status" boolean NOT NULL,
    "Viagem" boolean,
    "Troco" money,
    "ValorPago" money
);

-- Tabela: Produto;
CREATE TABLE "Produto" (
    "ProdutoID" serial NOT NULL,
    "Codigo" character varying(13),
    "Nome" character varying(50),
    "PrecoCusto" money,
    "PrecoVenda" money,
    "Estoque" boolean NOT NULL,
    "EstoqueMinimo" integer NOT NULL,
    "EstoqueAtual" integer NOT NULL,
    "UnidadeComID" integer NOT NULL,
    "CategoriaID" integer NOT NULL
);

-- Tabela: UnidadeCom;
CREATE TABLE "UnidadeCom" (
    "UnidadeComID" serial NOT NULL,
    "Nome" character varying(25),
    "Sigla" character varying(6)
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

-- INSERT Campos Pré-definidos

-- INSERT Tabela FormaPagamento
INSERT INTO public."FormaPagamento"("FormaPagamentoID", "Nome") VALUES (1, 'Dinheiro');
INSERT INTO public."FormaPagamento"("FormaPagamentoID", "Nome") VALUES (2, 'Cartão-Débito');
INSERT INTO public."FormaPagamento"("FormaPagamentoID", "Nome") VALUES (3, 'Cartão-Crédito');
INSERT INTO public."FormaPagamento"("FormaPagamentoID", "Nome") VALUES (4, 'Cheque');
INSERT INTO public."FormaPagamento"("FormaPagamentoID", "Nome") VALUES (5, 'Vale Alimentação');
INSERT INTO public."FormaPagamento"("FormaPagamentoID", "Nome") VALUES (6, 'Saldo Inicial');

-- INSERT Tabela UnidadeCom
--INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('Unidade(s)', 'UN');
--INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('Grama(s)', 'G');
--INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('Quilograma(s)', 'KG');
--INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('Litro(s)', 'L');

--INSERT Tabela UnidadeCom -> Desiree Salgados
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('CENTO', 'CEN');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('CONJUNTO', 'CJ');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('CAIXA', 'CX');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('DUZIA', 'DUZ');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('EMBALAGEM', 'EMB');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('GRAMAS', 'G');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('JOGO', 'JG');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('QUILOGRAMA', 'KG');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('KIT', 'KIT');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('LITRO', 'L');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('MILILITRO', 'ML');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('PEÇA', 'PC');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('UNIDADE', 'UN');

--INSERT Tabela UnidadeCom -> Padrão Receita Federal 
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('AMPOLA', 'AMPOLA');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('BALDE', 'BALDE');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('BANDEJA', 'BANDEJ');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('BARRA', 'BARRA');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('BISNAGA', 'BISNAG');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('BLOCO', 'BLOCO');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('BOBINA', 'BOBINA');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('BOMBONA', 'BOMB');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('CAPSULA', 'CAPS');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('CARTELA', 'CART');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('CENTO', 'CENTO');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('CONJUNTO', 'CJ');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('CENTIMETRO', 'CM');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('CENTIMETRO QUADRADO', 'CM2');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('CAIXA', 'CX');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('CAIXA COM 2 UNIDADES', 'CX2');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('CAIXA COM 3 UNIDADES', 'CX3');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('CAIXA COM 5 UNIDADES', 'CX5');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('CAIXA COM 10 UNIDADES', 'CX10');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('CAIXA COM 15 UNIDADES', 'CX15');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('CAIXA COM 20 UNIDADES', 'CX20');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('CAIXA COM 25 UNIDADES', 'CX25');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('CAIXA COM 50 UNIDADES', 'CX50');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('CAIXA COM 100 UNIDADES', 'CX100');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('DISPLAY', 'DISP');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('DUZIA', 'DUZIA');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('EMBALAGEM', 'EMBAL');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('FARDO', 'FARDO');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('FOLHA', 'FOLHA');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('FRASCO', 'FRASCO');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('GALÃO', 'GALAO');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('GARRAFA', 'GF');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('GRAMAS', 'GRAMAS');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('JOGO', 'JOGO');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('QUILOGRAMA', 'KG');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('KIT', 'KIT');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('LATA', 'LATA');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('LITRO', 'LITRO');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('METRO', 'M');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('METRO QUADRADO', 'M2');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('METRO CÚBICO', 'M3');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('MILHEIRO', 'MILHEI');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('MILILITRO', 'ML');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('MEGAWATT HORA', 'MWH');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('PACOTE', 'PACOTE');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('PALETE', 'PALETE');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('PARES', 'PARES');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('PEÇA', 'PC');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('POTE', 'POTE');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('QUILATE', 'K');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('RESMA', 'RESMA');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('ROLO', 'ROLO');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('SACO', 'SACO');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('SACOLA', 'SACOLA');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('TAMBOR', 'TAMBOR');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('TANQUE', 'TANQUE');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('TONELADA', 'TON');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('TUBO', 'TUBO');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('UNIDADE', 'UNID');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('VASILHAME', 'VASIL');
INSERT INTO public."UnidadeCom"("Nome", "Sigla") VALUES ('VIDRO', 'VIDRO');