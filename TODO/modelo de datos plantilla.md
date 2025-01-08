**Tabla "Profesor"**:

*   **id_profesor**: Clave primaria, **identificador único** para cada profesor.
*   **nombre**: Almacena el **nombre** del profesor.
*   **apellido1**: Almacena el **primer apellido** del profesor, para facilitar la búsqueda y ordenación alfabética.
*   **apellido2**: Almacena el **segundo apellido** del profesor, también para facilitar la búsqueda y ordenación alfabética.
*  **estado**: Indica si el profesor es **fijo o no**, útil para gestionar sustituciones y asignación de cursos.
*   **contacto**:  Información de **contacto opcional** del profesor (teléfono, correo electrónico), útil para la gestión de faltas.

**Tabla "Falta"**:

*   **id_falta**: Clave primaria, **identificador único** para cada falta registrada.
*   **fecha**: Almacena la **fecha** en que se produjo la falta.
*   **id_profesor**: Clave foránea que **vincula la falta con el profesor ausente**. 
*   **tipo_falta**: Clasifica el tipo de falta. Se puede usar colores para visualizar el estado de la falta.
*   **comentario**:  Permite registrar **observaciones adicionales** sobre la falta, como la causa o problemas con la justificación.

**Tabla "Curso"**:

*   **id_curso**: **Año lectivo**. Ej. 2024-2025.

**Tabla "Curso-Profesor"**:

*   **id_curso_profesor**: Clave primaria que identifica la relación entre curso y profesor.
*   **id_curso**: Clave foránea que hace referencia a la tabla "Curso".
*   **id_profesor**: Clave foránea que hace referencia a la tabla "Profesor".
*   **estado**: Indica si el profesor está activo en ese curso.

**Tabla "Falta-Clasificacion"**:

*   **tipo**: `CHAR(2)` (**Abreviatura** para el tipo de falta, Ej: J, SJ, R, RR, FM).
*   **descripcion**: **Descripción** del tipo de falta ('Justificada', 'Sin justificar', 'Recuperada', 'Reclamada', 'Fuerza Mayor').

### **Definición de Tipos de Datos para MySQL**

#### **Tabla "Profesor"**
1. **id_profesor**  
   - **Tipo:** `INT`  
   - **Propiedades:**  
     - `NOT NULL`  
     - `PRIMARY KEY`  
   - **Descripción:** Identificador único de cada profesor.

2. **nombre**  
   - **Tipo:** `VARCHAR(50)`  
   - **Propiedades:**  
     - `NOT NULL`  
   - **Descripción:** Almacena el nombre del profesor. Longitud máxima sugerida de 50 caracteres.

3. **apellido1**  
   - **Tipo:** `VARCHAR(50)`  
   - **Propiedades:**  
     - `NOT NULL`  
   - **Descripción:** Primer apellido del profesor. Separar los apellidos facilita la búsqueda y ordenación.

4. **apellido2**  
   - **Tipo:** `VARCHAR(50)`  
   - **Propiedades:**  
     - `NULL` (Opcional)  
   - **Descripción:** Segundo apellido del profesor. Puede ser opcional si algunos profesores no tienen un segundo apellido.

5. **contrato**  
   - **Tipo:** `ENUM('Fijo', 'Eventual')`  
   - **Propiedades:**  
     - `NOT NULL`  
   - **Descripción:** Indica si el profesor es fijo o eventual. Se usa un tipo enumerado para limitar las opciones y facilitar la gestión.

6. **contacto**  
   - **Tipo:** `VARCHAR(100)`  
   - **Propiedades:**  
     - `NULL` 
   - **Descripción:** Información de contacto del profesor (teléfono o correo). El tamaño puede ajustarse dependiendo del formato.

8. 
---

#### **Tabla "Falta"**
1. **id_falta**  
   - **Tipo:** `INT`  
   - **Propiedades:**  
     - `NOT NULL`  
     - `AUTO_INCREMENT`  
     - `PRIMARY KEY`  
   - **Descripción:** Identificador único de cada falta registrada.

2. **fecha**  
   - **Tipo:** `DATE`  
   - **Propiedades:**  
     - `NOT NULL`  
   - **Descripción:** Fecha de la falta registrada. Usa el formato estándar `YYYY-MM-DD`.

3. **id_profesor**  
   - **Tipo:** `VARCHAR(10)`  
   - **Propiedades:**  
     - `NOT NULL`  
     - `FOREIGN KEY` que referencia a `Profesor(id_profesor)`  
   - **Descripción:** Vincula la falta al profesor correspondiente. Esto establece una relación entre las tablas.   

4. **comentario**  
   - **Tipo:** `TEXT`  
   - **Propiedades:**  
     - `NULL`  
   - **Descripción:** Campo abierto para observaciones adicionales. Se utiliza `TEXT` para almacenar notas más largas.


#### **Tabla "Curso"**
1. **id_curso**  
   - **Tipo:** `INT`  
   - **Propiedades:**  
     - `NOT NULL`  
     - `PRIMARY KEY`  
   - **Descripción:** Identificador único del curso, representado por el año lectivo (Ej: 2024-2025).

