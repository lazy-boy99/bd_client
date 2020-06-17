create table workers (
	id int not null primary key,
	first_name nvarchar2(20) not null,
	last_name nvarchar2(20) not null,
	patronymic nvarchar2(20) not null,
	team_id int,
	constraint uniq_name_work unique(first_name,last_name,patronymic)
);
/
create table teams (
	id int not null primary key,
	name nvarchar2(20) not null,
	lead_id int ,
	constraint unique_lead unique(lead_id),
	constraint unique_name_team unique(name),
	constraint fk_team_lead foreign key(lead_id) references workers(id) on delete set null
);
/
create table turners (
	id int not null primary key,
	amount_fingers int default 10 check(amount_fingers>0),
	work_id int not null,
	constraint fk_turn foreign key(work_id) references workers(id) on delete cascade,
	constraint uniq_work_id_turn unique(work_id)
);
/
create table fitters (
	id int not null primary key,
	category int not null check(category>0),
	work_id int not null,
	constraint uniq_work_id_fitt unique(work_id),
	constraint fk_fitt foreign key(work_id) references workers(id) on delete cascade 
);
/
create table welders (
	id int not null primary key,
	specialization nvarchar2(30) not null,
	work_id int not null,
	constraint uniq_work_id_weld unique(work_id),
	constraint fk_weld foreign key(work_id) references workers(id) on delete cascade 
);
/
create table other_workers (
	id int not null primary key,
	name_prof nvarchar2(20) not null,
	work_id int not null,
	constraint uniq_work_id_owork unique(work_id),
	constraint fk_ow foreign key(work_id) references workers(id) on delete cascade 
);
/
create table collectors (
	id int not null primary key,
	work_exp int not null check(work_exp>-1),
	work_id int not null,
	constraint uniq_work_id_coll unique(work_id),
	constraint fk_col foreign key(work_id) references workers(id) on delete cascade 
);
/
create table products(
	id int not null primary key,
	workshop_id int 
);
/
create table gliders(
	id int not null primary key,
	wingspan float not null check(wingspan>0),
	name nvarchar2(30) not null,
	prod_id int not null,
	constraint uniq_name_glid unique(name),
	constraint fk_glid foreign key(prod_id) references products(id)  on delete cascade
);
/
create table rockets(
	id int not null primary key,
	power int not null check(power>0),
	name nvarchar2(30) not null,
	prod_id int not null,
	constraint uniq_name_rocket unique(name),
	constraint fk_rock foreign key(prod_id) references products(id)  on delete cascade
);
create table planes(
	id int not null primary key,
	count_engines int not null check(count_engines>0),
	name nvarchar2(30) not null,
	prod_id int not null,
	constraint fk_plane foreign key(prod_id) references products(id)  on delete cascade,
	constraint uniq_name_plane unique(name)
);
/
create table hang_gliders(
	id int not null primary key,
	aero_qual int not null check(aero_qual>0),
	name nvarchar2(30) not null,
	prod_id int not null,
	constraint uniq_name_hg unique(name),
	constraint fk_hg foreign key(prod_id) references products(id)  on delete cascade
);
/
create table helicopters(
	id int not null primary key,
	speed int not null check(speed>0),
	name nvarchar2(30) not null,
	prod_id int not null,
	constraint uniq_name_heli unique(name),
	constraint fk_heli foreign key(prod_id) references products(id)  on delete cascade
);
/
create table other_prods(
	id int not null primary key,
	type_prod nvarchar2(20) not null,
	name nvarchar2(30) not null,
	prod_id int not null,
	constraint uniq_name_other_prod unique(name),
	constraint fk_op foreign key(prod_id) references products(id)  on delete cascade
);
/
create table technics (
	id int not null primary key,
	first_name nvarchar2(20) not null,
	last_name nvarchar2(20) not null,
	patronymic nvarchar2(20) not null,
	constraint uniq_name_techs unique(first_name,last_name,patronymic)
);
/
create table engineers (
	id int not null primary key,
	specialization nvarchar2(20) not null ,
	tech_id int not null,
	constraint uniq_tech_id_eng unique(tech_id),
	constraint fk_eng foreign key(tech_id) references technics(id) on delete cascade 
);
/
create table technicians (
	id int not null primary key,
	category nvarchar2(20) not null ,
	tech_id int not null,
	constraint uniq_tech_id_tech unique(tech_id),
	constraint fk_technic foreign key(tech_id) references technics(id) on delete cascade 
);
/
create table technologists (
	id int not null primary key,
	technology_dev nvarchar2(40) not null ,
	tech_id int not null,
	constraint uniq_tech_id_technologists unique(tech_id),
	constraint fk_technol foreign key(tech_id) references technics(id) on delete cascade 
);
/
create table workshops(
	id int not null primary key,
	name nvarchar2(20) not null ,
	tech_id int,
	constraint fk_ws foreign key(tech_id) references technics(id) on delete set null,
	constraint uniq_tech_id_ws unique(tech_id),
	constraint unique_ws_name unique(name) 
);
/
create table sectors(
	id int not null primary key,
	name nvarchar2(20) not null ,
	tech_id int,
	workshop_id int not null,
	constraint fk_sec foreign key(tech_id) references technics(id) on delete set null, 
	constraint fk_sec_ws foreign key(workshop_id) references workshops(id) on delete cascade,
	constraint uniq_tech_id_sec unique(tech_id),
	constraint unique_sec_name unique(name)  
);
/
create table masters(
	id int not null primary key,
	tech_id int not null,
	sec_id int,
	constraint uniq_tech_id_masters unique(tech_id),
	constraint fk_mast foreign key(tech_id) references technics(id) on delete cascade,
	constraint fk_mast_sec foreign key(sec_id) references sectors(id) on delete set null
);
/
create table jobs(
	id int not null primary key,
	name nvarchar2(30) not null,
	sec_id int not null,
	constraint fk_job foreign key(sec_id) references sectors(id) on delete cascade,
	constraint uniq_job_sec unique(sec_id),
	constraint uniq_job_name unique(name)
);
/
create table products_jobs(
	id int not null primary key,
	job_id int not null,
	order_num int not null check(order_num>0), 
	prod_id int not null,
	time_begin date,
	time_end date,
	team_id int not null,
	constraint check_time_job check(time_end>=time_begin),  
	constraint unique_prod_job unique(prod_id,job_id),
	constraint unique_order_job unique(prod_id,order_num),      
	constraint fk_pr_job foreign key(job_id) references jobs(id) on delete cascade,
	constraint fk_prjob_prod foreign key(prod_id) references products(id) on delete cascade,
	constraint fk_team_d foreign key(team_id) references teams(id) on delete cascade
);
/
create table experiments(
	id int not null primary key,
	name nvarchar2(30) not null,
	constraint uniq_exp_name unique(name)	
);
/
create table laboratories(
	id int not null primary key,
	name nvarchar2(30) not null,
	constraint uniq_lab_name unique(name)
);
/
create table tools(
	id int not null primary key,
	lab_id int not null,
	name nvarchar2(20) not null,
	constraint uniq_tool_name unique(name),
	constraint fk_tools foreign key(lab_id) references laboratories(id) on delete cascade 	
);
/
create table exp_tools(
	id int not null primary key,
	exp_id int not null,
	tool_id int not null,
	constraint fk_exp_tools_exp foreign key(exp_id) references experiments(id) on delete cascade,
	constraint unique_exp_tool unique(exp_id,tool_id),
	constraint fk_exp_tools foreign key(tool_id) references tools(id) on delete cascade
);
/
create table products_exps(
	id int not null primary key,
	exp_id int not null,
	order_num int not null check(order_num>0), 
	prod_id int not null,
	time_begin date,
	time_end date,
	constraint check_time_exp check(time_end>=time_begin),   
	constraint unique_prod_exp unique(prod_id,exp_id),
	constraint unique_order_exp unique(prod_id,order_num),
	constraint fk_prjexp_prod foreign key(prod_id) references products(id) on delete cascade,
	constraint fk_pr_exp foreign key(exp_id) references experiments(id) on delete cascade
);
/
alter table workers add constraint fk_work_team foreign key(team_id) references teams(id) on delete set null;
/
create table investigators (
	id int not null primary key,
	first_name nvarchar2(20) not null,
	last_name nvarchar2(20) not null,
	patronymic nvarchar2(20) not null,
	exp_id int,
	constraint fk_invest foreign key(exp_id) references experiments(id) on delete set null,
	constraint uniq_name_inv unique(first_name,last_name,patronymic)
);
/
create table lab_sup_ws (
	id int  not null,
	lab_id int not null,
	ws_id int not null,
	constraint fk_lab_ws foreign key(ws_id) references workshops(id) on delete cascade,
	constraint unique_lab_ws unique(lab_id,ws_id),
	constraint fk_lab_lab foreign key(lab_id) references laboratories(id) on delete cascade
);
/
create table Accounts(
    id int not null primary key,
    login NVARCHAR2(20) not null,
    pas NVARCHAR2(20) not null,
    role NVARCHAR2(40) not null,
	constraint unique_acc unique(login,pas)
);
