use master;
    if exists(select * from sys.databases where name='db_iris')
        drop database db_mediator;
create database db_mediator;
use db_mediator;
create table t_pays
(
    code_pays nvarchar(50),
    nom_pays_eng nvarchar(50),
    nom_pays_fr nvarchar(50),
    capitale nvarchar(50),
    constraint pk_pays primary key(code_pays)
)
go
create table t_province
(
    id_province nvarchar(50),
    descr_province nvarchar(100),
    code_pays nvarchar(50),
    constraint pk_province primary key (id_province),
    constraint fk_pays foreign key(code_pays) references t_pays(code_pays)
)
go
create table t_territoire
(
    id_territoire nvarchar(50),
    descr_territoire nvarchar(100),
    id_province nvarchar(50),
    constraint pk_territoire primary key(id_territoire),
    constraint fk_province foreign key(id_province) references t_province(id_province)
)
go
create table t_chefferie
(
    id_chefferie nvarchar(50),
    descr_chefferie nvarchar(100),
    id_territoire nvarchar(50),
    constraint pk_chefferie primary key(id_chefferie),
    constraint fk_territoire foreign key(id_territoire) references t_territoire(id_territoire)
)
go
create table t_groupement
(
    id_groupement nvarchar(50),
    descr_groupement nvarchar(100),
    id_chefferie nvarchar(50),
    constraint pk_groupement primary key(id_groupement),
    constraint fk_chefferie foreign key(id_chefferie) references t_chefferie(id_chefferie)
)
go
--------------------------Debut codes localite-----------------------------------------------------------
create table t_localite
(
    id_localite nvarchar(50),
    descr_localite nvarchar(100),
    id_groupement nvarchar(50),
    constraint pk_localite primary key(id_localite),
    constraint fk_groupement foreign key(id_groupement) references t_groupement(id_groupement)
)
go
create procedure recuperer_localite
as
    select top 50 id_localite from t_localite
    order by id_localite asc
go
create procedure search_localite
@id_localite nvarchar(50)
as
   select top 50 id_localite from t_localite
   where id_localite like '%'+@id_localite+'%'
go
----------------------------Fin codes localite----------------------------------------------------------
-----------------------------Debut codes Situation Menages-----------------------------------------------------
create table t_situation_menage
(
    id_situation nvarchar(50),
    descr_situation nvarchar(100),
    constraint pk_situation primary key(id_situation)
)
go
create procedure afficher_situation_menage
as
    select top 50 id_situation as 'Situation de menage', descr_situation as 'Description' 
    from t_situation_menage
        order by id_situation asc
go
create procedure enregistrer_situation_menage
@id_situation nvarchar(50),
@descr_situation nvarchar(100)
as
    merge into t_situation_menage
    using (select @id_situation as x_id)as x_source
    on (x_source.x_id=t_situation_menage.id_situation)
    when matched then 
       update set
            descr_situation =@descr_situation
    when not matched then
        insert
            (id_situation, descr_situation)
        values
            (@id_situation, @descr_situation);
go
create procedure supprimer_situation_menage
@id_situation nvarchar(50)
as
    delete from t_situation_menage
        where id_situation=@id_situation
go
create procedure search_situation
@id_situation nvarchar(50)
as
    select top 50 id_situation as 'Situation de menage', descr_situation as 'Description' 
    from t_situation_menage
    where id_situation like '%'+@id_situation+'%'
go

----------------------------Fin des codes Situations menages -------------------------------------------------
create table t_menages
(
    id_menage nvarchar(50),
    date_enregistrement date,
    id_situation nvarchar(50),
    constraint pk_menages primary key(id_menage),
    constraint fk_situation foreign key(id_situation) references t_situation_menage(id_situation)
)

-----------------------------Debut codes vulnerabilite ---------------------------------------
create table t_vulnerabilite
(
    id_vulnerabilite nvarchar(50),
    descr_vulnerabilite nvarchar(100),
    constraint pk_vulnerab primary key(id_vulnerabilite)
)
go
create procedure afficher_vulnerabilite
as
    select top 50 id_vulnerabilite as 'Vulnerabilite', descr_vulnerabilite as 'Description' 
    from t_vulnerabilite
        order by id_vulnerabilite asc
