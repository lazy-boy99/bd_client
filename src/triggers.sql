CREATE OR REPLACE TRIGGER unique_welders 
    before 
    UPDATE OR insert 
    ON welders   
FOR EACH ROW    
DECLARE
   c int;
BEGIN
  if :new.work_id<>:old.work_id or :old.work_id is null then
  select count(*) into c from collectors where work_id=:new.work_id;
  if c!=0 then
    raise_application_error(-20000,'worker has profession'); 
  end if;
  select count(*) into c from turners where work_id=:new.work_id;
  if c!=0 then
    raise_application_error(-20000,'worker has profession'); 
  end if;
  select count(*) into c from fitters where work_id=:new.work_id;
  if c!=0 then
    raise_application_error(-20000,'worker has profession'); 
  end if;
  select count(*) into c from other_workers where work_id=:new.work_id;
  if c!=0 then
    raise_application_error(-20000,'worker has profession'); 
  end if;   
  end if;   
end;
/  
CREATE OR REPLACE TRIGGER unique_col 
    before 
    UPDATE OR insert 
    ON collectors   
FOR EACH ROW    
DECLARE
   c int;
BEGIN
  if :new.work_id<>:old.work_id or :old.work_id is null then
  select count(*) into c from welders where work_id=:new.work_id;
  if c!=0 then
    raise_application_error(-20000,'worker has profession'); 
  end if;
  select count(*) into c from turners where work_id=:new.work_id;
  if c!=0 then
    raise_application_error(-20000,'worker has profession'); 
  end if;
  select count(*) into c from fitters where work_id=:new.work_id;
  if c!=0 then
    raise_application_error(-20000,'worker has profession'); 
  end if;
  select count(*) into c from other_workers where work_id=:new.work_id;
  if c!=0 then
    raise_application_error(-20000,'worker has profession'); 
  end if;   
  end if;   
end;
/
CREATE OR REPLACE TRIGGER unique_turners
    before 
    UPDATE OR insert 
    ON turners   
FOR EACH ROW    
DECLARE
   c int;
BEGIN
  if :new.work_id<>:old.work_id or :old.work_id is null then
  select count(*) into c from welders where work_id=:new.work_id;
  if c!=0 then
    raise_application_error(-20000,'worker has profession'); 
  end if;
  select count(*) into c from collectors where work_id=:new.work_id;
  if c!=0 then
    raise_application_error(-20000,'worker has profession'); 
  end if;
  select count(*) into c from fitters where work_id=:new.work_id;
  if c!=0 then
    raise_application_error(-20000,'worker has profession'); 
  end if;
  select count(*) into c from other_workers where work_id=:new.work_id;
  if c!=0 then
    raise_application_error(-20000,'worker has profession'); 
  end if;   
  end if;   
end;
/
CREATE OR REPLACE TRIGGER unique_fitters 
    before 
    UPDATE OR insert 
    ON fitters   
FOR EACH ROW    
DECLARE
   c int;
BEGIN
  if :new.work_id<>:old.work_id or :old.work_id is null then
  select count(*) into c from welders where work_id=:new.work_id;
  if c!=0 then
    raise_application_error(-20000,'worker has profession'); 
  end if;
  select count(*) into c from collectors where work_id=:new.work_id;
  if c!=0 then
    raise_application_error(-20000,'worker has profession'); 
  end if;
  select count(*) into c from turners where work_id=:new.work_id;
  if c!=0 then
    raise_application_error(-20000,'worker has profession'); 
  end if;
  select count(*) into c from other_workers where work_id=:new.work_id;
  if c!=0 then
    raise_application_error(-20000,'worker has profession'); 
  end if;   
  end if;   
end;
/
CREATE OR REPLACE TRIGGER unique_other_workers 
    before 
    UPDATE OR insert 
    ON other_workers 
FOR EACH ROW    
DECLARE
   c int;
