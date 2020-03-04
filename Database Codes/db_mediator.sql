use master;
go
drop database db_foncier
go
if not exists(select * from sys.databases where name='db_foncier')
	create database db_foncier;
go
use db_foncier;
go
create table t_pays
(
    code_pays nvarchar(200),
    nom_pays_eng nvarchar(200),
    nom_pays_fr nvarchar(200),
    capitale nvarchar(200),
    constraint pk_pays primary key(code_pays)
)
go
	insert into t_pays
		(code_pays, nom_pays_eng, nom_pays_fr, capitale)
	values
		('+243','Democratic Republic of Congo','Republique Democratique du Congo','Kinshasa')
go
create table t_province
(
	id_province nvarchar(200),
	descr_province nvarchar(200),
	code_pays nvarchar(200),
	constraint pk_province primary key (id_province),
	constraint fk_pays foreign key(code_pays) references t_pays(code_pays)
)
go
	insert into t_province
		(id_province,descr_province,code_pays)
	values
		('Nord Kivu', 'Province du Nord Kivu','+243'),
		('Sud Kivu', 'Province du Sud Kivu','+243'),
		('Sud Ubangi', 'Province du Sud Ubangi','+243'),
		('Nord Ubangi', 'Province du Nord Ubangi','+243'),
		('Nord Uele', 'Province du Nord Uele','+243'),
		('SUd Uele', 'Province du Sud Uele','+243'),
		('Ituri', 'Province Ituri','+243'),
		('Maniema', 'Province du Maniema','+243'),
		('Kinshasa', 'Province de Kinshasa','+243'),
		('Kongo Central', 'Province du Kongo Central','+243'),
		('Kasai Central', 'Province du Kasai Central','+243'),
		('Kasai Oriental', 'Province du Kasai Oriental','+243'),
		('Lualaba', 'Province du Lualaba','+243'),
		('Haut Katanga', 'Province du Haut Katanga','+243'),
		('Tanganyika', 'Province du Tanganyika','+243'),
		('Kwango', 'Province du Kwango','+243'),
		('Mai Ndombe', 'Province du Mai Ndombe','+243'),
		('Tshopo', 'Province du Tshopo','+243'),
		('Tshuapa', 'Province du Tshuapa','+243'),
		('Kwilu', 'Province du Kwilu','+243'),
		('Sankuru', 'Province du Sankuru','+243'),
		('Mongala', 'Province du Mongala','+243'),
		('Lomami', 'Province du Lomami','+243'),
		('Haut Lomami', 'Province du Haut Lomami','+243'),
		('Equateur', 'Province Equateur','+243')
go
create table t_territoire
(
    id_territoire nvarchar(200),
    descr_territoire nvarchar(200),
    id_province nvarchar(200),
    constraint pk_territoire primary key(id_territoire),
    constraint fk_province foreign key(id_province) references t_province(id_province)
)
go
	insert into t_territoire
		(id_territoire,descr_territoire,id_province)
	values
		('Goma','Ville de Goma','Nord Kivu'),
		('Nyiragongo','Territoire de Nyiragongo','Nord Kivu'),
		('Butembo','Ville de Butembo','Nord Kivu'),
		('Lubero','Territoire de Lubero','Nord Kivu'),
		('Rutshuru','Territoire de Rutshure','Nord Kivu'),
		('Masisi','Territoire de Masisi','Nord Kivu'),
		('Walikale','Territoire de Walikale','Nord Kivu'),
		('Beni','Ville de Beni','Nord Kivu')
go
create table t_chefferie
(
    id_chefferie nvarchar(200),
    descr_chefferie nvarchar(200),
    id_territoire nvarchar(200),
    constraint pk_chefferie primary key(id_chefferie),
    constraint fk_territoire foreign key(id_territoire) references t_territoire(id_territoire)
)
go
	insert into t_chefferie
	values
		('Bashali','Chefferie de Bashali','Masisi'),
		('Bwisha','Chefferie de Bwisha','Rutshuru'),
		('Bwito','Chefferie de Bwito','Rutshuru'),
		('Wanianga','Chefferie de Wanianga','Walikale')
go
create table t_groupement
(
    id_groupement nvarchar(200),
    descr_groupement nvarchar(200),
    id_chefferie nvarchar(200),
    constraint pk_groupement primary key(id_groupement),
    constraint fk_chefferie foreign key(id_chefferie) references t_chefferie(id_chefferie)
)
go
	insert into t_groupement
	values
		('Bashali Mukoto','Groupement de Bashali Mukoto','Bashali'),
		('Bashali Kaembe','Groupement de Bashali Kaembe','Bashali'),
		('Bukombo','Groupement de Bukombo','Bwito'),
		('Mutanda','Groupement de Mutanda','Bwito'),
		('Bishusha','Groupement de Bishusha','Bwito'),
		('Kihondo','Groupement de Kihondo','Bwito'),
		('Kitshimba','Groupement de Kitshimba','Wanianga')
go
--------------------------Debut codes localite-----------------------------------------------------------
create table t_localite
(
    id_localite nvarchar(200),
    descr_localite nvarchar(200),
    id_groupement nvarchar(200),
    constraint pk_localite primary key(id_localite),
    constraint fk_groupement foreign key(id_groupement) references t_groupement(id_groupement)
)
go
	insert into t_localite
	values
		('Burungu','Localite de Burungu','Bashali Kaembe'),
		('Nyamitaba','Localite de Nyamitaba','Bashali Kaembe'),
		('Kitshanga','Localite de Kitshanga','Bashali Mukoto'),
		('Muhanga','Localite de Muhanga','Bashali Mukoto'),
		('Mweso','Localite de Mweso','Bashali Mukoto'),
		('Kalembe','Localite de Kalembe','Bashali Mukoto'),
		('Kirumbu','Localite de Kirumbu','Bashali Mukoto'),
		('Busumba/lupfunda','Localite de Busumba/lupfunda','Bashali Mukoto'),
		('Butole','Localite de Butole','Bashali Mukoto'),
		('Kahira','Localite de Kahira','Bashali Mukoto'),
		('Nyange','Localite de Nyange','Bashali Mukoto'),
		('Bushimoo','Localite de Bushimoo','Bashali Mukoto'),
		('Kalungu','Localite de Kalungu','Bashali Mukoto'),
		('Bulende','Localite de Bulende','Bashali Mukoto'),
		('Kitshimba','Localite de Kitshimba','Bishusha'),
		('Katsiru','Localite de Katsiru','Kihondo'),
		('Nyanzale','Localite de Nyanzale','Mutanda'),
		('Kishishe','Localite de Kishishe','Mutanda'),
		('Pinga','Localite de Pinga','Kitshimba'),
		('Katsiru de Bukombo','Localite de Katsiru','Bukombo'),
		('Kyahemba','Localite de Kyahemba','Bukombo'),
		('CISA','Localite de CISA','Bukombo'),
		('Mubirubiru','Localite de Mubirubiru','Bukombo')
go

create procedure recuperer_localite
as
    select top 50 id_localite from t_localite
    order by id_localite asc
go
create procedure search_localite
@id_localite nvarchar(200)
as
   select top 50 id_localite from t_localite
   where id_localite like '%'+@id_localite+'%'
