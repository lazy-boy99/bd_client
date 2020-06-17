CREATE sequence seq_workers START WITH 1;
CREATE sequence seq_turners START WITH 1;
CREATE sequence seq_fitters START WITH 1;
CREATE sequence seq_welders START WITH 1;
CREATE sequence seq_collectors START WITH 1;
CREATE sequence seq_products START WITH 1;
CREATE sequence seq_gliders START WITH 1;
CREATE sequence seq_rockets START WITH 1;
CREATE sequence seq_planes START WITH 1;
CREATE sequence seq_hang_gliders START WITH 1;
CREATE sequence seq_helicopters START WITH 1;
CREATE sequence seq_other_prods START WITH 1;
CREATE sequence seq_other_workers START WITH 1;
CREATE sequence seq_engineers START WITH 1;
CREATE sequence seq_technics START WITH 1;
CREATE sequence seq_technicians START WITH 1;
CREATE sequence seq_workshops START WITH 1;
CREATE sequence seq_sectors START WITH 1;
CREATE sequence seq_masters START WITH 1;
CREATE sequence seq_technologists START WITH 1;
CREATE sequence seq_jobs START WITH 1;
CREATE sequence seq_products_jobs START WITH 1;
CREATE sequence seq_experiments START WITH 1;
CREATE sequence seq_laboratories START WITH 1;
CREATE sequence seq_tools START WITH 1;
CREATE sequence seq_exp_tools START WITH 1;
CREATE sequence seq_products_exps START WITH 1;
CREATE sequence seq_lab_sup_ws START WITH 1;
CREATE sequence seq_teams START WITH 1;
CREATE sequence seq_investigators START WITH 1;
CREATE sequence seq_accounts START WITH 1;

CREATE OR REPLACE TRIGGER next_account 
BEFORE INSERT ON accounts 
FOR EACH ROW

BEGIN
  SELECT seq_accounts.NEXTVAL
  INTO   :new.id
  FROM   dual;
end;
/
CREATE OR REPLACE TRIGGER next_gliders 
BEFORE INSERT ON gliders 
FOR EACH ROW

BEGIN
  SELECT seq_gliders.NEXTVAL
  INTO   :new.id
  FROM   dual;
end;
/
CREATE OR REPLACE TRIGGER next_workers 
BEFORE INSERT ON workers 
FOR EACH ROW

BEGIN
  SELECT seq_workers.NEXTVAL
  INTO   :new.id
  FROM   dual;
end;
/
CREATE OR REPLACE TRIGGER next_turners 
BEFORE INSERT ON turners 
FOR EACH ROW

BEGIN
  SELECT seq_turners.NEXTVAL
  INTO   :new.id
  FROM   dual;
end;
/ 
CREATE OR REPLACE TRIGGER next_fitters 
BEFORE INSERT ON fitters 
FOR EACH ROW

BEGIN
  SELECT seq_fitters.NEXTVAL
  INTO   :new.id
  FROM   dual;
end;
/ 
CREATE OR REPLACE TRIGGER next_welders 
BEFORE INSERT ON welders 
FOR EACH ROW

BEGIN
  SELECT seq_welders.NEXTVAL
  INTO   :new.id
  FROM   dual;
end;
/ 
CREATE OR REPLACE TRIGGER next_collectors 
BEFORE INSERT ON collectors 
FOR EACH ROW

BEGIN
  SELECT seq_collectors.NEXTVAL
  INTO   :new.id
  FROM   dual;
end;
/ 
CREATE OR REPLACE TRIGGER next_rockets 
BEFORE INSERT ON rockets 
FOR EACH ROW

BEGIN
  SELECT seq_rockets.NEXTVAL
  INTO   :new.id
  FROM   dual;
end;
/ 
CREATE OR REPLACE TRIGGER next_hang_gliders 
BEFORE INSERT ON hang_gliders 
FOR EACH ROW

BEGIN
  SELECT seq_hang_gliders.NEXTVAL
  INTO   :new.id
  FROM   dual;
end;
/ 
CREATE OR REPLACE TRIGGER next_planes 
BEFORE INSERT ON planes 
FOR EACH ROW

BEGIN
  SELECT seq_planes.NEXTVAL
  INTO   :new.id
  FROM   dual;
end;
/ 
CREATE OR REPLACE TRIGGER next_helicopters 
BEFORE INSERT ON helicopters 
FOR EACH ROW

BEGIN
  SELECT seq_helicopters.NEXTVAL
  INTO   :new.id
  FROM   dual;
end;
/ 
CREATE OR REPLACE TRIGGER next_other_prods 
BEFORE INSERT ON other_prods 
FOR EACH ROW

BEGIN
  SELECT seq_other_prods.NEXTVAL
  INTO   :new.id
  FROM   dual;
