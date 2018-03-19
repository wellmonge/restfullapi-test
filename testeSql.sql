create table client (
	client_id numeric,
	client_name varchar,
	client_desc varchar,
	cpf varchar
)

create table product (
	product_id numeric,
	product_name varchar,
	product_desc varchar,
	unit_price decimal
)

create table productOrder (
	client_id numeric,
	product_id numeric,
	order_price decimal,
)

----###############

INSERT INTO client VALUES
(2, 'Michael', 'Blythe',''),
(3, 'Linda', 'Mitchell',''),
(4, 'Jillian', 'Carson',''),
(5, 'Garrett', 'Vargas','');

INSERT INTO client
VALUES ('Wellinton Monge', 'Cliente de desenvolvimento.','dsads');

--insert into client ( client_name, client_desc, cpf) values ();

select client_id, client_name, client_desc, cpf from client;