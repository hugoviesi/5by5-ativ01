use OnibusPadronizado;

create table Endereco
(
	IDEndereco int not null identity(1,1),
	Logradouro varchar(50) not null,
	Localidade varchar(50) not null,
	CEP varchar(8) not null,
	Bairro varchar(50) not null,
	UF varchar(2) not null

	constraint pk_IDEndereco primary key (IDEndereco)
);

create table Empresa
(
	CNPJ varchar(14) not null,
	Nome varchar(50) not null,
	EnderecoWEB varchar(50) not null,
	IDEndereco int not null,
	Numero int not null,
	Complemento varchar(50)

	constraint pk_CNPJ primary key (CNPJ),
	constraint fk_IDEndereco foreign key (IDEndereco) references Endereco(IDEndereco)
);

create table Telefone
(
	CNPJ varchar(14) not null,
	Numero varchar(12) not null,
	Tipo varchar(20) not null

	constraint pk_Numero primary key (Numero),
	constraint fk_CNPJ foreign key (CNPJ) references Empresa(CNPJ)
);

create table QuadroHorario
(
	IDQuadroHorario int not null

	constraint pk_IDQuadroHorario primary key (IDQuadroHorario),
);

create table Linha
(
	IDLinha int not null identity(1,1),
	Nome varchar(50) not null,
	IDQuadroHorario int not null

	constraint pk_IDLinha primary key (IDLinha),
	constraint u_Nome unique (Nome),
	constraint fk_IDQuadroHorario foreign key (IDQuadroHorario) references QuadroHorario(IDQuadroHorario)
);

create table EmpresaLinha
(
	CNPJ varchar(14) not null,
	IDLinha int not null

	constraint pk_IDLinhaCNPJ primary key (IDLinha, CNPJ),
	constraint fk_CNPJLinha foreign key (CNPJ) references Empresa(CNPJ),
	constraint fk_IDEmpresaLinha foreign key (IDLinha) references Linha(IDLinha)
);

create table Horario
(
	IDQuadroHorario int not null identity(1,1),
	Hora time not null,
	DiaSemana varchar(50) not null

	constraint pk_Horario primary key (IDQuadroHorario, Hora, DiaSemana)
	constraint fk_IDHorario foreign key (IDQuadroHorario) references QuadroHorario(IDQuadroHorario),
);

create table Logradouro
(
	IDLogradouro int not null identity(1,1),
	NomeLog varchar(50) not null

	constraint pk_IDLogradouro primary key (IDLogradouro),
	constraint u_NomeLog unique (NomeLog)
);

create table LinhaLogradouro
(
	IDLinha int not null,
	IDLogradouro int not null,
	Sequencia int not null,
	Sentido varchar(50) not null

	constraint fk_IDLinhaLog foreign key (IDLinha) references Linha(IDLinha),
	constraint fk_IDLogradouro foreign key (IDLogradouro) references Logradouro(IDLogradouro),
	constraint pk_LinhaLogradouro primary key (IDLinha, IDLogradouro, Sequencia)
);

insert into Endereco values ('Rua Jacque', 'Araraquara', '12345678', 'Santa Efigênia', 'SP')
insert into Endereco values ('Rua Hugo', 'Taquaritinga', '87654321', 'Bastião Don Pedro II', 'SP')
insert into Endereco values ('Rua Dr Dacer Pala', 'Taquaritinga', '15904180', 'Laranjeiras 2', 'SP')
insert into Endereco values ('Av Jose Ziliolli', 'Araraquara', '15304560', 'Vila Sedenho', 'SP') 
insert into Endereco values ('Rua Rio Branco', 'Ibitinga', '1494000', 'Vila Santa Tereza', 'SP')
insert into Endereco values ('Av 13 de Maio', 'Taquaritinga', '15900000', 'Centro', 'SP')
insert into Endereco values ('Rua Ademar Pereira de Barros', 'Araraquara', '80804040', 'Vila Melhado', 'SP')
insert into Endereco values ('Av José Tiradentes', 'Taquaritinga', '40301020', 'Centro', 'SP')
select * from Endereco

insert into Empresa values ('12334500011234', 'Empresa Cruz', 'empresacruz.com.br', 1, 13, 'Triplex')
insert into Empresa values ('10101010101010', 'Lira Bus', 'lirabus.com.br', 2, 17, 'Prédio')
insert into Empresa values ('10203040607080', 'Paraty', 'paraty.com.br', 3, 20, 'Sobrado')
insert into Empresa values ('90897636251734', 'Cometa', 'cometa.com.br', 4, 10, 'Casa')
insert into Empresa values ('11111111111111', 'Transmarsico', 'transmarsico.com.br', 6, 80, 'Edícula')
insert into Empresa values ('22222222222222', 'Reunidas', 'reunidas.com.br', 7, 12, 'Prédio')
select * from Empresa

insert into Telefone values ('10101010101010', '32526578', 'Fixo')
insert into Telefone values ('12334500011234', '16988217338', 'Celular')
insert into Telefone values ('10203040607080', '32547185', 'Fixo')
insert into Telefone values ('90897636251734', '16981480664', 'Celular')
insert into Telefone values ('11111111111111', '32541338', 'Fixo')
insert into Telefone values ('22222222222222', '16988228833', 'Celular')
select * from Telefone

insert into QuadroHorario values (1)
insert into QuadroHorario values (2)
insert into QuadroHorario values (3)
insert into QuadroHorario values (4)
insert into QuadroHorario values (5)
insert into QuadroHorario values (6)
select * from QuadroHorario