go
----------------------------Fin codes localite----------------------------------------------------------
-----------------------------Debut codes Situation Menages-----------------------------------------------------
create table t_situation_menage
(
    id_situation nvarchar(200),
    descr_situation nvarchar(200),
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
@id_situation nvarchar(200),
@descr_situation nvarchar(200)
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
@id_situation nvarchar(200)
as
    delete from t_situation_menage
        where id_situation=@id_situation
go
create procedure search_situation
@id_situation nvarchar(200)
as
    select top 50 id_situation as 'Situation de menage', descr_situation as 'Description' 
    from t_situation_menage
    where id_situation like '%'+@id_situation+'%'
go
create procedure recuperer_situation_menage
as
    select id_situation
    from t_situation_menage
        order by id_situation asc
go
----------------------------Fin des codes Situations menages -------------------------------------------------
--------------------------- Debut codes menages---------------------------------------------------------------
create table t_menages
(
    id_menage nvarchar(200),
    date_enregistrement date,
    id_situation nvarchar(200),
	total_homme int,
	total_femme int,
	total_garcons int,
	total_filles int,
    constraint pk_menages primary key(id_menage),
    constraint fk_situation foreign key(id_situation) references t_situation_menage(id_situation)
)
go
create procedure charts_somme_menages_homme
as
	select sum(total_homme) as total_homme 
		from t_menages
	where
		id_menage in (select id_menage from t_parties)
go
create procedure charts_somme_menages_femme
as
	select sum(total_femme) as total_femme 
		from t_menages
	where
		id_menage in (select id_menage from t_parties)
go
create procedure charts_somme_menages_filles
as
	select sum(total_filles) as total_filles 
		from t_menages
	where
		id_menage in (select id_menage from t_parties)
go
create procedure charts_somme_menages_garcons
as
	select sum(total_garcons) as total_garcons 
		from t_menages
	where
		id_menage in (select id_menage from t_parties)
go
create procedure afficher_menages
as
    select top 50 
		id_menage as 'Code Menage', 
		date_enregistrement as 'Date Enr', 
		id_situation as 'Situation Menage', 
		total_homme as 'Hommes', 
		total_femme as 'Femmes', 
		total_garcons as 'Garcons', 
		total_filles as 'Filles' 
	from t_menages
    order by  
        date_enregistrement desc, id_menage desc
    go
create procedure enregistrer_menage
@id_menage nvarchar(200),
@id_situation nvarchar(200),
@hommes int, 
@femmes int, 
@filles int, 
@garcons int
as 
    merge into t_menages
    using (select @id_menage as x_id) as x_source
    on(x_source.x_id=t_menages.id_menage)
    when matched then
        update set
            date_enregistrement=getDate(),
            id_situation=@id_situation,
			total_homme=@hommes,
			total_femme=@femmes,
			total_garcons=@garcons,
			total_filles=@filles
    when not matched then
        insert
            (id_menage,date_enregistrement,id_situation, total_homme, total_femme, total_garcons, total_filles)
        values
            (@id_menage,getDate(),@id_situation, @hommes, @femmes, @garcons, @filles);
go
create procedure supprimer_menage
@id_menage nvarchar(200)
as
    delete from t_menages
        where id_menage like @id_menage
go
create procedure search_menage
@mot nvarchar(50)
as
	select top 50 id_menage as 'Code Menage', date_enregistrement as 'Date Enr', id_situation as 'Situation Menage', total_homme as 'Hommes', total_femme as 'Femmes', total_garcons as 'Garcons', total_filles as 'Filles' from t_menages
    where
		id_menage like '%'+@mot+'%'
	order by  
        date_enregistrement desc, id_menage desc
go
-----------------------------Fin codes menages --------------------------------------------------------------

-----------------------------Debut codes vulnerabilite ---------------------------------------
create table t_vulnerabilite
(
    id_vulnerabilite nvarchar(200),
    descr_vulnerabilite nvarchar(200),
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
@id_vulnerabilite nvarchar(200),
@descr_vulnerabilite nvarchar(200)
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
@id_vulnerabilite nvarchar(200)
as
    delete from t_vulnerabilite
        where id_vulnerabilite like @id_vulnerabilite
go
create procedure search_vulnerabilite
@id_vulnerabilite nvarchar(200)
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
-----------------------------Dedbut codes membres---------------------------------------------
create table t_membres
(
    id_membre nvarchar(200),
    noms nvarchar(200),
    date_naissance date,
    etat_civil nvarchar(200),
    id_vulnerabilite nvarchar(200),
    provenance nvarchar(200),
    adresse nvarchar(200),
    num_tel nvarchar(200),
    repr_menage nvarchar(200),
    profession nvarchar(200),
    id_menage nvarchar(200),
    date_enregistrement date,
    sexe nvarchar(200),
    constraint pk_membre primary key(id_membre),
    constraint fk_vulnerab foreign key(id_vulnerabilite) references t_vulnerabilite(id_vulnerabilite),
    constraint fk_menage_membre foreign key(id_menage) references t_menages(id_menage)
 )
go
create procedure afficher_membres
as
	select top 50 
		id_membre as 'ID',
		noms as 'Noms',
		sexe as 'Genre',
		date_naissance as 'Date Naissance',
		etat_civil as 'Etat Civil',
		id_vulnerabilite as 'Vulnerabilite',
		provenance as 'Provenance',
		adresse as 'Adresse',
		num_tel as 'Telephone',
		repr_menage as 'Repr. Menage',
		profession as 'Profession',
		id_menage as 'Menage',
		date_enregistrement as 'Enreg.'		
	from t_membres
		order by
			date_enregistrement desc, id_membre desc
go
create procedure rechercher_membres_parID
@id_menage nvarchar(200)
as
	select top 50 
		id_membre as 'ID',
		noms as 'Noms',
		sexe as 'Genre',
		date_naissance as 'Date Naissance',
		etat_civil as 'Etat Civil',
		id_vulnerabilite as 'Vulnerabilite',
		provenance as 'Provenance',
		adresse as 'Adresse',
		num_tel as 'Telephone',
		repr_menage as 'Repr. Menage',
		profession as 'Profession',
		id_menage as 'Menage',
		date_enregistrement as 'Enreg.'		
	from t_membres
	where 
		id_menage like '%'+@id_menage+'%'
		order by
			date_enregistrement desc, id_membre desc
go
create procedure rechercher_membres_parCodeMembre
@id_membre nvarchar(200)
as
	select top 50 
		id_membre as 'ID',
		noms as 'Noms',
		sexe as 'Genre',
		date_naissance as 'Date Naissance',
		etat_civil as 'Etat Civil',
		id_vulnerabilite as 'Vulnerabilite',
		provenance as 'Provenance',
		adresse as 'Adresse',
		num_tel as 'Telephone',
		repr_menage as 'Repr. Menage',
		profession as 'Profession',
		id_menage as 'Menage',
		date_enregistrement as 'Enreg.'		
	from t_membres
	where 
		id_membre like '%'+@id_membre+'%'
		order by
			date_enregistrement desc, id_membre desc
go
create procedure rechercher_membres_parNoms
@noms nvarchar(200)
as
	select top 50		
		id_membre as 'ID',
		noms as 'Noms',
		sexe as 'Genre',
		date_naissance as 'Date Naissance',
		etat_civil as 'Etat Civil',
		id_vulnerabilite as 'Vulnerabilite',
		provenance as 'Provenance',
		adresse as 'Adresse',
		num_tel as 'Telephone',
		repr_menage as 'Repr. Menage',
		profession as 'Profession',
		id_menage as 'Menage',
		date_enregistrement as 'Enreg.'		
	from t_membres
	where 
		noms like '%'+@noms+'%'
		order by
			date_enregistrement desc, id_membre desc
go
create procedure charger_membres
as
	select top 50
		noms
	from t_membres
go
create procedure rechercher_nom_membre
@noms nvarchar(50)
as
	select top 50
		noms
	from t_membres
		where
			noms like '%'+@noms+'%'
go
create procedure search_membres_parNoms
@noms nvarchar(200)
as
	select		
		id_membre,
		id_menage		
	from t_membres
	where 
		noms like '%'+@noms+'%'
		order by
			date_enregistrement desc, id_membre desc
go
create procedure search_membres_parID_membre
@id_membre nvarchar(200)
as
	select		
		id_membre,
		noms,
		id_menage		
	from t_membres
	where 
		id_membre like '%'+@id_membre+'%'
		order by
			date_enregistrement desc, id_membre desc
go
create procedure inserer_membre
@id_membre nvarchar(200),
@noms nvarchar(200),
@date_naissance date,
@etat_civil nvarchar(200),
@id_vulnerabilite nvarchar(200),
@provenance nvarchar(200),
@adresse nvarchar(200),
@num_tel nvarchar(200),
@repr_menage nvarchar(200),
@profession nvarchar(200),
@id_menage nvarchar(200),
@date_enregistrement date,
@sexe nvarchar(200)
as
	merge into t_membres
	using (select @id_membre as x_id) as x_source
	on(x_source.x_id=t_membres.id_membre)
	when not matched then
		insert
		(
			id_membre, 
			noms, 
			date_naissance, 
			sexe,etat_civil, 
			id_vulnerabilite, 
			provenance, 
			adresse, 
			num_tel, 
			repr_menage, 
			profession, 
			id_menage, 
			date_enregistrement
		)
	values
		(
			@id_membre, 
			@noms, 
			@date_naissance, 
			@sexe, 
			@etat_civil, 
			@id_vulnerabilite, 
			@provenance, 
			@adresse, 
			@num_tel, 
			@repr_menage, 
			@profession, 
			@id_menage, 
			@date_enregistrement
		)
	when matched then
		update
			set
				noms=@noms,
				date_naissance=@date_naissance,
				etat_civil=@etat_civil,
				id_vulnerabilite=@id_vulnerabilite,
				provenance=@provenance,
				adresse=@adresse,
				num_tel=@num_tel,
				repr_menage=@repr_menage,
				profession=@profession,
				id_menage=@id_menage,
				date_enregistrement=@date_enregistrement,
				sexe=@sexe;
go
create procedure modifier_membre
@id_membre nvarchar(200),
@noms nvarchar(200),
@date_naissance date,
@etat_civil nvarchar(200),
@id_vulnerabilite nvarchar(200),
@provenance nvarchar(200),
@adresse nvarchar(200),
@num_tel nvarchar(200),
@repr_menage nvarchar(200),
@profession nvarchar(200),
@id_menage nvarchar(200),
@date_enregistrement date,
@sexe nvarchar(200)
as
	update t_membres 
	set
		noms=@noms,
		date_naissance=@date_naissance,
		etat_civil=@etat_civil,
		id_vulnerabilite=@id_vulnerabilite,
		provenance=@provenance,
		adresse=@adresse,
		num_tel=@num_tel,
		repr_menage=@repr_menage,
		profession=@profession,
		id_menage=@id_menage,
		date_enregistrement=@date_enregistrement,
		sexe=@sexe
	where
		id_membre like @id_membre
go
create procedure supprimer_membre
@id_membre nvarchar(200)
as
	delete from t_membres
		where
			id_membre like @id_membre
go
create procedure recuperer_membre
as
	select top 50
		noms
	from t_membres
go
------------- types : conflit lie aux concessions, espaces proteges, etc.....
create table t_type_conflit
(
    id_type_conflit nvarchar(200),
    descr_type_conflit nvarchar(200),
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
@id_type_conflit nvarchar(200),
@descr_type_conflit nvarchar(200)
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
@id_type_conflit nvarchar(200)
as
    delete from t_type_conflit
        where id_type_conflit like @id_type_conflit
go
create procedure search_type_conflit
@id_type_conflit nvarchar(200)
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
    id_nature_conflit nvarchar(200),
    descr_nature_conflit nvarchar(200),
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
@id_nature_conflit nvarchar(200),
@descr_nature_conflit nvarchar(200)
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
@id_nature_conflit nvarchar(200)
as
    delete from t_nature_conflit
        where id_nature_conflit=@id_nature_conflit
go
create procedure search_nature_conflit
@id_nature_conflit nvarchar(200)
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
    num_conflit nvarchar(200),
    date_enreg date, 
    date_debut_conflit date,
    id_type_conflit nvarchar(200),
    id_nature_conflit nvarchar(200),
    id_localite nvarchar(200),
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
create procedure search_conflit
@num_conflit nvarchar(200)
as
    select top 50 
		num_conflit as 'Num.', 
		date_enreg as 'Date Enr.', 
		date_debut_conflit as 'Debut conflit', 
		id_type_conflit as 'Type Conflit',
        id_nature_conflit as 'Nature conflit', 
		id_localite as 'Lieu' 
	from t_conflit
	where
		num_conflit like '%' + num_conflit + '%'
    order by num_conflit desc
go
create procedure inserer_conflit
@num_conflit nvarchar(200),
@date_debut_conflit date,
@id_type_conflit nvarchar(200),
@id_nature_conflit nvarchar(200),
@id_localite nvarchar(200)
as 
	merge into t_conflit
	using (select @num_conflit as x_id) as x_table
	on(x_table.x_id=t_conflit.num_conflit)
	when matched then
		update set
            date_enreg=getDate(),
            date_debut_conflit=@date_debut_conflit,
            id_type_conflit=@id_type_conflit,
            id_nature_conflit=@id_nature_conflit,
            id_localite=@id_localite
	when not matched then
		insert
			(num_conflit, date_enreg,date_debut_conflit,id_type_conflit,id_nature_conflit,id_localite)
		values
			(@num_conflit, getDate(),@date_debut_conflit,@id_type_conflit,@id_nature_conflit,@id_localite);
go
create procedure supprimer_conflit
@num_conflit nvarchar(200)
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
    num_conflit nvarchar(200),
    constraint pk_details_conflits primary key(num_details_conflits),
    constraint fk_conflit_details foreign key(num_conflit) references t_conflit(num_conflit)
)
go
create procedure afficher_details_conflits
@num_conflit nvarchar(200)
as
    select num_details_conflits as 'Num.', num_conflit as 'Conflit', descript_conflit as 'Details', date_enreg as 'Enreg.' 
    from t_details_conflits
    where num_conflit = @num_conflit
        order by num_details_conflits desc
go
create procedure inserer_details
@descript_conflit nvarchar(500),
@num_conflit nvarchar(200)
as
    insert into t_details_conflits
        (date_enreg, descript_conflit, num_conflit)
    values
        (getDate(), @descript_conflit, @num_conflit)
go
create procedure modifier_details
@num_details_conflits int,
@descript_conflit nvarchar(500),
@num_conflit nvarchar(200)
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
    id_objets_conflits nvarchar(200),
    descr_objet_conflits nvarchar(200),
    constraint pk_objet primary key(id_objets_conflits)
)
go
create procedure afficher_objet_conflit
as
    select top 50 id_objets_conflits as 'Objet de conflit', descr_objet_conflits as 'Description' 
    from t_objets_conflits
        order by id_objets_conflits asc
go
create procedure recuperer_objet_conflit
as
    select id_objets_conflits as 'Objet de conflit' 
    from t_objets_conflits
        order by id_objets_conflits asc
go
create procedure enregistrer_objet_conflit
@id_objets_conflits nvarchar(200),
@descr_objet_conflits nvarchar(200)
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
@id_objets_conflits nvarchar(200)
as
    delete from t_objets_conflits
        where id_objets_conflits like @id_objets_conflits
go
create procedure search_objet_conflit
@id_objets_conflits nvarchar(200)
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
    id_objets_conflits nvarchar(200),
    num_conflit nvarchar(200),
    observation nvarchar(200),
    constraint pk_assignation_objet primary key(num_details_objet),
    constraint fk_objet_assign foreign key(id_objets_conflits) references t_objets_conflits(id_objets_conflits),
    constraint fk_conflit_obj foreign key(num_conflit) references t_conflit(num_conflit)
)
go
create procedure afficher_assign_objets
as
	select top 50
		num_details_objet as 'Num.',
		date_enreg as 'Date Enr',
		id_objets_conflits as 'Objets de conflit',
		num_conflit as 'Conflit',
		observation as 'Observation'
	from t_assignation_objets
		order by num_details_objet desc
go
create procedure inserer_assign_objet_conflit
@id_objets_conflits nvarchar(200),
@num_conflit nvarchar(200),
@observation nvarchar(200)
as
	insert into t_assignation_objets
		(date_enreg, id_objets_conflits,num_conflit,observation)
	values
		(getdate(), @id_objets_conflits, @num_conflit, @observation)
go
create procedure modifier_assign_objet_conflit
@num_details_objet int,
@id_objets_conflits nvarchar(200),
@num_conflit nvarchar(200),
@observation nvarchar(200)
as
	update t_assignation_objets
		set
			date_enreg=getdate(),
			id_objets_conflits=@id_objets_conflits,
			num_conflit=@num_conflit,
			observation=@observation
		where
			num_details_objet like @num_details_objet
go
create procedure supprimer_assign_objet_conflit
@num_details_objet int
as
	delete from t_assignation_objets
		where
			num_details_objet like @num_details_objet
