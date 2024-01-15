CREATE TABLE student
(
    id INT
    AUTO_INCREMENT PRIMARY KEY,
    full_name VARCHAR
    (100) NOT NULL,
    gender SMALLINT NOT NULL
);

    CREATE TABLE subject
    (
        id INT
        AUTO_INCREMENT PRIMARY KEY,
    subject_name VARCHAR
        (100) NOT NULL
);

        CREATE TABLE mark
        (
            id INT
            AUTO_INCREMENT PRIMARY KEY,
    mark FLOAT,
    student_id INT,
    subject_id INT,
    FOREIGN KEY
            (student_id) REFERENCES student
            (id),
    FOREIGN KEY
            (subject_id) REFERENCES subject
            (id)
);
