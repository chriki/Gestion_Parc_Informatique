create database ParcInformatique 
use ParcInformatique
-- creation table Type Materiel
		create table TypeMateriel
		(
		CodeTypeMateriel varchar (6) primary key,
		TypeMatereil varchar(60)not null
		)
		select *from TypeMateriel
-- creation table Materiel
		create table Materiele
		(
		CodeONEE varchar(60)primary key ,
		CodeTypeMateriel varchar(6)foreign key references TypeMateriel(CodeTypeMateriel),
		Marque varchar(60)not null,
		Modelle varchar(60) not null,
		NumeroSerie varchar(60)not null,
		Recouvrement char (3)not null,
		GestionExperientielle char (3)not null,
		gestionAbonnes char(3) not null ,
		Utilisation varchar (60) not null
		)

	  
-- creation table Utilisateur 
		create table Utilisateur
		(
		Matricule int primary key ,
		CodEntite int foreign key references Entite(CodEntite),
		Nom varchar(60) not null,
		Prenom varchar(60)
		)
	     select *from Utilisateur
		 delete from Utilisateur
-- creation table Entite
		create table Entite
		(
		CodEntite int identity(1,1) primary key,
		Entite varchar(60) not null
		)

-- creation table Utilisateur & Materiel
		create table Utili_Materil_Entite
		(
		Matricule int foreign key references Utilisateur(Matricule),
		CodeONEE varchar(60)foreign key references Materiele(CodeONEE),
		constraint pk_Utili_Materil_Entite
		primary key (Matricule,CodeONEE)
		)
		
-- creation table Service & Centre
		create table Service_Centre
		(
		CodeServiceCentre int identity(1,1) primary key ,
		ServiceCentre varchar(60) not null,
		M2t char(3) 
		)

		
-- creation table Utilisateur & Service/Centre
create table Utilisateur_ServiceCentre
(
Matricule int foreign key references Utilisateur(Matricule),
CodeServiceCentre int foreign key references Service_Centre(CodeServiceCentre),
constraint Utilisateur_Service
		primary key (Matricule,CodeServiceCentre)
)
		
		select *from Utilisateur_ServiceCentre
		delete  from Utilisateur_ServiceCentre
		-----
		select *from TypeMateriel
		delete  from TypeMateriel
		-----
		select *from Materiele
		delete  from Materiele
        -----
        select *from Service_Centre
        delete  from Service_Centre
        -----
        select *from Entite
		delete  from Entite
		-----
		select *from Utilisateur
		delete  from Utilisateur