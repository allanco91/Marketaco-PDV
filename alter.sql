-- Adiciona duas novas colunas (Troco e ValorPago)
ALTER TABLE public."Pedido"
    ADD COLUMN "Troco" money;

ALTER TABLE public."Pedido"
    ADD COLUMN "ValorPago" money;

-- Adiciona uma nova coluna (PedidoID) e uma FOREIGN KEY (PedidoID => Pedido.PedidoID)
ALTER TABLE public."LancamentoCaixa"
    ADD COLUMN "PedidoID" integer;
ALTER TABLE public."LancamentoCaixa"
    ADD CONSTRAINT "FK_LancamentoCaixa_Pedido" FOREIGN KEY ("PedidoID")
    REFERENCES public."Pedido" ("PedidoID") MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE NO ACTION;

-- Insere os valores na nova coluna (PedidoID) de acordo com o número do pedido, criando um relacionamento
UPDATE public."LancamentoCaixa" lc
SET ("PedidoID") = (CAST(TRIM(LEADING 'Pedido ' FROM lc."Descricao") AS INTEGER))
WHERE "Descricao" LIKE 'Pedido%'

-- Elimina os valores NULL da coluna (Troco) e (ValorPago)
UPDATE public."Pedido" p
		SET "Troco" = 0, "ValorPago" = p."ValorTotal"
    WHERE p."Troco" IS NULL OR p."Troco" = ''
