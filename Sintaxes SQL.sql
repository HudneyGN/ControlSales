use bdvendas;

select * from tb_funcionarios;

select * from tb_fornecedores;

select *  from tb_produtos;

desc tb_produtos;

desc tb_vendas;

select * from tb_vendas;

select * from tb_vendas as v
join tb_clientes as c on (v.cliente_id = c.id);

select v.id as 'Código',
	   v.data_venda as 'Data da Venda',
	   c.nome as 'Cliente',
	   v.total_venda as 'Total',
	   v.observacoes as 'obs'
from tb_vendas as v
join tb_clientes as c on (v.cliente_id = c.id)
where v.data_venda between '2024-06-10' and '2024-06-17';

select * from tb_clientes;

select * from tb_itensvendas;

select id as Código from tb_vendas;

insert into tb_clientes (id, nome,rg,cpf,email,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
                                values (100,'Jonathas', 2345678987, 1345678956, 'john@yahoo.com.br', 2433455567, 2499726899,
                                23970000, 'Rua Presidente Tancredo Neves', 34, 'mercado da cuidade', 'mangueira', 'Paraty' 'RJ');
select  p.id as 'Código', 
		p.descricao as 'Descrição',
        p.preco as 'Preço',
        p.qtd_estoque as 'Estoque',
        f.nome as 'Fornecedor'
		from tb_produtos as p
	join tb_fornecedores as f on (p.for_id = f.id);
    
    show tables;
    desc tb_itensvendas;
    
    drop TABLE tb_itensvendas;
    
    insert into tb_itensvendas (venda_id, produto_id, qtd, subtotal)
	values (4, 7, 1, 3.50);
    
    desc tb_produtos;
    
select i.id as 'Código',
		p.descricao as 'Descrição',
		i.qtd as 'Quantidade',
		p.preco as 'Preço', 
		i.subtotal as 'Sub Total'
from tb_itensvendas as i
join tb_produtos as p 
on (i.produto_id = p.id)
where venda_id = 80;

select * from tb_funcionarios
where nome = 'Hudney Gomes Nunes' or email = 'hudney@gmail.com' and senha = 123;    

desc tb_funcionarios;

insert into tb_funcionarios (nome,rg,cpf,email,senha,cargo,nivel_acesso,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado) 
values ('Jonathas Oliveira Nunes','33.333.333-3','345.554.545-54','jonathason@gmail.com','123','gerente','Usuario','(11)9999-0000','(11)9 9999-0000','23970-000','Rua das flores',444 ,' ','Mangueira','Paraty','RJ');
    