go
create procedure enregistrer_vulnerabilite
@id_vulnerabilite nvarchar(50),
@descr_vulnerabilite nvarchar(100)
as
    merge into t_vulnerabilite
    using (select @id_vulnerabilite as x_id) as x_source
    on (x_source.x_id=t_vulnerabilite.id_vulnerabilite)
        when matched then
            update set
                descr_vulnerabilite = @descr_vulnerabilite
        when not matched then
            insert
                (id_vulnerabilite,descr_vulnerabilite)
            values
                (@id_vulnerabilite,@descr_vulnerabilite);
go
create procedure supprimer_vulnerabilite
@id_vulnerabilite nvarchar(50)
as
    delete from t_vulnerabilite
        where id_vulnerabilite like @id_vulnerabilite
go
create procedure search_vulnerabilite
@id_vulnerabilite nvarchar(50)
as
    select top 50 id_vulnerabilite as 'Vulnerabilite', descr_vulnerabilite as 'Description' 
    from t_vulnerabilite
        where
            id_vulnerabilite like '%'+ @id_vulnerabilite + '%'
go
create procedure recuperer_vulnerabilite
as
    select id_vulnerabilite from t_vulnerabilite
    order by id_vulnerabilite asc
go
----------------------------- fin codes vulnerabilite ----------------------------------------
create table t_membres
(
    id_membre nvarchar(50),
    noms nvarchar(100),
    date_naissance date,
    etat_civil nvarchar(50),
    id_vulnerabilite nvarchar(50),
    provenance nvarchar(50),
    adresse nvarchar(100),
    num_tel nvarchar(50),
    repr_menage nvarchar(50),
    profession nvarchar(50),
    id_menage nvarchar(50),
    date_enregistrement date,
    sexe nvarchar(50),
    constraint pk_membre primary key(id_membre),
    constraint fk_vulnerab foreign key(id_vulnerabilite) references t_vulnerabilite(id_vulnerabilite),
    constraint fk_menage_membre foreign key(id_menage) references t_menages(id_menage)
 )
go
alter table t_membres
add sexe nvarchar(50)
------------- types : conflit lie aux concessions, espaces proteges, etc.....
create table t_type_conflit
(
    id_type_conflit nvarchar(50),
    descr_type_conflit nvarchar(100),
    constraint pk_type_conflit primary key(id_type_conflit)
)
go
create procedure afficher_type_conflit
as
    select top 50 id_type_conflit as 'Code Conflit', descr_type_conflit as 'Description'         
        from t_type_conflit
            order by id_type_conflit asc
go
create procedure enregistrer_type_conflit
@id_type_conflit nvarchar(50),
@descr_type_conflit nvarchar(100)
as
    merge into t_type_conflit
        using ( select @id_type_conflit as x_id) as x_source
        on (x_source.x_id=t_type_conflit.id_type_conflit)
        when matched then
            update set
                descr_type_conflit=@descr_type_conflit
        when not matched then
            insert 
                (id_type_conflit, descr_type_conflit)
            values
                (@id_type_conflit, @descr_type_conflit);
go
create procedure supprimer_type_conflit
@id_type_conflit nvarchar(50)
as
    delete from t_type_conflit
        where id_type_conflit like @id_type_conflit
go
create procedure search_type_conflit
@id_type_conflit nvarchar(50)
as
    select top 50 id_type_conflit as 'Code Conflit', descr_type_conflit as 'Description'         
        from t_type_conflit
            where id_type_conflit like '%'+@id_type_conflit+'%'
go
create procedure recuperer_type_conflit
as
    select id_type_conflit from t_type_conflit
    order by id_type_conflit asc
go