BEGIN
  if :new.work_id<>:old.work_id or :old.work_id is null then
  select count(*) into c from welders where work_id=:new.work_id;
  if c!=0 then
    raise_application_error(-20000,'worker has profession'); 
  end if;
  select count(*) into c from collectors where work_id=:new.work_id;
  if c!=0 then
    raise_application_error(-20000,'worker has profession'); 
  end if;
  select count(*) into c from turners where work_id=:new.work_id;
  if c!=0 then
    raise_application_error(-20000,'worker has profession'); 
  end if;
  select count(*) into c from fitters where work_id=:new.work_id;
  if c!=0 then
    raise_application_error(-20000,'worker has profession'); 
  end if;   
  end if;   
end;
/
CREATE OR REPLACE TRIGGER ins_other_prods 
    before update or insert 
    ON other_prods  
FOR EACH ROW
DECLARE
  c int; 
  id int;   
BEGIN
  if :old.name<>:new.name then
  select count(*) into c from gliders where name=:new.name;
  if c!=0 then
    raise_application_error(-20000,'not unique name'); 
  end if;
  select count(*) into c from rockets where name=:new.name;
  if c!=0 then
    raise_application_error(-20000,'not unique name'); 
  end if;
  select count(*) into c from planes where name=:new.name;
  if c!=0 then
    raise_application_error(-20000,'not unique name'); 
  end if;
  select count(*) into c from hang_gliders where name=:new.name;
  if c!=0 then
    raise_application_error(-20000,'not unique name'); 
  end if;
  select count(*) into c from helicopters where name=:new.name;
  if c!=0 then
    raise_application_error(-20000,'not unique name'); 
  end if; 
  end if;   
  if :new.prod_id is null then
  select seq_products.nextval into id from dual;
  insert into products(id) values(id);
  :new.prod_id:=id;  
  end if;   
end;
/
cREATE OR REPLACE TRIGGER ins_gliders 
    before update or insert 
    ON gliders  
FOR EACH ROW
DECLARE
  c int; 
  id int;   
BEGIN
  if :old.name<>:new.name then
  select count(*) into c from other_prods where name=:new.name;
  if c!=0 then
    raise_application_error(-20000,'not unique name'); 
  end if;
  select count(*) into c from rockets where name=:new.name;
  if c!=0 then
    raise_application_error(-20000,'not unique name'); 
  end if;
  select count(*) into c from planes where name=:new.name;
  if c!=0 then
    raise_application_error(-20000,'not unique name'); 
  end if;
  select count(*) into c from hang_gliders where name=:new.name;
  if c!=0 then
    raise_application_error(-20000,'not unique name'); 
  end if;
  select count(*) into c from helicopters where name=:new.name;
  if c!=0 then
    raise_application_error(-20000,'not unique name'); 
  end if; 
  end if;   
  if :new.prod_id is null then
  select seq_products.nextval into id from dual;
  insert into products(id) values(id);
  :new.prod_id:=id;  
  end if;   
end;
/
cREATE OR REPLACE TRIGGER ins_rockets
    before update or insert 
    ON rockets  
FOR EACH ROW
DECLARE
  c int; 
  id int;   
BEGIN
  if :old.name<>:new.name then
  select count(*) into c from gliders where name=:new.name;
  if c!=0 then
    raise_application_error(-20000,'not unique name'); 
  end if;
  select count(*) into c from other_prods where name=:new.name;
  if c!=0 then
    raise_application_error(-20000,'not unique name'); 
  end if;
  select count(*) into c from planes where name=:new.name;
  if c!=0 then
    raise_application_error(-20000,'not unique name'); 
  end if;
  select count(*) into c from hang_gliders where name=:new.name;
  if c!=0 then
    raise_application_error(-20000,'not unique name'); 
  end if;
  select count(*) into c from helicopters where name=:new.name;
  if c!=0 then
    raise_application_error(-20000,'not unique name'); 
  end if;
  end if;  
  if :new.prod_id is null then
  select seq_products.nextval into id from dual;
  insert into products(id) values(id);
  :new.prod_id:=id;  
  end if;   
end;
/
cREATE OR REPLACE TRIGGER ins_planes
    before update or insert 
    ON planes 
FOR EACH ROW
DECLARE
  c int; 
  id int;   
