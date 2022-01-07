create table Salesman
(
Salesman_id numeric(5) Primary key,
name varchar(30),
city varchar(15),
Commission decimal(5,2)
)

insert into salesman values(5001,'james hoog','newyork',0.15)
insert into salesman values(5002,'nail knite','paris',0.13)
insert into salesman values(5005,'pit alex','london',0.11)
insert into salesman values(5006,'mc lyon','paris',0.14)
insert into salesman values(5007,'paul adam','rome',0.13)
insert into salesman values(5003,'lauson hen','san jose',0.12)

select*from Salesman
