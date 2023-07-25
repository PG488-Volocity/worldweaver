create SCHEMA registerUser;

CREATE TABLE registerUser.users (
    username varchar(20) NOT NULL Primary Key CHECK (username <> ''),
    passcode varchar(20) Not Null CHECK (passcode <> ''));


    select * from registerUser.users;

  