insert into Linha values ('Praça da Sé', 1)
insert into Linha values ('Metro do Morumbi', 2)
insert into Linha values ('Av Time Square', 3)
insert into Linha values ('Metro do Pacaembu', 4)
insert into Linha values ('Praça do Colesterol', 5)
insert into Linha values ('Praça da Matriz', 6)
select * from Linha

insert into EmpresaLinha values ('12334500011234' , 1)
insert into EmpresaLinha values ('10101010101010' , 2)
insert into EmpresaLinha values ('10203040607080' , 3)
insert into EmpresaLinha values ('90897636251734' , 4)
insert into EmpresaLinha values ('11111111111111' , 5)
insert into EmpresaLinha values ('22222222222222' , 6)
select * from EmpresaLinha

insert into Horario values ('11:00', 'Dias Úteis')
insert into Horario values ('8:00', 'Sábado')
insert into Horario values ('9:00', 'Domingo')
insert into Horario values ('12:00', 'Feriado')
select * from Horario

insert into Logradouro values ('Rua Tonhao Borracharia')
insert into Logradouro values ('Rua Toninho do Atacado')
insert into Logradouro values ('Rua Tarzan')
insert into Logradouro values ('Rua Gerson Pizzas')
insert into Logradouro values ('Rua Frederico Cabeleireiro')
insert into Logradouro values ('Rua Neide Manicure')
select * from Logradouro

insert into LinhaLogradouro values (1, 1, 1, 'Ida')
insert into LinhaLogradouro values (2, 2, 3, 'Volta')
insert into LinhaLogradouro values (3, 3, 2, 'Ida')
insert into LinhaLogradouro values (4, 4, 4, 'Volta')
insert into LinhaLogradouro values (5, 5, 5, 'Ida')
insert into LinhaLogradouro values (6, 6, 6, 'Volta')
select * from LinhaLogradouro

-- ITEM A: TABELA NOME E CNPJ DA EMPRESA E O ID DA LINHA
SELECT E.Nome AS "Empresa", E.CNPJ AS "CNPJ", L.IDLinha AS "Linha"
FROM EmpresaLinha EL
JOIN Empresa E ON E.CNPJ = EL.CNPJ
JOIN Linha L ON L.IdLinha = EL.IdLinha
WHERE E.Nome like 'Empresa Cruz' -- Digitar o nome da empresa específica
ORDER BY L.IdLinha

-- Não específico
SELECT E.Nome AS "Empresa", E.CNPJ AS "CNPJ", L.IDLinha AS "Linha"
FROM EmpresaLinha EL
JOIN Empresa E ON E.CNPJ = EL.CNPJ
JOIN Linha L ON L.IdLinha = EL.IdLinha
ORDER BY L.IdLinha

-- ITEM B: TABELA COM NOME DA LINHA, ID E NOME DO LOGRADOURO
SELECT L.Nome AS "Nome da Linha", LO.IDLogradouro AS "ID do Logradouro", LO.NomeLog AS "Nome do Logradouro"
FROM LinhaLogradouro LG
JOIN Linha L ON L.IDLinha = LG.IDLinha
JOIN Logradouro LO ON LO.IDLogradouro = LG.IDLogradouro
WHERE L.Nome like 'Metro do Morumbi' -- Digitar o nome da linha específica
ORDER BY LG.IDLogradouro

-- Não específico:
SELECT L.Nome AS "Nome da Linha", LO.IDLogradouro AS "Logradouro", LO.NomeLog AS "Nome do Logradouro"
FROM LinhaLogradouro LG
JOIN Linha L ON L.IDLinha = LG.IDLinha
JOIN Logradouro LO ON LO.IDLogradouro = LG.IDLogradouro
ORDER BY LG.IDLogradouro

-- ITEM C: TABELA COM NOME, HORÁRIO E O PERÍODO DA LINHA
SELECT L.Nome AS "Nome da Linha", H.Hora AS "Horário", H.DiaSemana AS "Período"
FROM QuadroHorario QH
JOIN Linha L ON L.IDLinha = QH.IDQuadroHorario
JOIN Horario H ON H.IDQuadroHorario = QH.IDQuadroHorario
WHERE L.Nome like 'Praça da Sé' -- Digitar o nome da linha específica
ORDER BY H.Hora

-- Não específico
SELECT L.Nome AS "Nome da Linha", H.Hora AS "Horário", H.DiaSemana AS "Período"
FROM QuadroHorario QH
JOIN Linha L ON L.IDLinha = QH.IDQuadroHorario
JOIN Horario H ON H.IDQuadroHorario = QH.IDQuadroHorario
ORDER BY H.Hora

-- ITEM D: TABELA COM NOME E SENTIDO DA LINHA E NOME DO LOGRADOURO
SELECT L.Nome AS "Nome da Linha", LO.NomeLog AS "Logradouro", LG.Sentido AS "Sentido"
FROM LinhaLogradouro LG
JOIN Linha L ON L.IDLinha = LG.IDLinha
JOIN Logradouro LO ON LO.IDLogradouro = LG.IDLogradouro
WHERE LO.NomeLog like 'Rua Neide Manicure' -- Digitar o nome do logradouro específico
ORDER BY L.Nome

-- Não específico
SELECT L.Nome AS "Nome da Linha", LO.NomeLog AS "Logradouro", LG.Sentido AS "Sentido"
FROM LinhaLogradouro LG
JOIN Linha L ON L.IDLinha = LG.IDLinha
JOIN Logradouro LO ON LO.IDLogradouro = LG.IDLogradouro
ORDER BY L.Nome