#### **Tabla "Curso-Profesor"**
1. **id_curso_profesor**  
   - **Tipo:** `INT`  
   - **Propiedades:**  
     - `NOT NULL`  
     - `PRIMARY KEY`  
   - **Descripción:** Clave primaria que identifica la relación entre el curso y el profesor.

2. **id_curso**  
   - **Tipo:** `INT`  
   - **Propiedades:**  
     - `NOT NULL`  
     - `FOREIGN KEY`  
   - **Descripción:** Clave foránea que hace referencia al campo `id_curso` en la tabla "Curso".

3. **id_profesor**  
   - **Tipo:** `INT`  
   - **Propiedades:**  
     - `NOT NULL`  
     - `FOREIGN KEY`  
   - **Descripción:** Clave foránea que hace referencia al campo `id_profesor` en la tabla "Profesor".

4. **estado**  
   - **Tipo:** `CHAR(1)`  
   - **Propiedades:**  
     - `NOT NULL`  
   - **Descripción:** Indica si el profesor está activo en ese curso. Valores posibles: 'A' para activo, 'I' para inactivo.

#### **Tabla "Falta-Clasificacion"**
1. **tipo**  
   - **Tipo:** `CHAR(2)`  
   - **Propiedades:**  
     - `NOT NULL`  
     - `PRIMARY KEY`  
   - **Descripción:** Abreviatura de 2 caracteres para el tipo de falta (Ej: 'J', 'SJ', 'R', 'RR', 'FM').

2. **descripcion**  
   - **Tipo:** `VARCHAR(50)`  
   - **Propiedades:**  
     - `NOT NULL`  
   - **Descripción:** Descripción del tipo de falta, que puede ser 'Justificada', 'Sin justificar', 'Recuperada', 'Reclamada', 'Fuerza Mayor'.

---
### **Código SQL para Crear las Tablas**

```sql
CREATE TABLE Profesor (
    id_profesor INT PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    apellido1 VARCHAR(50) NOT NULL,
    apellido2 VARCHAR(50),
    estado ENUM('Fijo', 'Eventual') NOT NULL,
    contacto VARCHAR(100)
);

CREATE TABLE Falta (
    id_falta INT AUTO_INCREMENT PRIMARY KEY,
    fecha DATE NOT NULL,
    id_profesor INT NOT NULL,
    tipo_falta_clasificacion CHAR(2) NOT NULL,
    comentario TEXT,
    FOREIGN KEY (id_profesor) REFERENCES Profesor(id_profesor),
    FOREIGN KEY (tipo_falta_clasificacion) REFERENCES Falta_Clasificacion(tipo)
);

CREATE TABLE Curso (
    id_curso VARCHAR(9) PRIMARY KEY
);

CREATE TABLE Curso_Profesor (
    id_curso_profesor INT PRIMARY KEY,
    id_curso VARCHAR(9) NOT NULL,
    id_profesor INT NOT NULL,
    estado CHAR(1) NOT NULL,
    FOREIGN KEY (id_curso) REFERENCES Curso(id_curso),
    FOREIGN KEY (id_profesor) REFERENCES Profesor(id_profesor)
);

CREATE TABLE Falta_Clasificacion (
    tipo CHAR(2) PRIMARY KEY,
    descripcion VARCHAR(50) NOT NULL
);

CREATE TABLE Sustitucion (
    id_sustitucion INT AUTO_INCREMENT PRIMARY KEY,
    id_falta INT NOT NULL,
    id_profesor_sustituto INT NOT NULL,
    fecha_inicio DATE NOT NULL,
    fecha_fin DATE NOT NULL,
    FOREIGN KEY (id_falta) REFERENCES Falta(id_falta),
    FOREIGN KEY (id_profesor_sustituto) REFERENCES Profesor(id_profesor)
);

``` 
## Observaciones Adicionales

*   **Gestión de Sustituciones**: No se especifica cómo se gestionarán las sustituciones en caso de falta de un profesor. Se podría considerar una tabla adicional para registrar las sustituciones y vincularla a las faltas.

Table Profesor {
    id_profesor VARCHAR(10) [pk]
    nombre VARCHAR(50) [not null]
    apellido1 VARCHAR(50) [not null]
    apellido2 VARCHAR(50)
    estado 
    ('Fijo', 'Eventual') [not null]
    contacto VARCHAR(100)
}

Table Falta {
    id_falta INT [pk, increment]
    fecha DATE [not null]
    id_profesor INT [not null, ref: > Profesor.id_profesor]
    comentario TEXT
    tipo_falta_clasificacion CHAR(2) [not null, ref: > Falta_Clasificacion.tipo]
}

Table Curso {
    id_curso VARCHAR(9) [pk]
}

Table Curso_Profesor {
    id_curso_profesor INT [pk]
    id_curso VARCHAR(9) [ref: > Curso.id_curso]
    id_profesor INT [ref: > Profesor.id_profesor]
    estado CHAR(1)
}

Table Falta_Clasificacion {
    tipo CHAR(2) [pk]
    descripcion VARCHAR(50)//('Justificada':J, 'Sin justificar':SJ, 'Recuperada':R, 'Reclamada':RR, 'Fuerza Mayor':FM)
}