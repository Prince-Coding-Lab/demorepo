create database employeedb
create table punjab ( first name,last name, address varchar, city varchar);
select* from punjab


CREATE TABLE punjab (
    [first name] VARCHAR(50),  -- Enclose column names with spaces in brackets
    [last name] VARCHAR(50),   -- Specify length for VARCHAR
    address VARCHAR(100),      -- Specify length for VARCHAR
    city VARCHAR(50)           -- Specify length for VARCHAR
);
insert into punjab( first name,
last name,
address,
city)
values ( 'raman', 'kaur', '50a street', 'moga');
INSERT INTO punjab (
    [first name],  -- Enclose column names with spaces in brackets
    [last name],
    address,
    city
)
values (
    'raman',       -- Value for first name
    'kaur',       -- Value for last name
    '50a street', -- Value for address
    'moga'        -- Value for city
);
