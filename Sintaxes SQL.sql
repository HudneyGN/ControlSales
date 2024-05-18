use bdvendas;

select * from tb_produtos;

select * from tb_fornecedores;

desc tb_produtos;

desc tb_fornecedores;

select  p.id as 'Código', 
		p.descricao as 'Descrição',
        p.preco as 'Preço',
        p.qtd_estoque as 'Estoque',
        f.nome as 'Fornecedor'
		from tb_produtos as p
	join tb_fornecedores as f on (p.for_id = f.id);