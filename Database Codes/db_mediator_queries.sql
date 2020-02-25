SELECT TOP (1000) [id_beneficiaire]
      ,[noms]
      ,[Type_AGR]
      ,[AGR]
      ,[ADRESSE2]
      ,[CODE DISTRTIBUTION]
      ,[EXECUTANT]
      ,[PROJET]
  FROM [db_foncier].[dbo].['Beneficiaires HIA$']

insert into t_agr
    (id_agr,description_agr,id_categorie)
select 
    distinct AGR,'to be completed',Type_AGR from [db_foncier].[dbo].['Beneficiaires HIA$']

insert into t_distribution
    (code_distribution,id_localite,id_projet,id_agr,id_executant)
select CODE_DISTRIBUTION, ADRESSE2, PROJET, AGR, EXECUTANT from TEMPO_BENEF

insert into t_localite
    (id_localite, descr_localite ,id_groupement)
select distinct ADRESSE2, 'To be completed', 'Bashali Mukoto' from TEMPO_BENEF
    where
        ADRESSE2 not in (select id_localite from t_localite)

select * from t_distribution

select * from t_assignation_beneficiaires

insert into t_assignation_beneficiaires
