CREATE TABLE `Profesor` (
  `id_profesor` INT PRIMARY KEY,
  `nombre` VARCHAR(50) NOT NULL,
  `apellido1` VARCHAR(50) NOT NULL,
  `apellido2` VARCHAR(50),
  `estado` ENUM(Fijo,Eventual) NOT NULL,
  `contacto` VARCHAR(100)
);

CREATE TABLE `Falta` (
  `id_falta` INT PRIMARY KEY AUTO_INCREMENT,
  `fecha` DATE NOT NULL,
  `id_profesor` INT NOT NULL,
  `tipo_falta_clasificacion` CHAR(2) NOT NULL,
  `comentario` TEXT
);

CREATE TABLE `Curso` (
  `id_curso` VARCHAR(9) PRIMARY KEY
);

CREATE TABLE `Curso_Profesor` (
  `id_curso_profesor` INT PRIMARY KEY,
  `id_curso` VARCHAR(9),
  `id_profesor` INT,
  `estado` CHAR(1)
);

CREATE TABLE `Falta_Clasificacion` (
  `tipo` CHAR(2) PRIMARY KEY,
  `descripcion` VARCHAR(50)
);

CREATE TABLE `Sustitucion` (
  `id_sustitucion` INT PRIMARY KEY AUTO_INCREMENT,
  `id_falta` INT NOT NULL,
  `id_profesor_sustituto` INT NOT NULL,
  `fecha_inicio` DATE NOT NULL,
  `fecha_fin` DATE NOT NULL
);

ALTER TABLE `Falta` ADD FOREIGN KEY (`id_profesor`) REFERENCES `Profesor` (`id_profesor`);

ALTER TABLE `Falta` ADD FOREIGN KEY (`tipo_falta_clasificacion`) REFERENCES `Falta_Clasificacion` (`tipo`);

ALTER TABLE `Curso_Profesor` ADD FOREIGN KEY (`id_curso`) REFERENCES `Curso` (`id_curso`);

ALTER TABLE `Curso_Profesor` ADD FOREIGN KEY (`id_profesor`) REFERENCES `Profesor` (`id_profesor`);

ALTER TABLE `Sustitucion` ADD FOREIGN KEY (`id_falta`) REFERENCES `Falta` (`id_falta`);

ALTER TABLE `Sustitucion` ADD FOREIGN KEY (`id_profesor_sustituto`) REFERENCES `Profesor` (`id_profesor`);