BEGIN
  if :old.name<>:new.name then
  select count(*) into c from gliders where name=:new.name;
  if c!=0 then
    raise_application_error(-20000,'not unique name'); 
  end if;
  select count(*) into c from other_prods where name=:new.name;
  if c!=0 then
    raise_application_error(-20000,'not unique name'); 
  end if;
  select count(*) into c from rockets where name=:new.name;
  if c!=0 then
    raise_application_error(-20000,'not unique name'); 
  end if;
  select count(*) into c from hang_gliders where name=:new.name;
  if c!=0 then
    raise_application_error(-20000,'not unique name'); 
  end if;
  select count(*) into c from helicopters where name=:new.name;
  if c!=0 then
    raise_application_error(-20000,'not unique name'); 
  end if; 
  end if;   
  if :new.prod_id is null then
  select seq_products.nextval into id from dual;
  insert into products(id) values(id);
  :new.prod_id:=id;  
  end if;   
end;
/
CREATE OR REPLACE TRIGGER ins_hang_gliders
    before update or insert 
    ON hang_gliders
FOR EACH ROW
DECLARE
  c int; 
  id int;   
BEGIN
  if :new.name<>:new.name then
  select count(*) into c from gliders where  name=:new.name;
  if c!=0 then
    raise_application_error(-20000,'not unique name'); 
  end if;
  select count(*) into c from other_prods where  name=:new.name;
  if c!=0 then
    raise_application_error(-20000,'not unique name'); 
  end if;
  select count(*) into c from rockets where  name=:new.name;
  if c!=0 then
    raise_application_error(-20000,'not unique name'); 
  end if;
  select count(*) into c from planes where  name=:new.name;
  if c!=0 then
    raise_application_error(-20000,'not unique name'); 
  end if;
  select count(*) into c from helicopters where  name=:new.name;
  if c!=0 then
    raise_application_error(-20000,'not unique name'); 
  end if; 
  end if;   
  if :new.prod_id is null then
  select seq_products.nextval into id from dual;
  insert into products(id) values(id);
  :new.prod_id:=id;  
  end if;   
end;
/
CREATE OR REPLACE TRIGGER ins_helicopters
    before update or insert 
    ON helicopters  
FOR EACH ROW
DECLARE
  c int; 
  id int;   
BEGIN
  if :old.name<>:new.name then
  select count(*) into c from gliders where name=:new.name;
  if c!=0 then
    raise_application_error(-20000,'not unique name'); 
  end if;
  select count(*) into c from other_prods where name=:new.name;
  if c!=0 then
    raise_application_error(-20000,'not unique name'); 
  end if;
  select count(*) into c from rockets where name=:new.name;
  if c!=0 then
    raise_application_error(-20000,'not unique name'); 
  end if;
  select count(*) into c from planes where name=:new.name;
  if c!=0 then
    raise_application_error(-20000,'not unique name'); 
  end if;
  select count(*) into c from hang_gliders where name=:new.name;
  if c!=0 then
    raise_application_error(-20000,'not unique name'); 
  end if; 
  end if;   
  if :new.prod_id is null then
  select seq_products.nextval into id from dual;
  insert into products(id) values(id);
  :new.prod_id:=id;  
  end if;   
end;
/
CREATE OR REPLACE TRIGGER update_ls_other_prods 
    before update 
    ON other_prods  
FOR EACH ROW    
BEGIN
  if :old.prod_id<>:new.prod_id then
    raise_application_error(-20000,'could not update prod_id'); 
  end if;   
end;
/
CREATE OR REPLACE TRIGGER update_ls_gliders 
    before update 
    ON gliders  
FOR EACH ROW    
BEGIN
  if :old.prod_id<>:new.prod_id then
    raise_application_error(-20000,'could not update prod_id'); 
  end if;   
end;
/
CREATE OR REPLACE TRIGGER update_ls_rockets 
    before update 
    ON rockets  
FOR EACH ROW    
BEGIN
  if :old.prod_id<>:new.prod_id then
    raise_application_error(-20000,'could not update prod_id'); 
  end if;   
