-- Adiciona as colunas novas (SubTotal, TaxaS, VlTaxaS)
ALTER TABLE public."Pedido"
    ADD COLUMN "SubTotal" money;

ALTER TABLE public."Pedido"
    ADD COLUMN "TaxaS" boolean;

ALTER TABLE public."Pedido"
    ADD COLUMN "VlTaxaS" money;

-- Elimina os valores NULL das coluna (SubTotal, TaxaS, VlTaxaS)
UPDATE public."Pedido" p SET "SubTotal" = p."ValorTotal", "TaxaS" = false, "VlTaxaS" = 0 WHERE p."VlTaxaS" IS NULL OR p."VlTaxaS" = '';