---------------- natures : individuel, collectif, communautaire, etc.....
---------------- Debut Codes Nature conflit------------------------------------------------------------
create table t_nature_conflit
(
    id_nature_conflit nvarchar(50),
    descr_nature_conflit nvarchar(100),
    constraint pk_nature_conflit primary key(id_nature_conflit)
)
go
create procedure afficher_nature_conflit
as
    select top 50 id_nature_conflit as 'Nature du conflit', descr_nature_conflit as 'Description' 
    from t_nature_conflit
        order by id_nature_conflit asc
go 
create procedure enregistrer_nature_conflit
@id_nature_conflit nvarchar(50),
@descr_nature_conflit nvarchar(100)
as
    merge into t_nature_conflit
    using (select @id_nature_conflit as x_id) as x_source
    on (x_source.x_id=t_nature_conflit.id_nature_conflit)
    when matched then
        update set 
            descr_nature_conflit=@descr_nature_conflit
    when not matched then
        insert
            (id_nature_conflit,descr_nature_conflit)
        values 
            (@id_nature_conflit,@descr_nature_conflit);
go
create procedure supprimer_nature_conflit
@id_nature_conflit nvarchar(50)
as
    delete from t_nature_conflit
        where id_nature_conflit=@id_nature_conflit
go
create procedure search_nature_conflit
@id_nature_conflit nvarchar(50)
as
    select top 50 id_nature_conflit as 'Nature de conflit', descr_nature_conflit as 'Description' 
    from t_nature_conflit
        where id_nature_conflit like '%'+@id_nature_conflit+'%'
go
create procedure recuperer_nature_conflit
as
    select id_nature_conflit from t_nature_conflit
    order by id_nature_conflit asc
go
----------------------------Fin Codes nature conflit---------------------------------------------------
----------------------------Debut codes pour conflit---------------------------------------------------
create table t_conflit
(
    num_conflit int identity,
    date_enreg date, 
    date_debut_conflit date,
    id_type_conflit nvarchar(50),
    id_nature_conflit nvarchar(50),
    id_localite nvarchar(50),
    constraint pk_conflit primary key(num_conflit),
    constraint fk_nature_conf foreign key(id_nature_conflit) references t_nature_conflit(id_nature_conflit),
    constraint fk_type_confl foreign key(id_type_conflit) references t_type_conflit(id_type_conflit),
    constraint fk_localite_conflit foreign key(id_localite) references t_localite(id_localite)
)
go
create procedure afficher_conflit
as
    select top 50 num_conflit as 'Num.', date_enreg as 'Date Enr.', date_debut_conflit as 'Debut conflit', id_type_conflit as 'Type Conflit',
                  id_nature_conflit as 'Nature conflit', id_localite as 'Lieu' from t_conflit
                  order by num_conflit desc
go
create procedure inserer_conflit
@date_debut_conflit date,
@id_type_conflit nvarchar(50),
@id_nature_conflit nvarchar(50),
@id_localite nvarchar(50)
as
    insert into t_conflit
        (date_enreg,date_debut_conflit,id_type_conflit,id_nature_conflit,id_localite)
    values
        (getDate(),@date_debut_conflit,@id_type_conflit,@id_nature_conflit,@id_localite)
go
create procedure modifier_conflit
@num_conflit int, 
@date_debut_conflit date,
@id_type_conflit nvarchar(50),
@id_nature_conflit nvarchar(50),
@id_localite nvarchar(50)
as
    update t_conflit
        set
            date_enreg=getDate(),
            date_debut_conflit=@date_debut_conflit,
            id_type_conflit=@id_type_conflit,
            id_nature_conflit=@id_nature_conflit,
            id_localite=@id_localite
        where
            num_conflit=@num_conflit
go
create procedure supprimer_conflit
@num_conflit int
as
    delete from t_conflit
        where num_conflit=@num_conflit
