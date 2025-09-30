create database taquilla;

use taquilla;

Create Table Usuarios (
	id_usuario INT PRIMARY KEY,
    Usuario VARCHAR(50),
    Contraseña Varchar(100)
);

Create Table Bitacora (
	bit_id INT auto_increment PRIMARY KEY,
    bit_fecha datetime,
    bitaccion varchar(50),
    usuid int,
    aplid int,
    bitip VARCHAR(60),
    bitnombrepc varchar(60),
    FOREIGN KEY (usuid) REFERENCES Usuarios (id_usuario)
);

CREATE TABLE pelicula (
    id_pelicula INT PRIMARY KEY,                -- int
    titulo VARCHAR(100) NOT NULL,               -- varchar
    descripcion TEXT,                           -- text
    fecha_estreno DATE,                         -- date
    duracion TIME,                              -- time
    calificacion DECIMAL(3,1),                  -- decimal
    disponible BOOLEAN,                         -- boolean
    creado_en TIMESTAMP DEFAULT CURRENT_TIMESTAMP -- timestamp
);

INSERT INTO usuario VALUES (10,"ansonny","123");
INSERT INTO usuario VALUES (11,"Admin","Admin123");
INSERT INTO usuario VALUES (12,"lupe","1234");

