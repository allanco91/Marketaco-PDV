-- Tabela: PedidoPagamento;
CREATE TABLE "PedidoPagamento" (
    "PedidoPagamentoID" serial NOT NULL,
    "Data" timestamp without time zone NOT NULL,
    "Valor" money NOT NULL,
    "FormaPagamentoID" integer NOT NULL,
    "PedidoID" integer
);

-- PKEY: PedidoPagamento > PedidoPagamentoID
ALTER TABLE ONLY "PedidoPagamento"
    ADD CONSTRAINT "PedidoPagamento_pkey" PRIMARY KEY ("PedidoPagamentoID");

--FKEY: PedidoPagamento.PedidoID > Pedido.PedidoID
ALTER TABLE ONLY "PedidoPagamento"
    ADD CONSTRAINT "FK_PedidoPagamento_Pedido" FOREIGN KEY ("PedidoID") REFERENCES "Pedido"("PedidoID");

--FKEY: PedidoPagamento.FormaPagamentoID > FormaPagamento.FormaPagamentoID
ALTER TABLE ONLY "PedidoPagamento"
    ADD CONSTRAINT "FK_PedidoPagamento_FormaPagamento" FOREIGN KEY ("FormaPagamentoID") REFERENCES "FormaPagamento"("FormaPagamentoID");