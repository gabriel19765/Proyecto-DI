### **Tabla de Contenidos: Sistema de Registro de Faltas de Profesores**

**Objetivo:** Modelar un sistema para registrar y gestionar las faltas de los profesores de un centro educativo.

---

### **I. Registro de Profesores**  
**Resumen:** Desarrollo de un sistema que permita dar de alta, modificar, eliminar y consultar información de los profesores.  

#### **A. Datos del Profesor**  
- **Información básica:** Nombre y apellidos, no null.  
- **Nºidentificacion:** No null.
- **Fijo o Sustituto:** True o False.

#### **B. Gestión de Profesores**  
- **Alta:** Incorporación de nuevos profesores.  
- **Modificación:** Actualización de datos existentes.  
- **Eliminación:** Baja de profesores del centro educativo.

---

### **II. Registro de Faltas**  
**Resumen:** Sistema para registrar las faltas de los profesores, incluyendo opciones para justificarlas y agregar comentarios.

#### **A. Datos de la Falta**  
- **Fecha:** Día en que ocurrió la falta. DATE  
- **Profesor:** Persona registrada como ausente.  
- **Tipo de falta:**  
  - Justificada.  
  - Sin justificar.  
  - Recuperada.  
  - Reclamada.  
  - Fuerza Mayor.
****- **Comentario** Campo abierto para notas adicionales (ejemplo: "Carretera cortada").
- **Leyenda:** Leyenda.

#### **B. Interfaz de Usuario**  
- **Calendario:** Selección visual de la fecha de la falta.  Septiembre a Julio, lectivo del ayuntamiento
- **Listado:** Profesores para seleccionar al ausente.  
- **Tipo de falta:** Sistema de selección (desplegable o código de colores).  
- **Campo de texto:** Para comentarios.

#### **C. Funcionalidad**  
- **Registrar:** Agregar nuevas faltas al sistema.  
- **Modificar:** Cambiar el estado de una falta (justificada, recuperada, etc.).  
- **Leyenda/Comentario:** Añadir o modificar información adicional sobre una falta.  
- **Consulta:** Ver histórico de faltas de un profesor.

---

### **III. Consideraciones Adicionales**  
**Resumen:** Aspectos clave a tener en cuenta durante el desarrollo del sistema.

#### **A. Simplicidad**  
- Evitar complejidades innecesarias en la fase inicial.

#### **B. Flexibilidad**  
- Posibilidad de incorporar nuevas funcionalidades en el futuro (ejemplo: registro de horas de falta, información de contacto del profesor).

#### **C. Origen de los Datos**  
- El sistema actual se basa en una hoja de cálculo diaria, que se usará como punto de partida para la migración de datos.

---

### **IV. Próximos Pasos**  
**Resumen:** Acciones necesarias para avanzar en el desarrollo.

#### **A. Diseño del Modelo de Datos**  
- Estructurar la base de datos para gestionar información de profesores y faltas.  

#### **B. Diseño de la Interfaz de Usuario**  
- Crear una interfaz amigable para el registro y gestión de las faltas.  

#### **C. Desarrollo del Código**  
- Implementar la lógica del sistema en un lenguaje de programación adecuado.  

#### **D. Pruebas y Ajustes**  
- Realizar pruebas exhaustivas para garantizar el correcto funcionamiento del sistema.