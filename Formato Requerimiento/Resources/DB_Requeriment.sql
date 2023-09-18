--░░░░░░░░░░SCRIPT PARA LA BASE DE DATOS DE REQUERIMIENTOS░░░░░░░░░░--

CREATE TABLE IF NOT EXISTS Medidas(
    IDMedida INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    Abreviatura VARCHAR(10) NOT NULL,
    Status BOOLEAN DEFAULT True
)ENGINE=InnoDB CHARSET=utf8mb4 COLLATE utf8mb4_general_ci COMMENT = 'Unidades de medida';

CREATE TABLE IF NOT EXISTS Bitacoras(
    IDBitacora INT NOT NULL AUTO_INCREMENT PRIMARY KEY, 
    Folio INT NOT NULL , 
    Producto VARCHAR(200) NOT NULL , 
    Cantidad INT NOT NULL , 
    Medida_ID INT NOT NULL , 
    Justificacion VARCHAR(200) NOT NULL , 
    FechaRequerida DATETIME NOT NULL , 
    FechaRegistro DATETIME NOT NULL , 
    FOREIGN KEY (Medida_ID) REFERENCES Medidas (IDMedida)
)ENGINE=InnoDB CHARSET=utf8mb4 COLLATE utf8mb4_general_ci COMMENT = 'Historial de los requerimientos';



INSERT INTO Medidas(Nombre, Abreviatura)
VALUES("Kilómetro","KM"),
    ("Metro","M"),
    ("Centimetro","CM"),
    ("Milimetro","MM"),
    ("Litro","LT"),
    ("Mililitro","ML"),
    ("Kilogramo","KL"),
    ("Gramo","GR"),
    ("Miligramo","MG");