end;
/
CREATE OR REPLACE TRIGGER update_ls_planes 
    before update 
    ON planes  
FOR EACH ROW    
BEGIN
  if :old.prod_id<>:new.prod_id then
    raise_application_error(-20000,'could not update prod_id'); 
  end if;   
end;
/
CREATE OR REPLACE TRIGGER update_ls_hang_gliders 
    before update 
    ON hang_gliders  
FOR EACH ROW    
BEGIN
  if :old.prod_id<>:new.prod_id then
    raise_application_error(-20000,'could not update prod_id'); 
  end if;   
end;
/
CREATE OR REPLACE TRIGGER update_ls_helicopters 
    before update 
    ON helicopters  
FOR EACH ROW    
BEGIN
  if :old.prod_id<>:new.prod_id then
    raise_application_error(-20000,'could not update prod_id'); 
  end if;   
end;
/

CREATE OR REPLACE TRIGGER add_team_id 
    after insert  
    ON teams  
FOR EACH ROW    
DECLARE
  c int;
BEGIN
  select count(*) into c from workers where id=:new.lead_id and team_id is not null;
  if c<>0 then
    raise_application_error(-20000,'worker has other team');
  else 
    update workers set team_id=:new.id where id=:new.lead_id;  
  end if;
end;
/
CREATE OR REPLACE TRIGGER add_lead_id 
    after insert  
    ON workers  
FOR EACH ROW    
DECLARE
  c int;
BEGIN
  select count(*) into c from teams where id=:new.team_id and lead_id is null;
  if c<>0 then
    update teams set lead_id=:new.id where id=:new.team_id;  
  end if;
end;
/
CREATE OR REPLACE TRIGGER update_team_id 
    after update 
    ON teams  
FOR EACH ROW    
DECLARE
  c int;
BEGIN
  if :new.lead_id<>:old.lead_id then
    select count(*) into c from workers where id=:new.lead_id and team_id is not null and team_id<>:new.id;
    if c<>0 then
      raise_application_error(-20000,'worker has other team');
    else
      update workers set team_id= case id 
                            when :new.lead_id then :new.id 
                            when :old.lead_id then null 
                            else team_id end 
                            where id in(:new.lead_id,:old.lead_id);  
    end if;
  end if;
end;
/
CREATE OR REPLACE TRIGGER update_lead_id 
    before update  
    ON workers  
FOR EACH ROW    
DECLARE
  c int;
BEGIN
  if :new.team_id<>:old.team_id then
    select count(*) into c from teams where id=:new.team_id and lead_id is null;
    if c<>0 then
      update teams set lead_id=:new.id where id=:new.team_id;  
    end if;
  end if;
end;
/
CREATE OR REPLACE TRIGGER unique_technicians 
    before 
    UPDATE OR insert 
    ON technicians 
FOR EACH ROW    
DECLARE
   c int;
BEGIN
  if :new.tech_id<>:old.tech_id or :old.tech_id is null then
  select count(*) into c from engineers where tech_id=:new.tech_id;
  if c!=0 then
    raise_application_error(-20000,'technic has profession'); 
  end if;
  select count(*) into c from technologists where tech_id=:new.tech_id;
  if c!=0 then
    raise_application_error(-20000,'technic has profession'); 
  end if;   
  end if;
end;
/  
CREATE OR REPLACE TRIGGER unique_engineers
    before 
    UPDATE OR insert 
    ON engineers 
FOR EACH ROW    
DECLARE
   c int;
BEGIN
  if :new.tech_id<>:old.tech_id or :old.tech_id is null then
  select count(*) into c from technicians where tech_id=:new.tech_id;
  if c!=0 then
    raise_application_error(-20000,'technic has profession'); 
  end if;
  select count(*) into c from technologists where tech_id=:new.tech_id;
  if c!=0 then
    raise_application_error(-20000,'technic has profession'); 
  end if;   
  end if;
end;
/  
CREATE OR REPLACE TRIGGER unique_technologists
    before 
    UPDATE OR insert 
    ON technologists 
FOR EACH ROW    
DECLARE
   c int;
