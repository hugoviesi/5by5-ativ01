use Onibus

create table Empresa
(
	Nome varchar(50) not null,
	CEP char(8) not null,
	Logradouro varchar(50) not null,
	EndNumero int not null,
	Bairro varchar(50) not null,
	Localidade varchar(50) not null,
	Numero char(12) not null,
	Tipo varchar(20) not null,
	SiteWEB varchar(50) null

	constraint pk_Nome primary key (Nome)
);

create table Logradouro
(
	CodLogradouro int not null identity(1,1),
	NomeLog varchar(50) not null,

	constraint pk_Logradouro primary key (CodLogradouro)
);

create table Itinerario
(
	CodItinerario int not null identity(1,1),
	Sentido varchar(20) not null

	constraint pk_CodItinerario primary key (CodItinerario)
);

create table SeqLogradouro
(
	CodItinerario int not null,
	CodLogradouro int not null,
	OrdemTrajeto int not null,

	constraint fk_Itinerario foreign key (CodItinerario) references Itinerario(CodItinerario),
	constraint fk_Logradouro foreign key (CodLogradouro) references Logradouro(CodLogradouro),
	constraint pk_Seq primary key (CodItinerario, CodLogradouro) 
);

create table DiasAtendidos
(
	CodDias int not null identity(1,1),
	Dia varchar(20) not null,

	constraint pk_Dias primary key (CodDias),
);

create table Linha
(
	CodLinha int not null identity(1,1),
	CodItinerario int not null,	
	LocalPartida varchar(50) not null,
	LocalChegada varchar(50) not null,
	CodDias int not null,

	constraint pk_Linha primary key (CodLinha),
	constraint fk_ItinerarioLinha foreign key (CodItinerario) references Itinerario(CodItinerario),
	constraint fk_LinhaDias foreign key (CodDias) references DiasAtendidos(CodDias)
);

create table Horarios
(
	CodDias int not null,
	Horario time not null

	constraint fk_CodDias foreign key (CodDias) references DiasAtendidos(CodDias),
	constraint pk_Horarios primary key (CodDias, Horario),
);

create table EmpresaLinha
(
	Nome varchar(50) not null,
	CodLinha int not null

	constraint fk_EmpresaLinha foreign key (Nome) references Empresa(Nome),
	constraint fk_LinhaEmpresa foreign key (CodLinha) references Linha(CodLinha)
);

insert into Empresa values ('Transmarsico', '1594180', 'Rua Dr Dacer Pala', 48, 'Laranjeiras 2', 'Taquaritinga', '16988217338', 'Celular', 'transmarsico.com.br')
insert into Empresa values ('Lira Bus', '1590000', 'Av Tirso Micalli', 48, 'Centro', 'Taquaritinga', '32526587', 'Fixo', 'lirabus.com.br')
insert into Empresa values ('Empresa Cruz', '1590001', 'Av. Nelson Rubens', 12, 'Centro', 'Taquaritinga', '32531332', 'Fixo', 'nelsonrubens.com.br')
select * from Empresa

insert into Logradouro values ('Rua dos Bandeirantes')
insert into Logradouro values ('Rua Hugo')
insert into Logradouro values ('Av José Ziliolli')
insert into Logradouro values ('Rua dos Cabritos')
insert into Logradouro values ('Rua Irwing')
insert into Logradouro values ('Av Jacque')
select * from Logradouro

insert into Itinerario values ('Circular')
insert into Itinerario values ('Pulando')
insert into Itinerario values ('Girando')
insert into Itinerario values ('Ida')
insert into Itinerario values ('Volta')
select * from Itinerario

-- Sequencia Logradouro (CodItinerario, CodLogradouro, OrdemTrajeto)
insert into SeqLogradouro values (1, 1, 1)
insert into SeqLogradouro values (1, 2, 2)
insert into SeqLogradouro values (1, 3, 3)
insert into SeqLogradouro values (1, 4, 4)
insert into SeqLogradouro values (1, 5, 5)
insert into SeqLogradouro values (1, 6, 6)
select * from SeqLogradouro

-- Linha (CodLinha, CodItinerario, LocalPartida, LocalChegada, CodDias)
insert into Linha values (4, 'Rua dos Bandeirantes', 'Rua dos Cabritos', 1)
insert into Linha values (1, 'Praça da Sé', 'Metrô do Morumbi', 1)
insert into Linha values (5, 'Av José Ziliolli', 'Av Jacque', 1)
select * from Linha

insert into DiasAtendidos values ('Dias Úteis')
insert into DiasAtendidos values ('Sábado')
insert into DiasAtendidos values ('Domingo')
insert into DiasAtendidos values ('Feriado')
select * from DiasAtendidos

insert into Horarios values (1, '6:00')
insert into Horarios values (1, '6:30')
insert into Horarios values (1, '6:45')
insert into Horarios values (1, '7:00')
insert into Horarios values (1, '7:10')
insert into Horarios values (1, '12:00')
insert into Horarios values (1, '16:00')
insert into Horarios values (2, '8:00')
insert into Horarios values (2, '12:00')
insert into Horarios values (3, '00:01')
insert into Horarios values (4, '7:00')
insert into Horarios values (4, '9:00')
insert into Horarios values (4, '13:00')
select * from Horarios

-- EmpresaLinha(Nome, CodLinha)
insert into EmpresaLinha values ('Transmarsico', 1)
insert into EmpresaLinha values ('Transmarsico', 2) 
insert into EmpresaLinha values ('Lira Bus', 2) 
insert into EmpresaLinha values ('Empresa Cruz', 4) 
select * from EmpresaLinha

-- Item a) Select: Empresa / Linha
SELECT E.Nome AS "Empresa", L.CodLinha AS "Linha"
FROM EmpresaLinha EL 
JOIN Empresa E ON E.Nome = EL.Nome 
JOIN Linha L ON EL.CodLinha = L.CodLinha;

-- Item b) Mostrar o Itinerário pelo Código da Linha
select * from Linha

-- Item c) Select: Dias Atendidos / Horário de Saída
select D.Dia as "Dias Atendidos", H.Horario as "Horário de saída" 
from DiasAtendidos D
JOIN Horarios H on D.CodDias = H.CodDias
where D.Dia = 'Dias Úteis'

select D.Dia as "Dias Atendidos", H.Horario as "Horário de saída" 
from DiasAtendidos D
JOIN Horarios H on D.CodDias = H.CodDias
where D.Dia = 'Sábado'

select D.Dia as "Dias Atendidos", H.Horario as "Horário de saída" 
from DiasAtendidos D
JOIN Horarios H on D.CodDias = H.CodDias
where D.Dia = 'Domingo'

select D.Dia as "Dias Atendidos", H.Horario as "Horário de saída" 
from DiasAtendidos D
JOIN Horarios H on D.CodDias = H.CodDias
where D.Dia = 'Feriado'

-- Item d) Obter os logradouros a partir do CodLinha
select * from Linha

select E.Nome as "Empresa", L.CodLinha as "Linha", LG.NomeLog as "Logradouro"
from Linha L
JOIN Itinerario I ON I.CodItinerario = L.CodItinerario
JOIN SeqLogradouro SL ON I.CodItinerario = SL.CodItinerario
JOIN Logradouro LG ON LG.CodLogradouro = SL.CodLogradouro
JOIN EmpresaLinha EL on EL.CodLinha = L.CodLinha
JOIN Empresa E ON E.Nome = EL.Nome
WHERE LG.NomeLog like 'Av Jacque' AND LG.CodLogradouro = 6;