go
-----------------------------Debut code cause_conflit--------------------------------------------------
create table t_causes_conflits
(
    id_cause_conflit nvarchar(200),
    descr_causes nvarchar(200),
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
@id_cause_conflit nvarchar(200),
@descr_causes nvarchar(200)
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
@id_cause_conflit nvarchar(200)
as
    delete from t_causes_conflits
        where id_cause_conflit like @id_cause_conflit
go
create procedure search_cause_conflit
@id_cause_conflit nvarchar(200)
as
    select top 50 id_cause_conflit as 'ID Cause conflit', descr_causes as 'Description' 
        from t_causes_conflits
    where id_cause_conflit like '%'+@id_cause_conflit+'%'
go
create procedure recuperer_causes_conflits
as
	select
		id_cause_conflit 
	from t_causes_conflits
go
-----------------------------Fin code cause_conflit----------------------------------------------------
create table t_assignation_causes
(
    num_assignation_causes int identity,
    date_enreg date,
    id_cause_conflit nvarchar(200),
    num_conflit nvarchar(200),
    constraint pk_assign_cause primary key(num_assignation_causes),
    constraint fk_cause_assgn foreign key(id_cause_conflit) references t_causes_conflits(id_cause_conflit),
    constraint fk_conf_ass_cause foreign key(num_conflit) references t_conflit(num_conflit)
) 
go
create procedure afficher_assign_causes
as
	select top 50
		num_assignation_causes as 'Num.',
		date_enreg as 'Date Enr.',
		id_cause_conflit as 'Causes',
		num_conflit as 'Conflit Num.'
	from t_assignation_causes
		order by num_assignation_causes desc
go
create procedure inserer_assignation_causes
@id_cause_conflit nvarchar(50),
@num_conflit nvarchar(200)
as
	insert into t_assignation_causes
		(date_enreg, id_cause_conflit, num_conflit)
	values
		(GETDATE(),@id_cause_conflit, @num_conflit)
go
create procedure modifier_assignation_causes
@num_assignation_causes int,
@id_cause_conflit nvarchar(50),
@num_conflit nvarchar(200)
as
	update t_assignation_causes
		set
			date_enreg = Getdate(),
			id_cause_conflit=@id_cause_conflit,
			num_conflit=@num_conflit
	where
		num_assignation_causes like @num_assignation_causes
go
create procedure supprimer_assignation_causes
@num_assignation_causes int
as
	delete from t_assignation_causes
		where num_assignation_causes like @num_assignation_causes
go
---cette table permettra de reconnaitre quel type de menages est soit accuse ou plaignant
--------------------- Debut codes Types Parties ---------------------------------------------------------
create table t_type_parties 
(
    id_typ_partie nvarchar(200),
    descr_typ_partie nvarchar(200),
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
@id_typ_partie nvarchar(200),
@descr_typ_partie nvarchar(200)
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
@id_typ_partie nvarchar(200)
as
    delete from t_type_parties
        where id_typ_partie like @id_typ_partie
go
create procedure search_type_partie
@id_typ_partie nvarchar(200)
as
    select top 50 id_typ_partie as 'Type de partie', descr_typ_partie as 'Description' 
    from t_type_parties
        where id_typ_partie like '%'+@id_typ_partie+'%'
go
create procedure recuperer_type_partie
as
	select
		id_typ_partie
	from t_type_parties
go
---------------------- Fin Codes Types Parties ----------------------------------------------------------------
create table t_parties
(
    num_partie int identity,
    date_enreg date,
    id_typ_partie nvarchar(200),
    id_menage nvarchar(200),
    num_conflit nvarchar(200),
    constraint pk_partie primary key(num_partie),
    constraint fk_conflict_partie foreign key (num_conflit) references t_conflit(num_conflit),
    constraint fk_type_partie_part foreign key(id_typ_partie) references t_type_parties(id_typ_partie),
    constraint fk_menage_partie foreign key(id_menage) references t_menages(id_menage)
)
go
create procedure afficher_partie
as
	select top 50
		num_partie as 'Enr.',
		date_enreg as 'Date',
		id_typ_partie as 'Role',
		id_menage as 'Menage',
		num_conflit as 'Code Conflit' 		
	from t_parties
	order by
		num_partie desc
go
create procedure search_partie_byConflit
@num_conflit nvarchar(50)
as
	select top 50
		num_partie as 'Enr.',
		date_enreg as 'Date',
		id_typ_partie as 'Role',
		id_menage as 'Menage',
		num_conflit as 'Code Conflit' 		
	from t_parties
		where num_conflit like '%'+@num_conflit+'%'
	order by
		num_partie desc
go
create procedure search_partie_byMenage
@id_menage nvarchar(50)
as
	select top 50
		num_partie as 'Enr.',
		date_enreg as 'Date',
		id_typ_partie as 'Role',
		id_menage as 'Menage',
		num_conflit as 'Code Conflit' 		
	from t_parties
		where id_menage like '%'+@id_menage+'%'
	order by
		num_partie desc
go
create procedure inserer_partie
@id_typ_partie nvarchar(200),
@id_menage nvarchar(200),
@num_conflit nvarchar(200)
as
	insert into t_parties
		(date_enreg,id_typ_partie, id_menage, num_conflit)
	values
		(getdate(),@id_typ_partie, @id_menage, @num_conflit)
go
create procedure modifier_partie
@num_partie int,
@id_typ_partie nvarchar(200),
@id_menage nvarchar(200),
@num_conflit nvarchar(200)
as
	update t_parties
		set
			id_typ_partie = @id_typ_partie,
			id_menage=@id_menage,
			num_conflit=@num_conflit
		where
			num_partie like @num_partie
go
create procedure supprimer_partie
@num_partie int
as
	delete from t_parties
		where
			num_partie like @num_partie
go
-------------------------Debut codes Resolutions--------------------------------------------------------
create table t_resolutions
(
    id_resolution nvarchar(200),
    descr_resolution nvarchar(200),
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
@id_resolution nvarchar(200),
@descr_resolution nvarchar(200)
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
@id_resolution nvarchar(200)
as
    delete from t_resolutions
        where id_resolution=@id_resolution
go
create procedure search_resolution
@id_resolution nvarchar(200)
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
    num_conflit nvarchar(200),
    id_resolution nvarchar(200),
    date_resolution date,
    commentaires nvarchar(200),
    constraint pk_assignation_resolution primary key(num_assign_resol),
    constraint fk_conflit_resol foreign key(num_conflit) references t_conflit(num_conflit),
    constraint fk_resol_assign_res foreign key(id_resolution) references t_resolutions(id_resolution)
)
go
create procedure afficher_assign_resolutions
as
	select top 50
		num_assign_resol as 'Num.',
		num_conflit as 'Conflit',
		id_resolution as 'Etat Conflit',
		date_resolution as 'Date',
		commentaires as 'Commentaires'
	from t_assignation_resolution
		order by
			num_assign_resol desc
go
create procedure inserer_assign_resolutions
--@num_assign_resol int,
@num_conflit nvarchar(200),
@id_resolution nvarchar(200),
@date_resolution date,
@commentaires nvarchar(200)
as
	insert into t_assignation_resolution
		(num_conflit, id_resolution, date_resolution, commentaires)
	values
		(@num_conflit, @id_resolution, @date_resolution, @commentaires)
go
create procedure modifier_assign_resolutions
@num_assign_resol int,
@num_conflit nvarchar(200),
@id_resolution nvarchar(200),
@date_resolution date,
@commentaires nvarchar(200)
as
	update t_assignation_resolution
		set
			num_conflit=@num_conflit, 
			id_resolution=@id_resolution, 
			date_resolution=@date_resolution, 
			commentaires=@commentaires
		where
			num_assign_resol like @num_assign_resol
go
create procedure supprimer_assign_resolutions
@num_assign_resol int
as
	delete from t_assignation_resolution
		where num_assign_resol like @num_assign_resol
go
create procedure recuperer_resolutions
as
	select
		id_resolution		
	from t_resolutions
		order by id_resolution asc
go
------------------------------- Codes mediateur---------------------------------------------
create table t_mediateur
(
    id_mediateur nvarchar(200),
    descr_mediateur nvarchar(200),
    constraint pk_mediateur primary key(id_mediateur)
)
go
create procedure afficher_mediateur
as
    select top 50 id_mediateur as 'Code mediateur', descr_mediateur as 'Description' from t_mediateur
    order by id_mediateur asc
go
create procedure enregistrer_mediateur
@id_mediateur nvarchar(200),
@descr_mediateur nvarchar(200)
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
@id_mediateur nvarchar(200)
as
    delete from t_mediateur
        where 
            id_mediateur like @id_mediateur
go
create procedure search_mediateur
@id_mediateur nvarchar(200)
as
    select top 50 id_mediateur as 'Code mediateur', descr_mediateur as 'Description' 
    from t_mediateur
    where id_mediateur like '%'+@id_mediateur+'%'
go
create procedure recuperer_mediateur
as
    select id_mediateur from t_mediateur
        order by id_mediateur asc
go
------------------------------- Fin codes mediateur----------------------------------------
------------------------------- debut codes mediation -------------------------------------
create table t_mediation
(
    num_mediation int identity,
    date_debut_mediation date,
    num_conflit nvarchar(200),
    id_mediateur nvarchar(200),
    noms_mediateur nvarchar(200),
    lieu nvarchar(200),
    appreciation nvarchar(500),
	date_fin_mediation date,
    constraint pk_mediation primary key(num_mediation),
    constraint fk_mediateur_mediation foreign key(id_mediateur) references t_mediateur(id_mediateur),
    constraint fk_mediation_conflit foreign key(num_conflit) references t_conflit(num_conflit)
)
go
create procedure afficher_mediation
@num_conflit nvarchar(200)
as
    select top 50 
		num_mediation as 'Num.', 
		date_debut_mediation as 'Debut Mediation', 
		num_conflit as 'Conflit',
        id_mediateur as 'Mediateur', 
		noms_mediateur as 'Resp. Mediation', 
		lieu as 'Lieu', 
		appreciation as 'Commentaire', 
		date_fin_mediation as 'Fin Mediation'
    from t_mediation
        where
            num_conflit like '%'+@num_conflit+'%'
        order by num_mediation desc
go
create procedure afficher_mediation_all
as
    select top 50 
		num_mediation as 'Num.', 
		date_debut_mediation as 'Debut Mediation', 
		num_conflit as 'Conflit',
        id_mediateur as 'Mediateur', 
		noms_mediateur as 'Resp. Mediation', 
		lieu as 'Lieu', 
		appreciation as 'Commentaire', 
		date_fin_mediation as 'Fin Mediation'
    from t_mediation
        order by num_mediation desc
go
create procedure inserer_mediation
@date_debut_mediation date,
@num_conflit nvarchar(200),
@id_mediateur nvarchar(200),
@noms_mediateur nvarchar(200),
@lieu nvarchar(200),
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
@num_conflit nvarchar(200),
@id_mediateur nvarchar(200),
@noms_mediateur nvarchar(200),
@lieu nvarchar(200),
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
create table t_documents
(
    num_doc int identity,
    date_enregistrement date,
    titre_document nvarchar(200),
    num_mediation int,
    file_location nvarchar(max),
    type_fichcier nvarchar(200),
    file_description nvarchar(200),
    constraint pk_primary primary key(num_doc),
    constraint fk_mediation_document foreign key(num_mediation) references t_mediation(num_mediation)
)
go
------------------------------Debut codes sensibilisation -----------------------------------------------------------
create table t_sensibilisation
(
    num_sensibilisation nvarchar(200),
    date_debut date,
    date_fin date,
    id_localite nvarchar(200),
    constraint pk_sensibilisation primary key(num_sensibilisation),
    constraint fk_localite_sensibil foreign key(id_localite) references t_localite(id_localite)
)
go
create procedure afficher_sensibilisation
as
	select top 50
		num_sensibilisation as 'Num',
		date_debut as 'Debut de sensibilisation',
		date_fin as 'Fin de sensibilisation',
		id_localite as 'Lieu'
	from t_sensibilisation
		order by num_sensibilisation desc
go
create procedure inserer_sensibilisation
@num_sensibilisation nvarchar(200),
@date_debut date,
@date_fin date,
@id_localite nvarchar(200)
as
	merge into t_sensibilisation
	using ( select @num_sensibilisation as x_id) as x_source
	on(x_source.x_id=t_sensibilisation.num_sensibilisation)
	when matched then
		update
			set
				date_debut=@date_debut,
				date_fin=@date_fin,
				id_localite=@id_localite
	when not matched then
		insert
			(num_sensibilisation,date_debut,date_fin,id_localite)
		values
			(@num_sensibilisation, @date_debut,@date_fin,@id_localite);
go
create procedure modifier_sensibilisation
@num_sensibilisation nvarchar(200),
@date_debut date,
@date_fin date,
@id_localite nvarchar(200)
as
	update t_sensibilisation
		set
			date_debut=@date_debut,
			date_fin=@date_fin,
			id_localite=@id_localite
		where
			num_sensibilisation like @num_sensibilisation
go
create procedure supprimer_sensibilisation
@num_sensibilisation nvarchar(200)
as
	delete from t_sensibilisation
		where num_sensibilisation like @num_sensibilisation
go
create procedure search_sensibilisation
@id_localite nvarchar(200)
as
	select top 50 
		num_sensibilisation as 'Num',
		date_debut as 'Debut de sensibilisation',
		date_fin as 'Fin de sensibilisation',
		id_localite as 'Lieu'
	from t_sensibilisation
	where
		id_localite like '%'+@id_localite+'%'
		order by num_sensibilisation desc
go
create procedure search_sensibilisation_bycode_sensibilisation
@num_sensibilisation nvarchar(200)
as
	select top 50 
		num_sensibilisation as 'Num',
		date_debut as 'Debut de sensibilisation',
		date_fin as 'Fin de sensibilisation',
		id_localite as 'Lieu'
	from t_sensibilisation
	where
		num_sensibilisation like '%'+@num_sensibilisation+'%'
		order by num_sensibilisation desc
go
------------------------------Fin codes sensibilisation--------------------------------------------------------------
create table t_atelier
(
    id_atelier nvarchar(200),
    theme_developpe nvarchar(200),
    constraint pk_atelier primary key(id_atelier)
)
go
create table t_participants
(
    id_participant nvarchar(200),
    noms nvarchar(200),
	sexe nvarchar(200),
    num_phone nvarchar(200),
	date_naissance date,
	adresse nvarchar(500),
    constraint pk_participant primary key(id_participant)
)
go
create table t_etat_participant ------- Etat: Rappatrie, retourne, population locale, autorite, appui technique,...
(
    id_etat_part nvarchar(200),
    descr_etat nvarchar(200),
    constraint pk_etat_part primary key(id_etat_part)
)
go
create table t_participation_atelier
(
    num_participation int identity,
    date_atelier date,
    num_sensibilisation nvarchar(200),
    id_atelier nvarchar(200),
    nom_sensibilisateur nvarchar(200),
	lieu_organisation nvarchar(200),
    constraint pk_participation_atelier primary key(num_participation),
    constraint fk_atelier_participation foreign key(id_atelier) references t_atelier(id_atelier),
    constraint fk_sensibilisation_participation foreign key(num_sensibilisation) references t_sensibilisation(num_sensibilisation)
)
go
create table t_details_participation
(	
	num_ordre int identity,
	num_participation int,
	id_participant nvarchar(200),
	id_etat_part nvarchar(200),
	constraint pk_details_participation primary key(num_ordre),
	constraint fk_participation_part foreign key(id_participant) references t_participants(id_participant),
	constraint fk_etat_participant foreign key(id_etat_part) references t_etat_participant(id_etat_part),
	constraint fk_particpation_liste foreign key(num_participation) references t_participation_atelier(num_participation)
)
go
create table t_atelier_masse
(
    num_atelier_masse int identity,
    date_atelier date,
    num_sensibilisation nvarchar(200),
    nbre_hommes int,
    nbre_femmes int,
    nbre_filles int,
	nbre_garcons int,
	nbre_autorite_femmes int,
	nbre_autorite_hommes int,
	nbre_menages_deplaces int,
	nbre_menages_retournes int,
	nbre_menages_locaux int, 
	nbre_menages_rapatrie int,
    theme_developpe nvarchar(200),    
    observation nvarchar(max),
    noms_sensibilisateur nvarchar(200),
	commentaires nvarchar(max),
	telephone_sensibilisateur nvarchar(50),
    constraint pk_atelier_masse primary key(num_atelier_masse),
    constraint fk_sensibilisation_masse foreign key(num_sensibilisation) references t_sensibilisation(num_sensibilisation)
)
go
create procedure afficher_atelier_masse
as
	select top 50 
		num_atelier_masse as 'Num',
		date_atelier as 'Date',
		num_sensibilisation as 'Num. Sens',
		nbre_hommes as 'Hommes',
		nbre_femmes as 'Femmes',
		nbre_filles as 'Filles',
		nbre_garcons as 'Garcons',
		nbre_autorite_femmes as 'Autorit� Femme',
		nbre_autorite_hommes as 'Autorit� Homme',
		nbre_menages_deplaces as 'Menages deplac�s',
		nbre_menages_retournes as 'Menages retourn�s',
		nbre_menages_locaux as 'Menages locaux', 
		nbre_menages_rapatrie as 'Menages rappatri�s',
		theme_developpe as 'Th�me',    
		observation as 'Observation',
		noms_sensibilisateur as 'Noms sensibilisateurs',
		commentaires as 'Commentaires',
		telephone_sensibilisateur as 'Telephone'
	from t_atelier_masse
		order by num_atelier_masse desc
go
create procedure search_atelier_masse_bysensibilisation
@num_sensibilisation nvarchar(20)
as
	select top 50 
		num_atelier_masse as 'Num',
		date_atelier as 'Date',
		num_sensibilisation as 'Num. Sens',
		nbre_hommes as 'Hommes',
		nbre_femmes as 'Femmes',
		nbre_filles as 'Filles',
		nbre_garcons as 'Garcons',
		nbre_autorite_femmes as 'Autorit� Femme',
		nbre_autorite_hommes as 'Autorit� Homme',
		nbre_menages_deplaces as 'Menages deplac�s',
		nbre_menages_retournes as 'Menages retourn�s',
		nbre_menages_locaux as 'Menages locaux', 
		nbre_menages_rapatrie as 'Menages rappatri�s',
		theme_developpe as 'Th�me',    
		observation as 'Observation',
		noms_sensibilisateur as 'Noms sensibilisateurs',
		commentaires as 'Commentaires',
		telephone_sensibilisateur as 'Telephone'
	from t_atelier_masse
	where
		num_sensibilisation like '%'+@num_sensibilisation+'%'
	order by num_atelier_masse desc
go
create procedure inserer_atelier_masse
@date_atelier date,
@num_sensibilisation nvarchar(200),
@nbre_hommes int,
@nbre_femmes int,
@nbre_filles int,
@nbre_garcons int,
@nbre_autorite_femmes int,
@nbre_autorite_hommes int,
@nbre_menages_deplaces int,
@nbre_menages_retournes int,
@nbre_menages_locaux int, 
@nbre_menages_rapatrie int,
@theme_developpe nvarchar(200),    
@observation nvarchar(max),
@noms_sensibilisateur nvarchar(200),
@commentaires nvarchar(max),
@telephone_sensibilisateur nvarchar(50)
as
	insert into t_atelier_masse
		(
			date_atelier,
			num_sensibilisation,
			nbre_hommes,
			nbre_femmes,
			nbre_filles,
			nbre_garcons,
			nbre_autorite_femmes,
			nbre_autorite_hommes,
			nbre_menages_deplaces,
			nbre_menages_retournes,
			nbre_menages_locaux,
			nbre_menages_rapatrie,
			theme_developpe,
			observation,
			noms_sensibilisateur,
			commentaires,
			telephone_sensibilisateur		
		)
	values
		(
			@date_atelier,
			@num_sensibilisation,
			@nbre_hommes,
			@nbre_femmes,
			@nbre_filles,
			@nbre_garcons,
			@nbre_autorite_femmes,
			@nbre_autorite_hommes,
			@nbre_menages_deplaces,
			@nbre_menages_retournes,
			@nbre_menages_locaux,
			@nbre_menages_rapatrie,
			@theme_developpe,
			@observation,
			@noms_sensibilisateur,
			@commentaires,
			@telephone_sensibilisateur		
		)
go
create procedure supprimer_atelier_masse
@num_atelier_masse int
as
	delete from t_atelier_masse
		where
			num_atelier_masse like @num_atelier_masse
go
create table t_type_observation ------- question pertinente ou reponse_pertinente
(
    id_type_observ nvarchar(200),
    descr_observ_type nvarchar(200),
    constraint pk_type_observation primary key(id_type_observ)
)
go
create table t_observation_atelier
(
    num_observation int,
    id_type_observ nvarchar(200),
    num_participation int,
    description_observation nvarchar(500),
    constraint pk_observation primary key(num_observation),
    constraint fk_type_observ foreign key(id_type_observ) references t_type_observation(id_type_observ),
    constraint fk_participant_observation foreign key(num_participation) references t_participation_atelier(num_participation)
)
go
create table t_level_user
(
    id_level nvarchar(200),
    description_level nvarchar(200),
    constraint pk_level_user primary key(id_level)
)
go
insert into t_level_user
    (id_level, description_level)
values
    ('Admin','Un admin peut acceder a tous les menus'),
    ('User','Can only access restricted areas')
go
create table t_organisation
(
	code_organisation nvarchar(200),
	description_organisation nvarchar(500),
	constraint pk_organisation primary key(code_organisation)
)
go
create table t_login
(
    num_login int identity,
    nom_utilisateur nvarchar(200),
    mot_de_passe nvarchar(200),
    id_level nvarchar(200),
    user_active int,
	code_organisation nvarchar(200),
    constraint pk_login primary key(num_login),
	constraint fk_level_user_login foreign key(id_level) references t_level_user(id_level) on delete cascade on update cascade,
	constraint fk_organisation_login foreign key(code_organisation) references t_organisation(code_organisation) on delete cascade on update cascade
)
go
create table t_logs
(
    num_log int identity,
    date_log date,
    username nvarchar(200),
    mot_de_passe nvarchar(200),
    ops_done nvarchar(200),
	num_login int,
    constraint pk_logs primary key(num_log),
	constraint fk_logs_logged foreign key(num_login) references t_login(num_login) on delete cascade on update cascade
)
go
-------------------------------------Debut des procedures rapports ------------------------------------------------------------------
create procedure afficher_ateliers_sensibilises
as
	select 
		t_sensibilisation.num_sensibilisation as 'Num. Sensibilisation', 
		t_sensibilisation.date_debut as 'Debut Sensib.',
		t_sensibilisation.date_fin as 'Fin Sensib',
		t_sensibilisation.id_localite as 'Localit�',
		t_atelier.id_atelier as 'Num Atelier',
		t_atelier.theme_developpe as 'Th�me developp�', 
		t_participation_atelier.num_participation as 'Num. Part.',
		t_participation_atelier.date_atelier as 'Date Atelier',
		t_participation_atelier.nom_sensibilisateur as 'Sensibilisateur'
	from            
		t_sensibilisation inner join t_participation_atelier on
			t_sensibilisation.num_sensibilisation = t_participation_atelier.num_sensibilisation inner join 
				t_atelier on t_participation_atelier.id_atelier = t_atelier.id_atelier
	order by 
		t_participation_atelier.date_atelier desc

go
create procedure rechercher_ateliers_sensibilises_par_dates
@date_debut date,
@date_fin date
as
	select 
		t_sensibilisation.num_sensibilisation as 'Num. Sensibilisation', 
		t_sensibilisation.date_debut as 'Debut Sensib.',
		t_sensibilisation.date_fin as 'Fin Sensib',
		t_sensibilisation.id_localite as 'Localit�',
		t_atelier.id_atelier as 'Num Atelier',
		t_atelier.theme_developpe as 'Th�me developp�', 
		t_participation_atelier.num_participation as 'Num. Part.',
		t_participation_atelier.date_atelier as 'Date Atelier',
		t_participation_atelier.nom_sensibilisateur as 'Sensibilisateur'
	from            
		t_sensibilisation inner join t_participation_atelier on
			t_sensibilisation.num_sensibilisation = t_participation_atelier.num_sensibilisation inner join 
				t_atelier on t_participation_atelier.id_atelier = t_atelier.id_atelier
	where
		t_participation_atelier.date_atelier between @date_debut and @date_fin
	order by 
		t_participation_atelier.date_atelier desc
go
create procedure rechercher_ateliers_sensibilises_par_themes
@theme nvarchar(200)
as
	select 
		t_sensibilisation.num_sensibilisation as 'Num. Sensibilisation', 
		t_sensibilisation.date_debut as 'Debut Sensib.',
		t_sensibilisation.date_fin as 'Fin Sensib',
		t_sensibilisation.id_localite as 'Localit�',
		t_atelier.id_atelier as 'Num Atelier',
		t_atelier.theme_developpe as 'Th�me developp�', 
		t_participation_atelier.num_participation as 'Num. Part.',
		t_participation_atelier.date_atelier as 'Date Atelier',
		t_participation_atelier.nom_sensibilisateur as 'Sensibilisateur'
	from            
		t_sensibilisation inner join t_participation_atelier on
			t_sensibilisation.num_sensibilisation = t_participation_atelier.num_sensibilisation inner join 
				t_atelier on t_participation_atelier.id_atelier = t_atelier.id_atelier
	where
		t_atelier.theme_developpe like '%' + @theme + '%'
	order by 
		t_participation_atelier.date_atelier desc
go
create procedure rechercher_ateliers_sensibilises_par_localite
@localite nvarchar(200)
as
	select 
		t_sensibilisation.num_sensibilisation as 'Num. Sensibilisation', 
		t_sensibilisation.date_debut as 'Debut Sensib.',
		t_sensibilisation.date_fin as 'Fin Sensib',
		t_sensibilisation.id_localite as 'Localit�',
		t_atelier.id_atelier as 'Num Atelier',
		t_atelier.theme_developpe as 'Th�me developp�', 
		t_participation_atelier.num_participation as 'Num. Part.',
		t_participation_atelier.date_atelier as 'Date Atelier',
		t_participation_atelier.nom_sensibilisateur as 'Sensibilisateur'
	from            
		t_sensibilisation inner join t_participation_atelier on
			t_sensibilisation.num_sensibilisation = t_participation_atelier.num_sensibilisation inner join 
				t_atelier on t_participation_atelier.id_atelier = t_atelier.id_atelier
	where
		t_sensibilisation.id_localite like '%' + @localite + '%'
	order by 
		t_participation_atelier.date_atelier desc
go
create table t_categorie_agr
(
	id_categorie nvarchar(200),
	description_categorie nvarchar(200),
	constraint pk_categorie_agr primary key(id_categorie)
)
go
------------------------------------Debut codes agrs---------------------------------------------------------------------
create table t_agr
(
	id_agr nvarchar(200),
	description_agr nvarchar(200),
	id_categorie nvarchar(200),
	constraint pk_agr primary key(id_agr),
	constraint fk_categorie_agrs foreign key(id_categorie) references t_categorie_agr(id_categorie)
)
go
create procedure recuperer_agr
as
	select id_agr from t_agr
go
-----------------------------------Fin codes agrs----------------------------------------------------------------------
-----------------------------------Debut codes beneficiaires -----------------------------------------------------------------
create table t_beneficiaires
(
	id_beneficiaire nvarchar(200),
	noms nvarchar(200),
	sexe nvarchar(200),
	vulnerabilite nvarchar(200),
	date_naissance date,
	adresse nvarchar(200),
	telephone nvarchar(200),
	constraint pk_beneficiaire primary key(id_beneficiaire)
)
go
create procedure afficher_beneficiaires
as
	select top 50
		id_beneficiaire as 'Code Beneficiaire',
		noms as 'Noms',
		sexe as 'Sexe',
		vulnerabilite as 'VNRB',
		date_naissance as 'Age',
		adresse as 'Adresse',
		telephone as 'Contact'
	from t_beneficiaires
		order by 
			id_beneficiaire desc
go
---------------------------------Fin codes beneficiaires--------------------------------------------------------------------
create table t_bailleurs
(	
	id_bailleurs nvarchar(200),
	noms nvarchar(200),
	adresse nvarchar(200),
	telephone nvarchar(200),
	email nvarchar(200),
	site_web nvarchar(200),
	constraint pk_bailleur primary key(id_bailleurs)
)
go
------------------------------------------Debut codes Executants------------------------------------------------------------
create table t_executants
(
	id_executant nvarchar(200),
	noms nvarchar(200),
	adresse nvarchar(200),
	telephone nvarchar(200),
	email nvarchar(200),
	site_web nvarchar(200),
	constraint pk_executant primary key(id_executant)
)
go
create procedure recuperer_executants
as
	select id_executant from t_executants
go
------------------------------------------Fin codes Executants------------------------------------------------------------
-------------------------------------------Debut de codes pour projet------------------------------------------------------
create table t_projets
(	
	id_projet nvarchar(200),
	intitule_projet nvarchar(200),
	debut_projet date,
	fin_projet date,
	constraint pk_projet primary key(id_projet)
)
go
create procedure recuperer_projet
as
	select id_projet from t_projets
go
-------------------------------------------Fin de codes pour projet------------------------------------------------------
create table t_assignation_bailleurs
(	
	num_assignation int identity,
	date_debut date,
	id_projet nvarchar(200),
	id_bailleurs nvarchar(200),
	constraint pk_assignation primary key(num_assignation),
	constraint fk_bailleur_ass foreign key(id_bailleurs) references t_bailleurs(id_bailleurs),
	constraint fk_projet_ass foreign key(id_projet) references t_projets(id_projet)
)
go
-----------------------------------------Debut codes distribution---------------------------------------------
create table t_distribution
(
	code_distribution nvarchar(200),
	date_distribution date,
	id_localite nvarchar(200),
	id_projet nvarchar(200),
	id_agr nvarchar(200),
	qte decimal,
	valeur decimal,
	id_executant nvarchar(200),
	observation nvarchar(200),
	constraint pk_distribution primary key(code_distribution),
	constraint fk_projet_distribution foreign key(id_projet) references t_projets(id_projet),
	constraint fk_agr_distribution foreign key(id_agr) references t_agr(id_agr),
	constraint fk_executant_distr foreign key(id_executant) references t_executants(id_executant),
	constraint fk_localite_distrib foreign key(id_localite) references t_localite(id_localite)
)
go
create procedure afficher_distribution
as
	select top 50
		code_distribution as 'Code',
		date_distribution as 'Date',
		id_localite as 'Lieu',
		id_projet as 'Projet',
		id_agr as 'AGR',
		qte as 'Qte',
		valeur as 'Valeur',
		id_executant as 'Executant',
		observation as 'Observation'
	from t_distribution
		order by code_distribution desc
go
create procedure enregistrer_distribution
@code_distribution nvarchar(200),
@date_distribution date,
@id_localite nvarchar(200),
@id_projet nvarchar(200),
@id_agr nvarchar(200),
@qte decimal,
@valeur decimal,
@id_executant nvarchar(200),
@observation nvarchar(200)
as
	merge into t_distribution
	using (select @code_distribution as x_id) as x_source
	on (x_source.x_id=t_distribution.code_distribution)
	when matched then
		update
			set
				date_distribution=@date_distribution,
				id_localite=@id_localite,
				id_projet=@id_projet,
				id_agr=@id_agr,
				qte=@qte,
				valeur=@valeur,
				id_executant=@id_executant,
				observation=@observation
	when not matched then
		insert 
			(code_distribution, date_distribution, id_localite, id_projet, id_agr, qte, valeur, id_executant, observation)
		values
			(@code_distribution, @date_distribution, @id_localite, @id_projet, @id_agr, @qte, @valeur, @id_executant, @observation);
go
create procedure supprimer_distribution
@code_distribution nvarchar(200)
as
	delete from t_distribution
		where code_distribution like @code_distribution
go
create procedure rechercher_distribution_parcode
@code_distribution nvarchar(200)
as
	select top 50
		code_distribution as 'Code',
		date_distribution as 'Date',
		id_localite as 'Lieu',
		id_projet as 'Projet',
		id_agr as 'AGR',
		qte as 'Qte',
		valeur as 'Valeur',
		id_executant as 'Executant',
		observation as 'Observation'
	from t_distribution
	where
		code_distribution like '%'+@code_distribution+'%'
	order by code_distribution desc
go
create procedure rechercher_distrtibution_parlocalite
@id_localite nvarchar(200)
as
	select top 50
		code_distribution as 'Code',
		date_distribution as 'Date',
		id_localite as 'Lieu',
		id_projet as 'Projet',
		id_agr as 'AGR',
		qte as 'Qte',
		valeur as 'Valeur',
		id_executant as 'Executant',
		observation as 'Observation'
	from t_distribution
	where
		id_localite like '%'+@id_localite+'%'
	order by code_distribution desc
go
create procedure rechercher_distrtibution_parprojet
@id_projet nvarchar(200)
as
	select top 50
		code_distribution as 'Code',
		date_distribution as 'Date',
		id_localite as 'Lieu',
		id_projet as 'Projet',
		id_agr as 'AGR',
		qte as 'Qte',
		valeur as 'Valeur',
		id_executant as 'Executant',
		observation as 'Observation'
	from t_distribution
	where
		id_projet like '%'+@id_projet+'%'
	order by code_distribution desc
go
create procedure rechercher_distribution_pardate
@date_distribution nvarchar(200)
as
	select top 50
		code_distribution as 'Code',
		date_distribution as 'Date',
		id_localite as 'Lieu',
		id_projet as 'Projet',
		id_agr as 'AGR',
		qte as 'Qte',
		valeur as 'Valeur',
		id_executant as 'Executant',
		observation as 'Observation'
	from t_distribution
	where
		date_distribution like '%'+@date_distribution+'%'
	order by code_distribution desc
go
--------------------------------------Fin codes distribution---------------------------------------------
create table t_assignation_beneficiaires
(
	num_assignation_benef int identity,
	id_beneficiaire nvarchar(200),
	code_distribution nvarchar(200),
	date_assignation date,
	constraint pk_assignation_benef primary key(num_assignation_benef),
	constraint fk_benef_assgn foreign key(id_beneficiaire) references t_beneficiaires(id_beneficiaire),
	constraint fk_distrib_ass foreign key(code_distribution) references t_distribution(code_distribution)
)
go
create procedure afficher_rapport_conflit
as
	select
		t_conflit.num_conflit as 'Code conflit', 
		t_conflit.id_type_conflit as 'Type Conflit', 
		t_conflit.id_nature_conflit as 'Nature du conflit', 
		t_conflit.date_debut_conflit as 'Debut Conflit', 
		t_conflit.id_localite as 'Localite', 
		t_localite.id_groupement as 'Groupement', 
		t_assignation_resolution.id_resolution as 'Etat resolution', 
        t_assignation_resolution.date_resolution as 'Date Resolution'
	from
		t_localite inner join
        t_conflit inner join
        t_mediation on t_conflit.num_conflit = t_mediation.num_conflit inner join
        t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
								 on t_localite.id_localite = t_conflit.id_localite
	order by
		t_assignation_resolution.date_resolution desc
go
create procedure search_rapport_conflit_by_localite
@id_localite nvarchar(50)
as
	select
		t_conflit.num_conflit as 'Code conflit', 
		t_conflit.id_type_conflit as 'Type Conflit', 
		t_conflit.id_nature_conflit as 'Nature du conflit', 
		t_conflit.date_debut_conflit as 'Debut Conflit', 
		t_conflit.id_localite as 'Localite', 
		t_localite.id_groupement as 'Groupement', 
		t_assignation_resolution.id_resolution as 'Etat resolution', 
        t_assignation_resolution.date_resolution as 'Date Resolution'
	from
		t_localite inner join
        t_conflit inner join
        t_mediation on t_conflit.num_conflit = t_mediation.num_conflit inner join
        t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
								 on t_localite.id_localite = t_conflit.id_localite
	where
		t_conflit.id_localite like '%'+@id_localite+'%'
	order by
		t_assignation_resolution.date_resolution desc
go
create procedure search_rapport_conflit_by_conflit
@num_conflit nvarchar(50)
as
	select
		t_conflit.num_conflit as 'Code conflit', 
		t_conflit.id_type_conflit as 'Type Conflit', 
		t_conflit.id_nature_conflit as 'Nature du conflit', 
		t_conflit.date_debut_conflit as 'Debut Conflit', 
		t_conflit.id_localite as 'Localite', 
		t_localite.id_groupement as 'Groupement', 
		t_assignation_resolution.id_resolution as 'Etat resolution', 
        t_assignation_resolution.date_resolution as 'Date Resolution'
	from
		t_localite inner join
        t_conflit inner join
        t_mediation on t_conflit.num_conflit = t_mediation.num_conflit inner join
        t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
								 on t_localite.id_localite = t_conflit.id_localite
	where
		t_conflit.num_conflit like '%'+@num_conflit+'%'
	order by
		t_assignation_resolution.date_resolution desc
go
create procedure search_rapport_conflit_by_typeconflit
@type_conflit nvarchar(50)
as
	select
		t_conflit.num_conflit as 'Code conflit', 
		t_conflit.id_type_conflit as 'Type Conflit', 
		t_conflit.id_nature_conflit as 'Nature du conflit', 
		t_conflit.date_debut_conflit as 'Debut Conflit', 
		t_conflit.id_localite as 'Localite', 
		t_localite.id_groupement as 'Groupement', 
		t_assignation_resolution.id_resolution as 'Etat resolution', 
        t_assignation_resolution.date_resolution as 'Date Resolution'
	from
		t_localite inner join
        t_conflit inner join
        t_mediation on t_conflit.num_conflit = t_mediation.num_conflit inner join
        t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
								 on t_localite.id_localite = t_conflit.id_localite
	where
		t_conflit.id_type_conflit like '%'+@type_conflit+'%'
	order by
		t_assignation_resolution.date_resolution desc
go
create procedure search_rapport_conflit_by_natureconflit
@nature_conflit nvarchar(50)
as
	select
		t_conflit.num_conflit as 'Code conflit', 
		t_conflit.id_type_conflit as 'Type Conflit', 
		t_conflit.id_nature_conflit as 'Nature du conflit', 
		t_conflit.date_debut_conflit as 'Debut Conflit', 
		t_conflit.id_localite as 'Localite', 
		t_localite.id_groupement as 'Groupement', 
		t_assignation_resolution.id_resolution as 'Etat resolution', 
        t_assignation_resolution.date_resolution as 'Date Resolution'
	from
		t_localite inner join
        t_conflit inner join
        t_mediation on t_conflit.num_conflit = t_mediation.num_conflit inner join
        t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
								 on t_localite.id_localite = t_conflit.id_localite
	where
		t_conflit.id_nature_conflit like '%'+@nature_conflit+'%'
	order by
		t_assignation_resolution.date_resolution desc
go
create procedure search_rapport_conflit_by_groupement
@id_groupement nvarchar(50)
as
	select
		t_conflit.num_conflit as 'Code conflit', 
		t_conflit.id_type_conflit as 'Type Conflit', 
		t_conflit.id_nature_conflit as 'Nature du conflit', 
		t_conflit.date_debut_conflit as 'Debut Conflit', 
		t_conflit.id_localite as 'Localite', 
		t_localite.id_groupement as 'Groupement', 
		t_assignation_resolution.id_resolution as 'Etat resolution', 
        t_assignation_resolution.date_resolution as 'Date Resolution'
	from
		t_localite inner join
        t_conflit inner join
        t_mediation on t_conflit.num_conflit = t_mediation.num_conflit inner join
        t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
								 on t_localite.id_localite = t_conflit.id_localite
	where
		t_localite.id_groupement like '%'+@id_groupement+'%'
	order by
		t_assignation_resolution.date_resolution desc
go
create procedure search_rapport_conflit_by_etat
@etat nvarchar(50)
as
	select
		t_conflit.num_conflit as 'Code conflit', 
		t_conflit.id_type_conflit as 'Type Conflit', 
		t_conflit.id_nature_conflit as 'Nature du conflit', 
		t_conflit.date_debut_conflit as 'Debut Conflit', 
		t_conflit.id_localite as 'Localite', 
		t_localite.id_groupement as 'Groupement', 
		t_assignation_resolution.id_resolution as 'Etat resolution', 
        t_assignation_resolution.date_resolution as 'Date Resolution'
	from
		t_localite inner join
        t_conflit inner join
        t_mediation on t_conflit.num_conflit = t_mediation.num_conflit inner join
        t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
								 on t_localite.id_localite = t_conflit.id_localite
	where
		t_assignation_resolution.id_resolution  like '%'+@etat+'%'
	order by
		t_assignation_resolution.date_resolution desc
go
create procedure search_rapport_conflit_by_date_conflit
@date_un date,
@date_deux date
as
	select
		t_conflit.num_conflit as 'Code conflit', 
		t_conflit.id_type_conflit as 'Type Conflit', 
		t_conflit.id_nature_conflit as 'Nature du conflit', 
		t_conflit.date_debut_conflit as 'Debut Conflit', 
		t_conflit.id_localite as 'Localite', 
		t_localite.id_groupement as 'Groupement', 
		t_assignation_resolution.id_resolution as 'Etat resolution', 
        t_assignation_resolution.date_resolution as 'Date Resolution'
	from
		t_localite inner join
        t_conflit inner join
        t_mediation on t_conflit.num_conflit = t_mediation.num_conflit inner join
        t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
								 on t_localite.id_localite = t_conflit.id_localite
	where
		t_conflit.date_debut_conflit  between @date_un and @date_deux
	order by
		t_conflit.date_debut_conflit desc
go
create procedure search_rapport_conflit_by_date_resolution
@date_un date,
@date_deux date
as
	select
		t_conflit.num_conflit as 'Code conflit', 
		t_conflit.id_type_conflit as 'Type Conflit', 
		t_conflit.id_nature_conflit as 'Nature du conflit', 
		t_conflit.date_debut_conflit as 'Debut Conflit', 
		t_conflit.id_localite as 'Localite', 
		t_localite.id_groupement as 'Groupement', 
		t_assignation_resolution.id_resolution as 'Etat resolution', 
        t_assignation_resolution.date_resolution as 'Date Resolution'
	from
		t_localite inner join
        t_conflit inner join
        t_mediation on t_conflit.num_conflit = t_mediation.num_conflit inner join
        t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
								 on t_localite.id_localite = t_conflit.id_localite
	where
		t_assignation_resolution.date_resolution  between @date_un and @date_deux
	order by 
		t_assignation_resolution.date_resolution desc
go
create procedure chart_nombre_menage
as
	select count(id_menage) from t_menages
go
create procedure chart_nombre_membre
as
	select count(id_membre) from t_membres
go

create procedure chart_nombre_conflits
as
	select count(num_conflit) from t_conflit
go

create procedure chart_nombre_conflits_resolus
as
select count(*)
from t_assignation_resolution 
	inner join
        t_conflit on t_assignation_resolution.num_conflit = t_conflit.num_conflit
	where
		t_assignation_resolution.id_resolution like 'R�solu'
go
create procedure chart_nombre_conflits_encours
as
select count(*)
from t_assignation_resolution 
	inner join
        t_conflit on t_assignation_resolution.num_conflit = t_conflit.num_conflit
	where
		t_assignation_resolution.id_resolution like 'En cours'
go
create procedure chart_nombre_conflits_refere
as
select count(*)
from t_assignation_resolution 
	inner join
        t_conflit on t_assignation_resolution.num_conflit = t_conflit.num_conflit
	where
		t_assignation_resolution.id_resolution like 'Refer�'
go
create procedure chart_nombre_conflits_classe
as
select count(*)
from t_assignation_resolution 
	inner join
        t_conflit on t_assignation_resolution.num_conflit = t_conflit.num_conflit
	where
		t_assignation_resolution.id_resolution like 'Class�'
go
create procedure chart_nombre_sensibilisations
as
	select count(distinct num_sensibilisation)
	from t_sensibilisation 	
go
create procedure chart_nombre_hommes_sensibilises
as
select 
	sum(t_atelier_masse.nbre_hommes)
from            
	t_atelier_masse 
			inner join
                 t_sensibilisation on t_atelier_masse.num_sensibilisation = t_sensibilisation.num_sensibilisation
go
create procedure chart_nombre_femmes_sensibilises
as
select 
	sum(t_atelier_masse.nbre_femmes)
from            
	t_atelier_masse 
			inner join
				t_sensibilisation on t_atelier_masse.num_sensibilisation = t_sensibilisation.num_sensibilisation
go
create procedure chart_nombre_filles_sensibilises
as
select 
	sum(t_atelier_masse.nbre_filles)
from            
	t_atelier_masse 
			inner join
				t_sensibilisation on t_atelier_masse.num_sensibilisation = t_sensibilisation.num_sensibilisation
go
create procedure chart_nombre_garcons_sensibilises
as
select 
	sum(t_atelier_masse.nbre_garcons)
from            
	t_atelier_masse 
			inner join
				t_sensibilisation on t_atelier_masse.num_sensibilisation = t_sensibilisation.num_sensibilisation
go
create procedure liste_conflits_par_groupements
as
select
	t_conflit.num_conflit, 
	t_conflit.id_type_conflit, 
	t_conflit.id_nature_conflit, 
	t_conflit.date_debut_conflit, 
	t_conflit.id_localite, 
	t_localite.id_groupement, 
	t_assignation_resolution.id_resolution, 
    t_assignation_resolution.date_resolution
from           
	t_localite inner join
    t_conflit inner join
    t_mediation on t_conflit.num_conflit = t_mediation.num_conflit inner join
    t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit on t_localite.id_localite = t_conflit.id_localite
go

create procedure details_menages_par_conflit
@date_un date,
@date_deux date
as
select        
	t_conflit.num_conflit, 
	t_mediation.date_debut_mediation, 
	t_conflit.id_type_conflit, 
	t_conflit.id_localite, 
	t_parties.id_typ_partie, 
	t_menages.id_menage, 
	t_membres.noms, 
	t_menages.id_situation, 
    t_menages.total_homme, 
	t_menages.total_femme, 
	t_menages.total_garcons, 
	t_menages.total_filles, 
	t_menages.total_homme + t_menages.total_femme + t_menages.total_garcons + t_menages.total_filles as total,
	t_assignation_resolution.id_resolution, 
	t_assignation_resolution.date_resolution	
from            
	t_conflit 
		inner join
			t_parties on t_conflit.num_conflit = t_parties.num_conflit 
		inner join
			t_menages on t_parties.id_menage = t_menages.id_menage 
		inner join
			t_membres on t_menages.id_menage = t_membres.id_menage 
		inner join
			t_mediation on t_conflit.num_conflit = t_mediation.num_conflit 
		inner join
			t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit
	where 
		t_mediation.date_debut_mediation between @date_un and @date_deux
	order by
		t_conflit.num_conflit asc
go
select * from t_menages

select * from t_membres 
	where id_menage like 'UNH/A/MNG'+'%'

select * from t_menages
	where
		id_menage not in (select id_menage from t_membres)

select * from t_menages
	where id_menage like 'HATEG'+'%'
go
create procedure infos_general_conflits
as
	select        
		t_territoire.id_province as 'Province', 
		t_chefferie.id_territoire as 'Territoire', 
		t_groupement.id_chefferie as 'Chefferie', 
		t_localite.id_groupement as 'Groupement', 
		t_conflit.id_localite as 'Localite', 
		t_conflit.num_conflit as 'Code Conflit', 
		t_conflit.id_type_conflit as 'Type Conflit', 
        t_conflit.id_nature_conflit as 'Nature Conflit', 
		t_assignation_resolution.id_resolution as 'Etat Resolution', 
		t_parties.id_typ_partie as 'Partie', 
		t_parties.id_menage, t_menages.id_situation as 'Sit. Men', 
		t_menages.total_homme as 'Total Hommes', 
		t_menages.total_femme as 'Total Femmes', 
        t_menages.total_garcons as 'Total Garcons', 
		t_menages.total_filles as 'Total Filles',
		total_homme + total_femme + total_filles + total_garcons as 'Total Menage' 
	from            
		t_chefferie 
			inner join
        t_territoire on t_chefferie.id_territoire = t_territoire.id_territoire 
			inner join
		t_groupement on t_chefferie.id_chefferie = t_groupement.id_chefferie 
			inner join
		t_localite on t_groupement.id_groupement = t_localite.id_groupement 
			inner join
		t_conflit on t_localite.id_localite = t_conflit.id_localite 
			inner join
		t_parties on t_conflit.num_conflit = t_parties.num_conflit 
			inner join
		t_menages on t_parties.id_menage = t_menages.id_menage 
			inner join
		t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit

go
---------------- Toutes les recherches par periode sur le nombre de conflits------------------------------------------------------------------
------------ 1. Total informations generales sur le conflit et les menages impliques dedans---------------------------------------------------
create procedure stats_total_conflit_parperiode
@date_un date,
@date_deux date
	as
		select  count(distinct t_conflit.num_conflit)      
			--t_conflit.id_localite, 
			--t_conflit.num_conflit, 
			--t_mediation.date_debut_mediation, 
			--t_mediation.date_fin_mediation, 
			--t_assignation_resolution.id_resolution, 
			--t_parties.id_typ_partie, 
            --t_menages.total_homme, 
			--t_menages.total_femme, 
			--t_menages.total_garcons, 
			--t_menages.total_filles
		from            
			t_conflit 
				inner join
            		t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
				inner join
            		t_mediation on t_conflit.num_conflit = t_mediation.num_conflit 
				inner join
            		t_parties on t_conflit.num_conflit = t_parties.num_conflit 
				inner join
            		t_menages on t_parties.id_menage = t_menages.id_menage
		where
			t_mediation.date_debut_mediation between @date_un and @date_deux
go


create procedure stats_total_hommes_conflit_parperiode
@date_un date,
@date_deux date
	as
		select  
			--count(distinct t_conflit.num_conflit)      
			--t_conflit.id_localite, 
			--t_conflit.num_conflit, 
			--t_mediation.date_debut_mediation, 
			--t_mediation.date_fin_mediation, 
			--t_assignation_resolution.id_resolution, 
			--t_parties.id_typ_partie, 
            sum(t_menages.total_homme)--, 
			--t_menages.total_femme, 
			--t_menages.total_garcons, 
			--t_menages.total_filles
		from            
			t_conflit 
				inner join
            		t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
				inner join
            		t_mediation on t_conflit.num_conflit = t_mediation.num_conflit 
				inner join
            		t_parties on t_conflit.num_conflit = t_parties.num_conflit 
				inner join
            		t_menages on t_parties.id_menage = t_menages.id_menage
		where
			t_mediation.date_debut_mediation between @date_un and @date_deux
go

create procedure stats_total_femmes_conflit_parperiode
@date_un date,
@date_deux date
	as
		select  
			--count(distinct t_conflit.num_conflit)      
			--t_conflit.id_localite, 
			--t_conflit.num_conflit, 
			--t_mediation.date_debut_mediation, 
			--t_mediation.date_fin_mediation, 
			--t_assignation_resolution.id_resolution, 
			--t_parties.id_typ_partie, 
            --sum(t_menages.total_homme)--, 
			sum(t_menages.total_femme)--, 
			--t_menages.total_garcons, 
			--t_menages.total_filles
		from            
			t_conflit 
				inner join
            		t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
				inner join
            		t_mediation on t_conflit.num_conflit = t_mediation.num_conflit 
				inner join
            		t_parties on t_conflit.num_conflit = t_parties.num_conflit 
				inner join
            		t_menages on t_parties.id_menage = t_menages.id_menage
		where
			t_mediation.date_debut_mediation between @date_un and @date_deux
go
create procedure stats_total_filles_conflit_parperiode
@date_un date,
@date_deux date
	as
		select  
			--count(distinct t_conflit.num_conflit)      
			--t_conflit.id_localite, 
			--t_conflit.num_conflit, 
			--t_mediation.date_debut_mediation, 
			--t_mediation.date_fin_mediation, 
			--t_assignation_resolution.id_resolution, 
			--t_parties.id_typ_partie, 
            --sum(t_menages.total_homme)--, 
			--sum(t_menages.total_femme)--, 
			--t_menages.total_garcons, 
			sum(t_menages.total_filles)
		from            
			t_conflit 
				inner join
            		t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
				inner join
            		t_mediation on t_conflit.num_conflit = t_mediation.num_conflit 
				inner join
            		t_parties on t_conflit.num_conflit = t_parties.num_conflit 
				inner join
            		t_menages on t_parties.id_menage = t_menages.id_menage
		where
			t_mediation.date_debut_mediation between @date_un and @date_deux
go
create procedure stats_total_garcons_conflit_parperiode
@date_un date,
@date_deux date
	as
		select  
			--count(distinct t_conflit.num_conflit)      
			--t_conflit.id_localite, 
			--t_conflit.num_conflit, 
			--t_mediation.date_debut_mediation, 
			--t_mediation.date_fin_mediation, 
			--t_assignation_resolution.id_resolution, 
			--t_parties.id_typ_partie, 
            --sum(t_menages.total_homme)--, 
			--sum(t_menages.total_femme)--, 
			sum(t_menages.total_garcons)--, 
			--sum(t_menages.total_filles)
		from            
			t_conflit 
				inner join
            		t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
				inner join
            		t_mediation on t_conflit.num_conflit = t_mediation.num_conflit 
				inner join
            		t_parties on t_conflit.num_conflit = t_parties.num_conflit 
				inner join
            		t_menages on t_parties.id_menage = t_menages.id_menage
		where
			t_mediation.date_debut_mediation between @date_un and @date_deux
go
create procedure stats_total_menages_conflit_parperiode
@date_un date,
@date_deux date
	as
		select  
			--count(distinct t_conflit.num_conflit)      
			--t_conflit.id_localite, 
			--t_conflit.num_conflit, 
			--t_mediation.date_debut_mediation, 
			--t_mediation.date_fin_mediation, 
			--t_assignation_resolution.id_resolution, 
			--t_parties.id_typ_partie, 
            --sum(t_menages.total_homme)--, 
			--sum(t_menages.total_femme)--, 
			--sum(t_menages.total_garcons)--, 
			--sum(t_menages.total_filles),
			sum(total_femme) + sum(total_filles) + sum(total_garcons) + sum(total_homme) as total_menage
		from            
			t_conflit 
				inner join
            		t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
				inner join
            		t_mediation on t_conflit.num_conflit = t_mediation.num_conflit 
				inner join
            		t_parties on t_conflit.num_conflit = t_parties.num_conflit 
				inner join
            		t_menages on t_parties.id_menage = t_menages.id_menage
		where
			t_mediation.date_debut_mediation between @date_un and @date_deux
go
create procedure stats_conflit_resolu_parperiode
@date_un date,
@date_deux date,
@id_resolution nvarchar(50)
	as
		select  count(distinct t_conflit.num_conflit)      
			--t_conflit.id_localite, 
			--t_conflit.num_conflit, 
			--t_mediation.date_debut_mediation, 
			--t_mediation.date_fin_mediation, 
			--t_assignation_resolution.id_resolution, 
			--t_parties.id_typ_partie, 
            --t_menages.total_homme, 
			--t_menages.total_femme, 
			--t_menages.total_garcons, 
			--t_menages.total_filles
		from            
			t_conflit 
				inner join
            		t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
				inner join
            		t_mediation on t_conflit.num_conflit = t_mediation.num_conflit 
				inner join
            		t_parties on t_conflit.num_conflit = t_parties.num_conflit 
				inner join
            		t_menages on t_parties.id_menage = t_menages.id_menage
		where
			id_resolution like @id_resolution and t_mediation.date_debut_mediation between @date_un and @date_deux
go


create procedure stats_hommes_conflit_resolu_parperiode
@date_un date,
@date_deux date,
@id_resolution nvarchar(50)
	as
		select  
			--count(distinct t_conflit.num_conflit)      
			--t_conflit.id_localite, 
			--t_conflit.num_conflit, 
			--t_mediation.date_debut_mediation, 
			--t_mediation.date_fin_mediation, 
			--t_assignation_resolution.id_resolution, 
			--t_parties.id_typ_partie, 
            sum(t_menages.total_homme)--, 
			--t_menages.total_femme, 
			--t_menages.total_garcons, 
			--t_menages.total_filles
		from            
			t_conflit 
				inner join
            		t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
				inner join
            		t_mediation on t_conflit.num_conflit = t_mediation.num_conflit 
				inner join
            		t_parties on t_conflit.num_conflit = t_parties.num_conflit 
				inner join
            		t_menages on t_parties.id_menage = t_menages.id_menage
		where
			id_resolution like @id_resolution and t_mediation.date_debut_mediation between @date_un and @date_deux
go

create procedure stats_femmes_conflit_resolus_parperiode
@date_un date,
@date_deux date,
@id_resolution nvarchar(50)
	as
		select  
			--count(distinct t_conflit.num_conflit)      
			--t_conflit.id_localite, 
			--t_conflit.num_conflit, 
			--t_mediation.date_debut_mediation, 
			--t_mediation.date_fin_mediation, 
			--t_assignation_resolution.id_resolution, 
			--t_parties.id_typ_partie, 
            --sum(t_menages.total_homme)--, 
			sum(t_menages.total_femme)--, 
			--t_menages.total_garcons, 
			--t_menages.total_filles
		from            
			t_conflit 
				inner join
            		t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
				inner join
            		t_mediation on t_conflit.num_conflit = t_mediation.num_conflit 
				inner join
            		t_parties on t_conflit.num_conflit = t_parties.num_conflit 
				inner join
            		t_menages on t_parties.id_menage = t_menages.id_menage
		where
			id_resolution like @id_resolution and t_mediation.date_debut_mediation between @date_un and @date_deux
go
create procedure stats_filles_conflit_resolus_parperiode
@date_un date,
@date_deux date,
@id_resolution nvarchar(50)
	as
		select  
			--count(distinct t_conflit.num_conflit)      
			--t_conflit.id_localite, 
			--t_conflit.num_conflit, 
			--t_mediation.date_debut_mediation, 
			--t_mediation.date_fin_mediation, 
			--t_assignation_resolution.id_resolution, 
			--t_parties.id_typ_partie, 
            --sum(t_menages.total_homme)--, 
			--sum(t_menages.total_femme)--, 
			--t_menages.total_garcons, 
			sum(t_menages.total_filles)
		from            
			t_conflit 
				inner join
            		t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
				inner join
            		t_mediation on t_conflit.num_conflit = t_mediation.num_conflit 
				inner join
            		t_parties on t_conflit.num_conflit = t_parties.num_conflit 
				inner join
            		t_menages on t_parties.id_menage = t_menages.id_menage
		where
			id_resolution like @id_resolution and t_mediation.date_debut_mediation between @date_un and @date_deux
go
create procedure stats_garcons_conflit_resolus_parperiode
@date_un date,
@date_deux date,
@id_resolution nvarchar(50)
	as
		select  
			--count(distinct t_conflit.num_conflit)      
			--t_conflit.id_localite, 
			--t_conflit.num_conflit, 
			--t_mediation.date_debut_mediation, 
			--t_mediation.date_fin_mediation, 
			--t_assignation_resolution.id_resolution, 
			--t_parties.id_typ_partie, 
            --sum(t_menages.total_homme)--, 
			--sum(t_menages.total_femme)--, 
			sum(t_menages.total_garcons)--, 
			--sum(t_menages.total_filles)
		from            
			t_conflit 
				inner join
            		t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
				inner join
            		t_mediation on t_conflit.num_conflit = t_mediation.num_conflit 
				inner join
            		t_parties on t_conflit.num_conflit = t_parties.num_conflit 
				inner join
            		t_menages on t_parties.id_menage = t_menages.id_menage
		where
			id_resolution like @id_resolution and t_mediation.date_debut_mediation between @date_un and @date_deux
go
create procedure stats_menages_conflit_resolus_parperiode
@date_un date,
@date_deux date,
@id_resolution nvarchar(50)
	as
		select  
			--count(distinct t_conflit.num_conflit)      
			--t_conflit.id_localite, 
			--t_conflit.num_conflit, 
			--t_mediation.date_debut_mediation, 
			--t_mediation.date_fin_mediation, 
			--t_assignation_resolution.id_resolution, 
			--t_parties.id_typ_partie, 
            --sum(t_menages.total_homme)--, 
			--sum(t_menages.total_femme)--, 
			--sum(t_menages.total_garcons)--, 
			--sum(t_menages.total_filles),
			sum(total_femme) + sum(total_filles) + sum(total_garcons) + sum(total_homme) as total_menage
		from            
			t_conflit 
				inner join
            		t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
				inner join
            		t_mediation on t_conflit.num_conflit = t_mediation.num_conflit 
				inner join
            		t_parties on t_conflit.num_conflit = t_parties.num_conflit 
				inner join
            		t_menages on t_parties.id_menage = t_menages.id_menage
		where
			id_resolution like @id_resolution and t_mediation.date_debut_mediation between @date_un and @date_deux
go
------------ 1. End of block -----------------------------------------------------------------------------------------------------------------

------------ 2. Total informations generales sur le conflit et les menages impliques dedans par localite--------------------------------------
create procedure stats_total_conflit_parlocalite
@date_un date,
@date_deux date,
@id_localite nvarchar(50)
	as
		select  count(distinct t_conflit.num_conflit)      
			--t_conflit.id_localite, 
			--t_conflit.num_conflit, 
			--t_mediation.date_debut_mediation, 
			--t_mediation.date_fin_mediation, 
			--t_assignation_resolution.id_resolution, 
			--t_parties.id_typ_partie, 
            --t_menages.total_homme, 
			--t_menages.total_femme, 
			--t_menages.total_garcons, 
			--t_menages.total_filles
		from            
			t_conflit 
				inner join
            		t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
				inner join
            		t_mediation on t_conflit.num_conflit = t_mediation.num_conflit 
				inner join
            		t_parties on t_conflit.num_conflit = t_parties.num_conflit 
				inner join
            		t_menages on t_parties.id_menage = t_menages.id_menage
		where
			id_localite like @id_localite and t_mediation.date_debut_mediation between @date_un and @date_deux
go


create procedure stats_total_hommes_conflit_parlocalite
@date_un date,
@date_deux date,
@id_localite nvarchar(50)
	as
		select  
			--count(distinct t_conflit.num_conflit)      
			--t_conflit.id_localite, 
			--t_conflit.num_conflit, 
			--t_mediation.date_debut_mediation, 
			--t_mediation.date_fin_mediation, 
			--t_assignation_resolution.id_resolution, 
			--t_parties.id_typ_partie, 
            sum(t_menages.total_homme)--, 
			--t_menages.total_femme, 
			--t_menages.total_garcons, 
			--t_menages.total_filles
		from            
			t_conflit 
				inner join
            		t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
				inner join
            		t_mediation on t_conflit.num_conflit = t_mediation.num_conflit 
				inner join
            		t_parties on t_conflit.num_conflit = t_parties.num_conflit 
				inner join
            		t_menages on t_parties.id_menage = t_menages.id_menage
		where
			id_localite like @id_localite and t_mediation.date_debut_mediation between @date_un and @date_deux
go

create procedure stats_total_femmes_conflit_parlocalite
@date_un date,
@date_deux date,
@id_localite nvarchar(50)
	as
		select  
			--count(distinct t_conflit.num_conflit)      
			--t_conflit.id_localite, 
			--t_conflit.num_conflit, 
			--t_mediation.date_debut_mediation, 
			--t_mediation.date_fin_mediation, 
			--t_assignation_resolution.id_resolution, 
			--t_parties.id_typ_partie, 
            --sum(t_menages.total_homme)--, 
			sum(t_menages.total_femme)--, 
			--t_menages.total_garcons, 
			--t_menages.total_filles
		from            
			t_conflit 
				inner join
            		t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
				inner join
            		t_mediation on t_conflit.num_conflit = t_mediation.num_conflit 
				inner join
            		t_parties on t_conflit.num_conflit = t_parties.num_conflit 
				inner join
            		t_menages on t_parties.id_menage = t_menages.id_menage
		where
			id_localite like @id_localite and t_mediation.date_debut_mediation between @date_un and @date_deux
go
create procedure stats_total_filles_conflit_parlocalite
@date_un date,
@date_deux date,
@id_localite nvarchar(50)
	as
		select  
			--count(distinct t_conflit.num_conflit)      
			--t_conflit.id_localite, 
			--t_conflit.num_conflit, 
			--t_mediation.date_debut_mediation, 
			--t_mediation.date_fin_mediation, 
			--t_assignation_resolution.id_resolution, 
			--t_parties.id_typ_partie, 
            --sum(t_menages.total_homme)--, 
			--sum(t_menages.total_femme)--, 
			--t_menages.total_garcons, 
			sum(t_menages.total_filles)
		from            
			t_conflit 
				inner join
            		t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
				inner join
            		t_mediation on t_conflit.num_conflit = t_mediation.num_conflit 
				inner join
            		t_parties on t_conflit.num_conflit = t_parties.num_conflit 
				inner join
            		t_menages on t_parties.id_menage = t_menages.id_menage
		where
			id_localite like @id_localite and t_mediation.date_debut_mediation between @date_un and @date_deux
go
create procedure stats_total_garcons_conflit_parlocalite
@date_un date,
@date_deux date,
@id_localite nvarchar(50)
	as
		select  
			--count(distinct t_conflit.num_conflit)      
			--t_conflit.id_localite, 
			--t_conflit.num_conflit, 
			--t_mediation.date_debut_mediation, 
			--t_mediation.date_fin_mediation, 
			--t_assignation_resolution.id_resolution, 
			--t_parties.id_typ_partie, 
            --sum(t_menages.total_homme)--, 
			--sum(t_menages.total_femme)--, 
			sum(t_menages.total_garcons)--, 
			--sum(t_menages.total_filles)
		from            
			t_conflit 
				inner join
            		t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
				inner join
            		t_mediation on t_conflit.num_conflit = t_mediation.num_conflit 
				inner join
            		t_parties on t_conflit.num_conflit = t_parties.num_conflit 
				inner join
            		t_menages on t_parties.id_menage = t_menages.id_menage
		where
			id_localite like @id_localite and t_mediation.date_debut_mediation between @date_un and @date_deux
go
create procedure stats_total_menages_conflit_parlocalite
@date_un date,
@date_deux date,
@id_localite nvarchar(50)
	as
		select  
			--count(distinct t_conflit.num_conflit)      
			--t_conflit.id_localite, 
			--t_conflit.num_conflit, 
			--t_mediation.date_debut_mediation, 
			--t_mediation.date_fin_mediation, 
			--t_assignation_resolution.id_resolution, 
			--t_parties.id_typ_partie, 
            --sum(t_menages.total_homme)--, 
			--sum(t_menages.total_femme)--, 
			--sum(t_menages.total_garcons)--, 
			--sum(t_menages.total_filles),
			sum(total_femme) + sum(total_filles) + sum(total_garcons) + sum(total_homme) as total_menage
		from            
			t_conflit 
				inner join
            		t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
				inner join
            		t_mediation on t_conflit.num_conflit = t_mediation.num_conflit 
				inner join
            		t_parties on t_conflit.num_conflit = t_parties.num_conflit 
				inner join
            		t_menages on t_parties.id_menage = t_menages.id_menage
		where
			id_localite like @id_localite and t_mediation.date_debut_mediation between @date_un and @date_deux
go
create procedure stats_conflit_resolu_parlocalite
@date_un date,
@date_deux date,
@id_resolution nvarchar(50),
@id_localite nvarchar(50)
	as
		select  count(distinct t_conflit.num_conflit)      
			--t_conflit.id_localite, 
			--t_conflit.num_conflit, 
			--t_mediation.date_debut_mediation, 
			--t_mediation.date_fin_mediation, 
			--t_assignation_resolution.id_resolution, 
			--t_parties.id_typ_partie, 
            --t_menages.total_homme, 
			--t_menages.total_femme, 
			--t_menages.total_garcons, 
			--t_menages.total_filles
		from            
			t_conflit 
				inner join
            		t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
				inner join
            		t_mediation on t_conflit.num_conflit = t_mediation.num_conflit 
				inner join
            		t_parties on t_conflit.num_conflit = t_parties.num_conflit 
				inner join
            		t_menages on t_parties.id_menage = t_menages.id_menage
		where
			id_localite like @id_localite and id_resolution like @id_resolution and t_mediation.date_debut_mediation between @date_un and @date_deux
go


create procedure stats_hommes_conflit_resolu_parlocalite
@date_un date,
@date_deux date,
@id_resolution nvarchar(50),
@id_localite nvarchar(50)
	as
		select  
			--count(distinct t_conflit.num_conflit)      
			--t_conflit.id_localite, 
			--t_conflit.num_conflit, 
			--t_mediation.date_debut_mediation, 
			--t_mediation.date_fin_mediation, 
			--t_assignation_resolution.id_resolution, 
			--t_parties.id_typ_partie, 
            sum(t_menages.total_homme)--, 
			--t_menages.total_femme, 
			--t_menages.total_garcons, 
			--t_menages.total_filles
		from            
			t_conflit 
				inner join
            		t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
				inner join
            		t_mediation on t_conflit.num_conflit = t_mediation.num_conflit 
				inner join
            		t_parties on t_conflit.num_conflit = t_parties.num_conflit 
				inner join
            		t_menages on t_parties.id_menage = t_menages.id_menage
		where
			id_localite like @id_localite and id_resolution like @id_resolution and t_mediation.date_debut_mediation between @date_un and @date_deux
go

create procedure stats_femmes_conflit_resolus_parlocalite
@date_un date,
@date_deux date,
@id_resolution nvarchar(50),
@id_localite nvarchar(50)
	as
		select  
			--count(distinct t_conflit.num_conflit)      
			--t_conflit.id_localite, 
			--t_conflit.num_conflit, 
			--t_mediation.date_debut_mediation, 
			--t_mediation.date_fin_mediation, 
			--t_assignation_resolution.id_resolution, 
			--t_parties.id_typ_partie, 
            --sum(t_menages.total_homme)--, 
			sum(t_menages.total_femme)--, 
			--t_menages.total_garcons, 
			--t_menages.total_filles
		from            
			t_conflit 
				inner join
            		t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
				inner join
            		t_mediation on t_conflit.num_conflit = t_mediation.num_conflit 
				inner join
            		t_parties on t_conflit.num_conflit = t_parties.num_conflit 
				inner join
            		t_menages on t_parties.id_menage = t_menages.id_menage
		where
			id_localite like @id_localite and id_resolution like @id_resolution and t_mediation.date_debut_mediation between @date_un and @date_deux
go

create procedure stats_filles_conflit_resolus_parlocalite
@date_un date,
@date_deux date,
@id_resolution nvarchar(50),
@id_localite nvarchar(50)
	as
		select  
			--count(distinct t_conflit.num_conflit)      
			--t_conflit.id_localite, 
			--t_conflit.num_conflit, 
			--t_mediation.date_debut_mediation, 
			--t_mediation.date_fin_mediation, 
			--t_assignation_resolution.id_resolution, 
			--t_parties.id_typ_partie, 
            --sum(t_menages.total_homme)--, 
			--sum(t_menages.total_femme)--, 
			--t_menages.total_garcons, 
			sum(t_menages.total_filles)
		from            
			t_conflit 
				inner join
            		t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
				inner join
            		t_mediation on t_conflit.num_conflit = t_mediation.num_conflit 
				inner join
            		t_parties on t_conflit.num_conflit = t_parties.num_conflit 
				inner join
            		t_menages on t_parties.id_menage = t_menages.id_menage
		where
			id_localite like @id_localite and id_resolution like @id_resolution and t_mediation.date_debut_mediation between @date_un and @date_deux
go

create procedure stats_garcons_conflit_resolus_parlocalite
@date_un date,
@date_deux date,
@id_resolution nvarchar(50),
@id_localite nvarchar(50)
	as
		select  
			--count(distinct t_conflit.num_conflit)      
			--t_conflit.id_localite, 
			--t_conflit.num_conflit, 
			--t_mediation.date_debut_mediation, 
			--t_mediation.date_fin_mediation, 
			--t_assignation_resolution.id_resolution, 
			--t_parties.id_typ_partie, 
            --sum(t_menages.total_homme)--, 
			--sum(t_menages.total_femme)--, 
			sum(t_menages.total_garcons)--, 
			--sum(t_menages.total_filles)
		from            
			t_conflit 
				inner join
            		t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
				inner join
            		t_mediation on t_conflit.num_conflit = t_mediation.num_conflit 
				inner join
            		t_parties on t_conflit.num_conflit = t_parties.num_conflit 
				inner join
            		t_menages on t_parties.id_menage = t_menages.id_menage
		where
			id_localite like @id_localite and id_resolution like @id_resolution and t_mediation.date_debut_mediation between @date_un and @date_deux
go

create procedure stats_menages_conflit_resolus_parlocalite
@date_un date,
@date_deux date,
@id_resolution nvarchar(50),
@id_localite nvarchar(50)
	as
		select  
			--count(distinct t_conflit.num_conflit)      
			--t_conflit.id_localite, 
			--t_conflit.num_conflit, 
			--t_mediation.date_debut_mediation, 
			--t_mediation.date_fin_mediation, 
			--t_assignation_resolution.id_resolution, 
			--t_parties.id_typ_partie, 
            --sum(t_menages.total_homme)--, 
			--sum(t_menages.total_femme)--, 
			--sum(t_menages.total_garcons)--, 
			--sum(t_menages.total_filles),
			sum(total_femme) + sum(total_filles) + sum(total_garcons) + sum(total_homme) as total_menage
		from            
			t_conflit 
				inner join
            		t_assignation_resolution on t_conflit.num_conflit = t_assignation_resolution.num_conflit 
				inner join
            		t_mediation on t_conflit.num_conflit = t_mediation.num_conflit 
				inner join
            		t_parties on t_conflit.num_conflit = t_parties.num_conflit 
				inner join
            		t_menages on t_parties.id_menage = t_menages.id_menage
		where
			id_localite like @id_localite and id_resolution like @id_resolution and t_mediation.date_debut_mediation between @date_un and @date_deux
go
------------ 2. End of block -----------------------------------------------------------------------------------------------------------------
create procedure liste_sensibilises
as
SELECT        dbo.t_sensibilisation.num_sensibilisation, dbo.t_sensibilisation.date_debut, dbo.t_sensibilisation.date_fin, dbo.t_sensibilisation.id_localite, dbo.t_localite.id_groupement, dbo.t_groupement.id_chefferie, 
                         dbo.t_chefferie.id_territoire, dbo.t_territoire.id_province, dbo.t_atelier_masse.num_atelier_masse, dbo.t_atelier_masse.noms_sensibilisateur, dbo.t_atelier_masse.nbre_hommes, dbo.t_atelier_masse.nbre_femmes, 
                         dbo.t_atelier_masse.nbre_filles, dbo.t_atelier_masse.nbre_garcons, dbo.t_atelier_masse.nbre_autorite_femmes, dbo.t_atelier_masse.nbre_autorite_hommes, dbo.t_atelier_masse.nbre_menages_deplaces, 
                         dbo.t_atelier_masse.nbre_menages_retournes, dbo.t_atelier_masse.nbre_menages_locaux, dbo.t_atelier_masse.nbre_menages_rapatrie, dbo.t_atelier_masse.telephone_sensibilisateur, 
                         dbo.t_atelier_masse.theme_developpe
FROM            dbo.t_localite INNER JOIN
                         dbo.t_sensibilisation ON dbo.t_localite.id_localite = dbo.t_sensibilisation.id_localite INNER JOIN
                         dbo.t_groupement ON dbo.t_localite.id_groupement = dbo.t_groupement.id_groupement INNER JOIN
                         dbo.t_chefferie ON dbo.t_groupement.id_chefferie = dbo.t_chefferie.id_chefferie INNER JOIN
                         dbo.t_territoire ON dbo.t_chefferie.id_territoire = dbo.t_territoire.id_territoire INNER JOIN
                         dbo.t_province ON dbo.t_territoire.id_province = dbo.t_province.id_province INNER JOIN
                         dbo.t_atelier_masse ON dbo.t_sensibilisation.num_sensibilisation = dbo.t_atelier_masse.num_sensibilisation
GO
