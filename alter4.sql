ALTER TABLE "Caixa" DROP COLUMN "V_Alimentacao";
UPDATE "FormaPagamento" SET "Nome" = 'Saldo Inicial' WHERE "FormaPagamentoID" = 5;

ALTER TABLE "Produto" DROP COLUMN "Estoque";
ALTER TABLE "Produto" DROP COLUMN "EstoqueMinimo";
ALTER TABLE "Produto" DROP COLUMN "EstoqueAtual";