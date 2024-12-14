CREATE TABLE Non_Member (
    Non_Member_ID TINYINT PRIMARY KEY AUTO_INCREMENT,
    First_Name VARCHAR(50) NOT NULL,
    Last_Name VARCHAR(100) NOT NULL,
    Email VARCHAR(100),
    Phone_Number VARCHAR(15),
    Interest VARCHAR(255)
);