go
----------------------------Fin codes conflits----------------------------------------------------------
----------------------------Debut codes details conflits------------------------------------------------
create table t_details_conflits
(
    num_details_conflits int identity,
    date_enreg date,
    descript_conflit nvarchar(500),
    num_conflit int,
    constraint pk_details_conflits primary key(num_details_conflits),
    constraint fk_conflit_details foreign key(num_conflit) references t_conflit(num_conflit)
)
go
create procedure afficher_details_conflits
@num_conflit int
as
    select num_details_conflits as 'Num.', num_conflit as 'Conflit', descript_conflit as 'Details', date_enreg as 'Enreg.' 
    from t_details_conflits
    where num_conflit = @num_conflit
        order by num_details_conflits desc
go
create procedure inserer_details
@descript_conflit nvarchar(500),
@num_conflit int
as
    insert into t_details_conflits
        (date_enreg, descript_conflit, num_conflit)
    values
        (getDate(), @descript_conflit, @num_conflit)
go
create procedure modifier_details
@num_details_conflits int,
@descript_conflit nvarchar(500),
@num_conflit int
as
    update t_details_conflits
        set
            date_enreg = getDate(),
            descript_conflit=@descript_conflit,
            num_conflit=@num_conflit
    where
        num_details_conflits=@num_details_conflits
go
create procedure supprimer_details_conflits
@num_details_conflits int
as
    delete from t_details_conflits
        where num_details_conflits like @num_details_conflits
go
----------------------------Fin codes details conflits------------------------------------------------
-----------------------------Debut codes Objets Conflits----------------------------------------------------------
create table t_objets_conflits
(
    id_objets_conflits nvarchar(50),
    descr_objet_conflits nvarchar(100),
    constraint pk_objet primary key(id_objets_conflits)
)
go
create procedure afficher_objet_conflit
as
    select top 50 id_objets_conflits as 'Objet de conflit', descr_objet_conflits as 'Description' 
    from t_objets_conflits
        order by id_objets_conflits asc
go
create procedure enregistrer_objet_conflit
@id_objets_conflits nvarchar(50),
@descr_objet_conflits nvarchar(100)
as
    merge into t_objets_conflits
    using (select @id_objets_conflits as x_id) as x_source
    on (x_source.x_id=t_objets_conflits.id_objets_conflits)
    when matched then
        update set
            descr_objet_conflits=@descr_objet_conflits
    when not matched then
        insert
            (id_objets_conflits, descr_objet_conflits)
        values
            (@id_objets_conflits, @descr_objet_conflits);
go
create procedure supprimer_objet_conflit
@id_objets_conflits nvarchar(50)
as
    delete from t_objets_conflits
        where id_objets_conflits like @id_objets_conflits
go
create procedure search_objet_conflit
@id_objets_conflits nvarchar(50)
as
    select top 50 id_objets_conflits as 'Objet du conflit', descr_objet_conflits as 'Description' 
    from t_objets_conflits
    where id_objets_conflits like '%'+@id_objets_conflits+'%'
go 
-------------------------Fin Codes Objets du conflits----------------------------------------------------------
create table t_assignation_objets
(
    num_details_objet int identity,
    date_enreg date,
    id_objets_conflits nvarchar(50),
    num_conflit int,
    observation nvarchar(100),
    constraint pk_assignation_objet primary key(num_details_objet),
    constraint fk_objet_assign foreign key(id_objets_conflits) references t_objets_conflits(id_objets_conflits),
    constraint fk_conflit_obj foreign key(num_conflit) references t_conflit(num_conflit)
)
go
-----------------------------Debut code cause_conflit--------------------------------------------------
create table t_causes_conflits
(
    id_cause_conflit nvarchar(50),
    descr_causes nvarchar(100),
    constraint pk_causes primary key(id_cause_conflit)
)
go
create procedure afficher_causes_conflit
as
    select top 50 id_cause_conflit as 'ID Cause conflit', descr_causes as 'Description' 
        from t_causes_conflits
    order by id_cause_conflit asc
go
create procedure enregistrer_causes_conflit
@id_cause_conflit nvarchar(50),
@descr_causes nvarchar(100)
as
    merge into t_causes_conflits
    using (select @id_cause_conflit as x_id)as x_source
        on(x_source.x_id=t_causes_conflits.id_cause_conflit)
        when matched then
            update set
                descr_causes=@descr_causes
        when not matched then
            insert
                (id_cause_conflit,descr_causes)
            values
                (@id_cause_conflit,@descr_causes);
