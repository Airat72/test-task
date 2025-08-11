CREATE TABLE logs (
    id SERIAL PRIMARY KEY,
    "user" TEXT,
    datetime TIMESTAMP,
    recordtype INT NOT NULL,
    comment TEXT,
    logguid UUID NOT NULL,
    logguidlinked UUID,
    entity INT NOT NULL,
    eventinfo INT NOT NULL,
    fieldname TEXT,
    oldvalue TEXT,
    newvalue TEXT
);