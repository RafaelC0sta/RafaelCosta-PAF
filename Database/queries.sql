-- USERS ---------------------------------------------------------------------------

create table tbl_users(
	user_id int auto_increment primary key,
    nomecompleto varchar(100) unique,
    email varchar(50) unique,
    username varchar(50) unique,
    pass varchar(50),
    nivel varchar (10)
);

create table tbl_logs (
	log_id int auto_increment primary key,
    user_fk int,
    log_data timestamp default current_timestamp,
    foreign key (user_fk) references tbl_users(user_id)
);

select * from tbl_users;


-- query para inserir novos utilizadores
insert into tbl_users (nomecompleto, email, username, pass, nivel) 
values ("Rafael Costa", "rafaelteste@gmail.com", "rafael", "1234", "admin");

insert into tbl_users (nomecompleto, email, username, pass, nivel) 
values ("Utilizador Guest", "testeGuest@gmail.com", "guest", "1234", "guest");

-- query para inserir dados nas logs quando alguem fizer login
INSERT INTO tbl_logs (user_fk) SELECT user_id FROM tbl_users WHERE username = 'guest';

-- query para ver o username nas logs
select tl.log_id, tu.username, tl.log_data from tbl_logs as tl
join tbl_users as tu
on tl.user_fk = tu.user_id
order by log_data desc;

select * from tbl_users;

-- Aeroporto ---------------------------------------------------------------------------

create table tbl_aeroportos (
	aeroporto_id int auto_increment primary key,
    aeroporto_nome varchar(50) unique,
    cidade varchar(50),
    pais varchar(50),
    imagem varchar(15)
);

create table tbl_aeronaves (
	aeronave_id int auto_increment primary key,
    modelo varchar(50) unique,
    capacidade int,
    aeroporto_fk int,
    imagem varchar(15),
    foreign key(aeroporto_fk) references tbl_aeroportos (aeroporto_id) -- vai dizer em que aeroporto existe tal aeronave
);

create table tbl_voos (
	voo_id int auto_increment primary key,
    numero_voo varchar(5) unique,
    cidade_destino varchar(25),
    aeroporto_partida int,
    aeroporto_destino int,
    data_partida date,
    data_cheagada date,
    preco_voo int,
    aeronave_fk int,
    foreign key(aeroporto_partida) references tbl_aeroportos(aeroporto_id),
    foreign key(aeroporto_destino) references tbl_aeroportos(aeroporto_id),
    foreign key(aeronave_fk) references tbl_aeronaves (aeronave_id)
); -- adicionar a cidade de destino e numero do voo: ex (F534VE)

create table tbl_reservas (
	reserva_id int auto_increment primary key,
    user_fk int,
    voo_fk int,
    numero_lugares int,
    data_reserva date,
    pagamento int, -- ver se vale a pena ter uma tabela a parte so para os pagamentos
    -- pagamento: 1 (dinheiro), 2 (cartao)
    foreign key (user_fk) references tbl_users(user_id),
    foreign key (voo_fk) references tbl_voos(voo_id)
);

create table tbl_lugares (
	lugar_id int auto_increment primary key,
    voo_fk int,
    user_fk int,
    numero_lugar varchar(2),
    estado enum('livre', 'ocupado'),
    foreign key (user_fk) references tbl_users(user_id),
    foreign key (voo_fk) references tbl_voos(voo_id)
);

create table tbl_pagamentos (
	pagamento_id int auto_increment primary key,
    reserva_fk int,
    metodo_pagamento varchar(25),
    valor int,
    data_pagamento date,
    user_fk int,
    foreign key (user_fk) references tbl_users(user_id),
    foreign key (reserva_fk) references tbl_reservas (reserva_id)
);

insert into tbl_lugares (voo_fk, numero_lugar, estado) values (1, "A1", "livre"), (1, "A2", "livre"), (1, "B1", "livre"), (1, "B2", "livre"), (1, "C1", "livre"), (1, "C2", "livre");
insert into tbl_lugares (voo_fk, numero_lugar, estado) values (2, "A1", "livre"), (2, "A2", "livre"), (2, "B1", "livre"), (2, "B2", "livre"), (2, "C1", "livre"), (2, "C2", "livre");

insert into tbl_lugares (voo_fk, numero_lugar, estado) values (6, "A1", "livre"), (6, "A2", "livre"), (6, "B1", "livre"), (6, "B2", "livre"), (6, "C1", "livre"), (6, "C2", "livre");

insert into tbl_aeroportos (aeroporto_nome, cidade, pais) values ("Humberto Delgado", "Lisboa", "Portugal"), ("Guarulhos", "Sao Paulo", "Brasil");

insert into tbl_aeronaves (modelo, capacidade, aeroporto_fk) values ("Boeing 707", 10, 1);

insert into tbl_voos (numero_voo, cidade_destino, aeroporto_partida, aeroporto_destino, data_partida, preco_voo, aeronave_fk) values ('E5F57', 'Lisboa', 2, 1, '2025-06-05', 1000, 1);

select * from tbl_voos;

select * from tbl_lugares;

-- query para ver os voos existentes
select tv.voo_id, tv.numero_voo, tv.cidade_destino, ta1.aeroporto_nome, ta2.aeroporto_nome, tv.data_partida, tv.preco_voo, tav.modelo
from tbl_voos as tv
join tbl_aeroportos as ta1 on tv.aeroporto_partida = ta1.aeroporto_id
join tbl_aeroportos as ta2 on tv.aeroporto_destino = ta2.aeroporto_id
join tbl_aeronaves as tav on tv.aeronave_fk = tav.aeronave_id;

-- query para ver aeroportos
select CONCAT(aeroporto_nome, ' - ', cidade, ', ', pais) as nome_completo
from tbl_aeroportos
order by cidade;

-- query para ver reservas 
select r.reserva_id as `ID`, 
u.nomecompleto as `Nome`, 
v.numero_voo as `Número do Voo`, 
l.numero_lugar as `Lugar`, 
r.data_reserva as `Data da Reserva`, 
r.pagamento as `Pagamento`
from tbl_reservas as r 
join tbl_users as u on r.user_fk = u.user_id 
join tbl_voos as v on r.voo_fk = v.voo_id 
join tbl_lugares as l on r.numero_lugares = l.lugar_id;


-- select r.reserva_id, u.nomecompleto, v.cidade_destino, v.data_partida, r.numero_lugares from tbl_reservas as r
-- join tbl_users as u on r.user_fk = u.user_id
-- join tbl_voos as v on r.voo_fk = v.voo_id;

-- query para inserir uma nova reserva 
insert into tbl_reservas (user_fk, voo_fk, numero_lugares, data_reserva, pagamento) values ((select user_id from tbl_users where nomecompleto='@nomeCompleto'), (select voo_id from tbl_voos where numero_voo = @numeroVoo), (select lugar_id from tbl_lugares where numero_lugar = @numeroLugar), current_date(), @metodoPagamento);

insert into tbl_pagamentos 
(reserva_fk, metodo_pagamento, valor, data_pagamento, user_fk) 
values (16, "Cartão", (select preco_voo from tbl_voos where numero_voo = "E6T92"), current_date(), (select user_id from tbl_users where nomecompleto="Lurdes dos Santos Mateus"));

select * from tbl_pagamentos;

-- query para ver pagamentos
select p.pagamento_id, v.numero_voo, p.metodo_pagamento, p.valor, data_pagamento, u.user_id from tbl_pagamentos as p
join tbl_voos as v on v.voo_id = p.pagamento_id
join tbl_users as u on u.user_id = p.pagamento_id;
