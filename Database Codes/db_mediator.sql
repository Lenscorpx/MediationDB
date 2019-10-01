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
create table t_localite
(
    id_localite nvarchar(50),
    descr_localite nvarchar(100),
    id_groupement nvarchar(50),
    constraint pk_localite primary key(id_localite),
    constraint fk_groupement foreign key(id_groupement) references t_groupement(id_groupement)
)
go
create table t_situation_menage
(
    id_situation nvarchar(50),
    descr_situation nvarchar(100),
    constraint pk_situation primary key(id_situation)
)
go
create table t_menages
(
    id_menage nvarchar(50),
    date_enregistrement date,
    id_situation nvarchar(50),
    constraint pk_menages primary key(id_menage),
    constraint fk_situation foreign key(id_situation) references t_situation_menage(id_situation)
)
go
create table t_vulnerabilite
(
    id_vulnerabilite nvarchar(50),
    descr_vulnerabilite nvarchar(100),
    constraint pk_vulnerab primary key(id_vulnerabilite)
)
go

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
---------------- natures : individuel, collectif, communautaire, etc.....
create table t_nature_conflit
(
    id_nature_conflit nvarchar(50),
    descr_nature_conflit nvarchar(100),
    constraint pk_nature_conflit primary key(id_nature_conflit)
)
go
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
create table t_objets_conflits
(
    id_objets_conflits nvarchar(50),
    descr_objet_conflits nvarchar(100),
    constraint pk_objet primary key(id_objets_conflits)
)
go
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
create table t_causes_conflits
(
    id_cause_conflit nvarchar(50),
    descr_causes nvarchar(100),
    constraint pk_causes primary key(id_cause_conflit)
)
go
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
create table t_type_parties 
(
    id_typ_partie nvarchar(50),
    descr_typ_partie nvarchar(100),
    constraint pk_type_partie primary key(id_typ_partie)
)
go
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
create table t_resolutions
(
    id_resolution nvarchar(50),
    descr_resolution nvarchar(100),
    constraint pk_resolution primary key(id_resolution)
)
go
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
create table t_mediateur
(
    id_mediateur nvarchar(50),
    descr_mediateur nvarchar(50),
    constraint pk_mediateur primary key(id_mediateur)
)
go
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