BEGIN
  if :new.tech_id<>:old.tech_id or :old.tech_id is null then
  select count(*) into c from technicians where tech_id=:new.tech_id;
  if c!=0 then
    raise_application_error(-20000,'technic has profession'); 
  end if;
  select count(*) into c from engineers where tech_id=:new.tech_id;
  if c!=0 then
    raise_application_error(-20000,'technic has profession'); 
  end if;   
  end if;
end;
/  
CREATE OR REPLACE TRIGGER unique_masters 
    before 
    UPDATE OR insert 
    ON masters 
FOR EACH ROW    
DECLARE
   c int;
BEGIN
  if :new.tech_id<>:old.tech_id or :old.tech_id is null then
  select count(*) into c from workshops where tech_id=:new.tech_id;
  if c!=0 then
    raise_application_error(-20000,'technic has other job'); 
  end if;
  select count(*) into c from sectors where tech_id=:new.tech_id;
  if c!=0 then
    raise_application_error(-20000,'technic has job'); 
  end if;   
  end if;
end;
/  
CREATE OR REPLACE TRIGGER unique_workshops_lead
    before 
    UPDATE OR insert 
    ON workshops 
FOR EACH ROW    
DECLARE
   c int;
BEGIN
  if :new.tech_id<>:old.tech_id or :old.tech_id is null then
  select count(*) into c from masters where tech_id=:new.tech_id;
  if c!=0 then
    raise_application_error(-20000,'technic has profession'); 
  end if;
  select count(*) into c from sectors where tech_id=:new.tech_id;
  if c!=0 then
    raise_application_error(-20000,'technic has profession'); 
  end if;   
  end if;
end;
/  
CREATE OR REPLACE TRIGGER unique_sectors_leads
    before 
    UPDATE OR insert 
    ON sectors
FOR EACH ROW    
DECLARE
   c int;
BEGIN
  if :new.tech_id<>:old.tech_id or :old.tech_id is null then
  select count(*) into c from workshops where tech_id=:new.tech_id;
  if c!=0 then
    raise_application_error(-20000,'technic has profession'); 
  end if;
  select count(*) into c from masters where tech_id=:new.tech_id;
  if c!=0 then
    raise_application_error(-20000,'technic has profession'); 
  end if;   
  end if;
end;
/
CREATE OR REPLACE TRIGGER unique_ws_prod
    before 
    UPDATE OR insert 
    ON products_jobs
FOR EACH ROW    
DECLARE
   id1 int;
   id2 int;
BEGIN
  if :new.prod_id<>:old.prod_id or :new.job_id<>:old.job_id or :old.job_id is null  then
    select workshop_id into id1 from sectors where id in (select sec_id from jobs where id=:new.job_id);
    select workshop_id into id2 from products where id in :new.prod_id;
    if id1<>id2 then 
      raise_application_error(-20000,'cannot define workshop for product'); 
  	end if;
  end if;
end;
/  
CREATE OR REPLACE TRIGGER ver_lab_sup_ws
    before 
    UPDATE OR insert 
    ON products_exps
FOR EACH ROW    
DECLARE
   id1 int;
BEGIN
  if :new.prod_id<>:old.prod_id or :new.exp_id<>:old.exp_id or :old.prod_id is null   then
    select count(*) into id1 from
    (select workshop_id from products where id = :new.prod_id) 
    where workshop_id in 
    (select ws_id from lab_sup_ws 
    where lab_id in
    (select lab_id from tools 
    where id in 
    (select tool_id from exp_tools 
    where exp_id=:new.exp_id)));
    if id1=0 then 
      raise_application_error(-20000,'workshop does not supports with laboratories');
    end if; 
  end if;
end;
/
CREATE OR REPLACE TRIGGER check_ws
    before 
    UPDATE OR insert 
    ON products_jobs
FOR EACH ROW    
DECLARE
   id1 int;
BEGIN
    select count(*) into id1 from
    products where id=:new.prod_id and workshop_id is not null;
    if id1=0 then 
      raise_application_error(-20000,'please setup workshop for product before');
  	end if;
end;