go
create procedure supprimer_cause_conflit
@id_cause_conflit nvarchar(50)
as
    delete from t_causes_conflits
        where id_cause_conflit like @id_cause_conflit
go
create procedure search_cause_conflit
@id_cause_conflit nvarchar(50)
as
    select top 50 id_cause_conflit as 'ID Cause conflit', descr_causes as 'Description' 
        from t_causes_conflits
    where id_cause_conflit like '%'+@id_cause_conflit+'%'
go
-----------------------------Fin code cause_conflit----------------------------------------------------
create table t_assignation_causes
(
    num_assignation_causes int identity,
    date_enreg date,
    id_cause_conflit nvarchar(50),
    num_conflit int,
    constraint pk_assign_cause primary key(num_assignation_causes),
    constraint fk_cause_assgn foreign key(id_cause_conflit) references t_causes_conflits(id_cause_conflit),
    constraint fk_conf_ass_cause foreign key(num_conflit) references t_conflit(num_conflit)
) 
go
---cette table permettra de reconnaitre quel type de menages est soit accuse ou plaignant
--------------------- Debut codes Types Parties ---------------------------------------------------------
create table t_type_parties 
(
    id_typ_partie nvarchar(50),
    descr_typ_partie nvarchar(100),
    constraint pk_type_partie primary key(id_typ_partie)
)
go
create procedure afficher_type_partie
as
    select top 50 id_typ_partie as 'Type de partie prenante', descr_typ_partie as 'Description' 
    from t_type_parties
        order by id_typ_partie asc
go
create procedure enregistrer_type_parties
@id_typ_partie nvarchar(50),
@descr_typ_partie nvarchar(100)
as
    merge into t_type_parties
    using(select @id_typ_partie as x_id)as x_source
    on(x_source.x_id=t_type_parties.id_typ_partie)
    when matched then
        update set
            descr_typ_partie = @descr_typ_partie
    when not matched then
        insert
            (id_typ_partie, descr_typ_partie)
        values
            (@id_typ_partie, @descr_typ_partie);
go
create procedure supprimer_type_partie
@id_typ_partie nvarchar(50)
as
    delete from t_type_parties
        where id_typ_partie like @id_typ_partie
go
create procedure search_type_partie
@id_typ_partie nvarchar(50)
as
    select top 50 id_typ_partie as 'Type de partie', descr_typ_partie as 'Description' 
    from t_type_parties
        where id_typ_partie like '%'+@id_typ_partie+'%'
go
---------------------- Fin Codes Types Parties ----------------------------------------------------------------
create table t_parties
(
    num_partie int identity,
    date_enreg date,
    id_typ_partie nvarchar(50),
    id_menage nvarchar(50),
    num_conflit int,
    constraint pk_partie primary key(num_partie),
    constraint fk_conflict_partie foreign key (num_conflit) references t_conflit(num_conflit),
    constraint fk_type_partie_part foreign key(id_typ_partie) references t_type_parties(id_typ_partie),
    constraint fk_menage_partie foreign key(id_menage) references t_menages(id_menage)
)
go
-------------------------Debut codes Resolutions--------------------------------------------------------
create table t_resolutions
(
    id_resolution nvarchar(50),
    descr_resolution nvarchar(100),
    constraint pk_resolution primary key(id_resolution)
)
go
create procedure afficher_resolution
as
    select top 50 id_resolution as 'Resolution', descr_resolution as 'Description' 
    from t_resolutions
        order by id_resolution asc
go
create procedure enregistrer_resolution
@id_resolution nvarchar(50),
@descr_resolution nvarchar(100)
as
    merge into t_resolutions
    using (select @id_resolution as x_id) as x_source
    on(x_source.x_id=t_resolutions.id_resolution)
    when matched then
        update set
            descr_resolution=@descr_resolution
    when not matched then
        insert
            (id_resolution,descr_resolution)
        values
            (@id_resolution,@descr_resolution);
