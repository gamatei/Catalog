create table Functie
(
    ID int identity(1, 1) not null,
    Descriere varchar(20),
    primary key (ID)
)

create table Utilizator
(
    ID int identity(1, 1) not null,
    Username varchar(50) not null,
    Parola varchar(255) not null,
    IDFunctie int not null,
    Email varchar(50) not null,
    Prenume varchar(30) not null,
    Nume varchar(30) not null,
    ContActiv bit not null,
    IDElev int,
    primary key (ID),
    foreign key (IDFunctie) references Functie (ID)
)

create table UtilizatorAsteptare
(
    ID int identity(1, 1) not null,
    IDUtilizator int not null,
    [Hash] varchar(255) not null,
    primary key (ID),
    foreign key (IDUtilizator) references Utilizator (ID)
)

create table Profesor
(
    ID int identity(1, 1) not null,
    IDUtilizator int not null,
    Detalii varchar(50),
    IDMaterie int not null,
    primary key (ID),
    foreign key (IDUtilizator) references Utilizator (ID)
)

create table Elev
(
    ID int identity(1, 1) not null,
    IDUtilizator int not null,
    IDClasa int not null,
    primary key (ID),
    foreign key (IDUtilizator) references Utilizator (ID)
)

create table Clasa
(
    ID int identity(1, 1) not null,
    Nume varchar(15) not null,
    IDDiriginte int not null,
    primary key (ID),
    foreign key (IDDiriginte) references Profesor (ID)
)

create table Nota
(
    ID int identity(1, 1) not null,
    IDElev int not null,
    IDMaterieClasa int not null,
    Nota int,
    DataNota datetime not null,
    primary key (ID),
    foreign key (IDElev) references Elev (ID)
)

create table Absenta
(
    ID int identity(1, 1) not null,
    IDElev int not null,
    IDMaterieClasa int not null,
    DataAbsenta datetime not null,
    primary key (ID),
    foreign key (IDElev) references Elev (ID)
)

create table Materie
(
    ID int identity(1, 1) not null,
    Nume varchar(20) not null,
    primary key (ID)
)

create table MaterieClasa
(
    ID int identity(1, 1) not null,
    IDClasa int not null,
    IDMaterie int not null,
    OreSaptamanal int,
    IDProfesor int,
    primary key (ID),
    foreign key (IDMaterie) references Materie (ID),
    foreign key (IDClasa) references Clasa (ID),
    foreign key (IDProfesor) references Profesor (ID)
)

alter table Utilizator add foreign key (IDElev) references Elev (ID)

alter table Elev add foreign key (IDClasa) references Clasa (ID)

alter table Nota
add
foreign key (IDMaterieClasa) references MaterieClasa (ID)

alter table Absenta
add
foreign key (IDMaterieClasa) references MaterieClasa (ID)

alter table Materie alter column Nume varchar(40) not null