end;
/  
CREATE OR REPLACE TRIGGER next_other_workers 
BEFORE INSERT ON other_workers 
FOR EACH ROW

BEGIN
  SELECT seq_other_workers.NEXTVAL
  INTO   :new.id
  FROM   dual;
end;
/  
CREATE OR REPLACE TRIGGER next_engineers 
BEFORE INSERT ON engineers 
FOR EACH ROW

BEGIN
  SELECT seq_engineers.NEXTVAL
  INTO   :new.id
  FROM   dual;
end;
/ 
CREATE OR REPLACE TRIGGER next_technicians 
BEFORE INSERT ON technicians 
FOR EACH ROW

BEGIN
  SELECT seq_technicians.NEXTVAL
  INTO   :new.id
  FROM   dual;
end;
/ 
CREATE OR REPLACE TRIGGER next_technics 
BEFORE INSERT ON technics 
FOR EACH ROW

BEGIN
  SELECT seq_technics.NEXTVAL
  INTO   :new.id
  FROM   dual;
end;
/ 
CREATE OR REPLACE TRIGGER next_workshops 
BEFORE INSERT ON workshops 
FOR EACH ROW

BEGIN
  SELECT seq_workshops.NEXTVAL
  INTO   :new.id
  FROM   dual;
end;
/ 
CREATE OR REPLACE TRIGGER next_sectors 
BEFORE INSERT ON sectors 
FOR EACH ROW

BEGIN
  SELECT seq_sectors.NEXTVAL
  INTO   :new.id
  FROM   dual;
end;
/ 
CREATE OR REPLACE TRIGGER next_masters 
BEFORE INSERT ON masters 
FOR EACH ROW

BEGIN
  SELECT seq_masters.NEXTVAL
  INTO   :new.id
  FROM   dual;
end;
/ 
CREATE OR REPLACE TRIGGER next_technologists 
BEFORE INSERT ON technologists 
FOR EACH ROW

BEGIN
  SELECT seq_technologists.NEXTVAL
  INTO   :new.id
  FROM   dual;
end;
/ 
CREATE OR REPLACE TRIGGER next_jobs 
BEFORE INSERT ON jobs 
FOR EACH ROW

BEGIN
  SELECT seq_jobs.NEXTVAL
  INTO   :new.id
  FROM   dual;
end;
/ 
CREATE OR REPLACE TRIGGER next_products_jobs 
BEFORE INSERT ON products_jobs 
FOR EACH ROW

BEGIN
  SELECT seq_products_jobs.NEXTVAL
  INTO   :new.id
  FROM   dual;
end;
/ 
CREATE OR REPLACE TRIGGER next_experiments 
BEFORE INSERT ON experiments 
FOR EACH ROW

BEGIN
  SELECT seq_experiments.NEXTVAL
  INTO   :new.id
  FROM   dual;
end;
/ 
CREATE OR REPLACE TRIGGER next_laboratories 
BEFORE INSERT ON laboratories 
FOR EACH ROW

BEGIN
  SELECT seq_laboratories.NEXTVAL
  INTO   :new.id
  FROM   dual;
end;
/ 
CREATE OR REPLACE TRIGGER next_tools 
BEFORE INSERT ON tools 
FOR EACH ROW

BEGIN
  SELECT seq_tools.NEXTVAL
  INTO   :new.id
  FROM   dual;
end;
/ 
CREATE OR REPLACE TRIGGER next_exp_tools 
BEFORE INSERT ON exp_tools 
FOR EACH ROW

BEGIN
  SELECT seq_exp_tools.NEXTVAL
  INTO   :new.id
  FROM   dual;
end;
/ 
CREATE OR REPLACE TRIGGER next_products_exps 
BEFORE INSERT ON products_exps 
FOR EACH ROW

BEGIN
  SELECT seq_products_exps.NEXTVAL
  INTO   :new.id
  FROM   dual;
end;
/ 
CREATE OR REPLACE TRIGGER next_lab_sup_ws 
BEFORE INSERT ON lab_sup_ws 
FOR EACH ROW

BEGIN
  SELECT seq_lab_sup_ws.NEXTVAL
  INTO   :new.id
  FROM   dual;
end;
/ 
CREATE OR REPLACE TRIGGER next_teams 
BEFORE INSERT ON teams 
FOR EACH ROW

BEGIN
  SELECT seq_teams.NEXTVAL
  INTO   :new.id
  FROM   dual;
end;
/ 
CREATE OR REPLACE TRIGGER next_investigators 
BEFORE INSERT ON investigators 
FOR EACH ROW

BEGIN
  SELECT seq_investigators.NEXTVAL
  INTO   :new.id
  FROM   dual;
end;