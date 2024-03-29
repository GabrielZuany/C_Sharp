/*
    CREATE TABLE employee (
	    id uuid PRIMARY KEY NOT NULL,
        fullname varchar(50) NOT NULL,
        age int NOT NULL,
        postcode varchar(8)
	    );
    CREATE EXTENSION IF NOT EXISTS "uuid-ossp";

    INSERT INTO employee (id, fullname, age, postcode) VALUES(gen_random_uuid(), 'test_user', 25, 'xxxxxxxx');
*/