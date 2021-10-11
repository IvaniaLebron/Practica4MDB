CREATE DATABASE Practica_4_LF212591
GO
USE Practica_4_LF212591
GO
CREATE TABLE Participantes (
    Codigo varchar(25) PRIMARY KEY,
    Nombres VARCHAR(25),
    Apellidos VARCHAR(25),
    Edad INT
)
GO
INSERT INTO Participantes VALUES (1,'Alba','Castro', 26)
INSERT INTO Participantes VALUES (2,'Mario','Abarca', 25)
INSERT INTO Participantes VALUES (3,'Alberto','Granados', 30)
INSERT INTO Participantes VALUES (4,'Itzel','Martinez', 28)
GO
SELECT * from Participantes;
DELETE FROM Participantes WHERE Apellidos='Palacios';
