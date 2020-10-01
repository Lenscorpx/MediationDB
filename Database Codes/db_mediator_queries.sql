select * from t_agr
insert into t_agr
    (id_agr,description_agr,id_categorie)
select 
    distinct AGR,'to be completed',Type_AGR from Tempo_WOA
        where AGR not in (select id_agr from t_agr)
----- insertion des agrs collectifs
insert into t_agr
    (id_agr,description_agr,id_categorie)
select 
     distinct AGR_COLLECTIF,'to be completed','Collectif' from Tempo_WOA
    where AGR_COLLECTIF is not null and AGR_COLLECTIF not in (select id_agr from t_agr) and AGR_COLLECTIF != 'MOULIN COMMUNAUTAIRE'
go
insert into t_agr
values
    ('MOULIN COMMUNAUTAIRE', 'To be completed','Collectif')
    go
-------fin insertion
insert into t_distribution
    (code_distribution,id_localite,id_projet,id_agr,id_executant)
select CODE_DISTRIBUTION, ADRESSE2, PROJET, AGR, EXECUTANT from Tempo_WOA

insert into t_distribution
    (code_distribution,id_localite,id_projet,id_agr,id_executant)
select distinct CODE_AGR_COLLECTIF, ADRESSE2, PROJET, AGR_COLLECTIF, EXECUTANT from Tempo_WOA
    where
        CODE_AGR_COLLECTIF is not null
---------------------------------------------------------------------
insert into t_assignation_beneficiaires
insert into t_localite
    (id_localite, descr_localite ,id_groupement)
select distinct ADRESSE2, 'To be completed', 'Bashali Mukoto' from Tempo_WOA
    where
        ADRESSE2 not in (select id_localite from t_localite)

select * from t_distribution

select * from t_assignation_beneficiaires

insert into t_assignation_beneficiaires
(id_beneficiaire, code_distribution)
select id_beneficiaire, CODE_DISTRIBUTION from Tempo_WOA

insert into t_assignation_beneficiaires
(id_beneficiaire, code_distribution)
select id_beneficiaire, CODE_AGR_COLLECTIF from Tempo_WOA
    where
        CODE_AGR_COLLECTIF is not null

select * from t_beneficiaires

insert into t_beneficiaires
    (id_beneficiaire,noms,sexe,vulnerabilite,date_naissance,adresse)
select id_beneficiaire, noms, SEXE, VULNERABILITE, DATE_NAISSANCE, ADRESSE_PHYSIQUE from Tempo_WOA