go
create procedure supprimer_resolution
@id_resolution nvarchar(50)
as
    delete from t_resolutions
        where id_resolution=@id_resolution
go
create procedure search_resolution
@id_resolution nvarchar(50)
as
    select top 50 id_resolution as 'Resolution', descr_resolution as 'Description' 
    from t_resolutions
    where id_resolution like '%' + @id_resolution +'%'
go
create procedure recuperer_resolution
as
    select id_resolution from t_resolutions
    order by id_resolution asc
go
------------------------Fin des codes resolutions------------------------------------------------------
create table t_assignation_resolution
(
    num_assign_resol int identity,
    num_conflit int,
    id_resolution nvarchar(50),
    date_resolution date,
    commentaires nvarchar(100),
    constraint pk_assignation_resolution primary key(num_assign_resol),
    constraint fk_conflit_resol foreign key(num_conflit) references t_conflit(num_conflit),
    constraint fk_resol_assign_res foreign key(id_resolution) references t_resolutions(id_resolution)
)
go
------------------------------- Codes mediateur---------------------------------------------
create table t_mediateur
(
    id_mediateur nvarchar(50),
    descr_mediateur nvarchar(50),
    constraint pk_mediateur primary key(id_mediateur)
)
go
create procedure afficher_mediateur
as
    select top 50 id_mediateur as 'Code mediateur', descr_mediateur as 'Description' from t_mediateur
    order by id_mediateur asc
go
create procedure enregistrer_mediateur
@id_mediateur nvarchar(50),
@descr_mediateur nvarchar(100)
as
    merge into t_mediateur
        using ( select @id_mediateur as x_id) as x_source
        on (x_source.x_id=t_mediateur.id_mediateur)
        when matched then
            update set
                descr_mediateur=@descr_mediateur
        when not matched then
            insert 
                (id_mediateur, descr_mediateur)
            values
                (@id_mediateur, @descr_mediateur);
go
create procedure supprimer_mediateur
@id_mediateur nvarchar(50)
as
    delete from t_mediateur
        where 
            id_mediateur like @id_mediateur
go
create procedure search_mediateur
@id_mediateur nvarchar(50)
as
    select top 50 id_mediateur as 'Code mediateur', descr_mediateur as 'Description' 
    from t_mediateur
    where id_mediateur like '%'+@id_mediateur+'%'
go
------------------------------- Fin codes mediateur----------------------------------------
------------------------------- debut codes mediation -------------------------------------
create table t_mediation
(
    num_mediation int identity,
    date_debut_mediation date,
    num_conflit int,
    id_mediateur nvarchar(50),
    noms_mediateur nvarchar(50),
    lieu nvarchar(50),
    appreciation nvarchar(500),
    constraint pk_mediation primary key(num_mediation),
    constraint fk_mediateur_mediation foreign key(id_mediateur) references t_mediateur(id_mediateur),
    constraint fk_mediation_conflit foreign key(num_conflit) references t_conflit(num_conflit)
)
go
alter table t_mediation
add date_fin_mediation date
go
create procedure afficher_mediation
@num_conflit int
as
    select top 50 num_mediation as 'Num.', date_debut_mediation as 'Debut Mediation', num_conflit as 'Conflit',
        id_mediateur as 'Mediateur', noms_mediateur as 'Resp. Mediation', lieu as 'Lieu', appreciation as 'Commentaire', date_fin_mediation as 'Fin Mediation'
    from t_mediation
        order by num_mediation desc
go
create procedure inserer_mediation
@date_debut_mediation date,
@num_conflit int,
@id_mediateur nvarchar(50),
@noms_mediateur nvarchar(50),
@lieu nvarchar(50),
@appreciation nvarchar(500),
@date_fin_mediation date
as
    insert into t_mediation
        (date_debut_mediation, num_conflit, id_mediateur, noms_mediateur, lieu, appreciation, date_fin_mediation)
    values
        (@date_debut_mediation, @num_conflit, @id_mediateur, @noms_mediateur, @lieu, @appreciation, @date_fin_mediation)
