drop table turners;
drop table fitters;
drop table welders;
drop table collectors;
drop table other_workers;
drop table workers cascade constraints;

SELECT 'DROP TABLE "' || TABLE_NAME || '" CASCADE CONSTRAINTS;' FROM user_tables;
select 'drop trigger ' || trigger_name || ';' stmt from user_triggers;
select 'drop sequence ' || sequence_name || ';' from user_sequences;