go
create procedure modifier_mediation
@num_mediation int,
@date_debut_mediation date,
@num_conflit int,
@id_mediateur nvarchar(50),
@noms_mediateur nvarchar(50),
@lieu nvarchar(50),
@appreciation nvarchar(500),
@date_fin_mediation date
as
    update t_mediation
        set
            date_debut_mediation=@date_debut_mediation,
            num_conflit=@num_conflit,
            id_mediateur=@id_mediateur,
            noms_mediateur=@noms_mediateur,
            lieu=@lieu,
            appreciation=@appreciation,
            date_fin_mediation=@date_fin_mediation
        where
            num_mediation=@num_mediation
go
create procedure supprimer_mediation
@num_mediation int
as
    delete from t_mediation 
        where num_mediation = @num_mediation
go
------------------------------Fin codes de mediation-----------------------------------------------------------------
create table t_logs
(
    num_log int identity,
    date_log date,
    username nvarchar(50),
    mot_de_passe nvarchar(50),
    ops_done nvarchar(50),
    constraint pk_logs primary key(num_log)
)
go
create table t_sensibilisation
(
    num_sensibilisation int identity,
    date_debut date,
    date_fin date,
    id_localite nvarchar(50),
    constraint pk_sensibilisation primary key(num_sensibilisation),
    constraint fk_localite_sensibil foreign key(id_localite) references t_localite(id_localite)
)
go
create table t_atelier
(
    id_atelier nvarchar(50),
    theme_developpe nvarchar(200),
    constraint pk_atelier primary key(id_atelier)
)
go
create table t_participants
(
    id_participant nvarchar(50),
    noms nvarchar(50),
    num_phone nvarchar(50),
    sexe nvarchar(50),
    constraint pk_participant primary key(id_participant)
)
go
create table t_etat_participant ------- Etat: Rappatrie, retourne, population locale, autorite, appui technique,...
(
    id_etat_part nvarchar(50),
    descr_etat nvarchar(100),
    constraint pk_etat_part primary key(id_etat_part)
)
go
create table t_participation_atelier
(
    num_participation int identity,
    date_atelier date,
    num_sensibilisation int,
    id_participant nvarchar(50),
    id_atelier nvarchar(50),
    nom_sensibilisateur nvarchar(50),
    id_etat_part nvarchar(50), 
    constraint pk_participation_atelier primary key(num_participation),
    constraint fk_atelier_participation foreign key(id_atelier) references t_atelier(id_atelier),
    constraint fk_sensibilisation_participation foreign key(num_sensibilisation) references t_sensibilisation(num_sensibilisation),
    constraint fk_participant_part foreign key(id_participant) references t_participants(id_participant),
    constraint fk_etat_part foreign key(id_etat_part) references t_etat_participant(id_etat_part)
)
go
create table t_atelier_masse
(
    num_atelier_masse int identity,
    date_atelier date,
    num_sensibilisation int,
    nbre_hommes int,
    nbre_femmes int,
    nbre_enfants int,
    theme_developpe nvarchar(200),    
    observation nvarchar(500),
    noms_sensibilisateur nvarchar(50),
    constraint pk_atelier_masse primary key(num_atelier_masse),
    constraint fk_sensibilisation_masse foreign key(num_sensibilisation) references t_sensibilisation(num_sensibilisation)
)
go
create table t_type_observation ------- question pertinente ou reponse_pertinente
(
    id_type_observ nvarchar(50),
    descr_observ_type nvarchar(50),
    constraint pk_type_observation primary key(id_type_observ)
)
go
create table t_observation_atelier
(
    num_observation int,
    id_type_observ nvarchar(50),
    num_participation int,
    description_observation nvarchar(500),
    constraint pk_observation primary key(num_observation),
    constraint fk_type_observ foreign key(id_type_observ) references t_type_observation(id_type_observ),
    constraint fk_participant_observation foreign key(num_participation) references t_participation_atelier(num_participation)
)
go