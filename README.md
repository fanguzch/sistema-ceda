# Proyecto CEDA - Centro de Desarrollo Académico

Este repositorio contiene el código fuente y la documentación para el **Sistema CEDA**, desarrollado para el **Centro de Desarrollo Académico**. El objetivo principal del proyecto es gestionar programas, cursos, facilitadores y estudiantes, además de generar reportes automáticos y formularios de evaluación. El sistema busca optimizar la administración académica y facilitar el manejo de información para los departamentos y escuelas que lo soliciten.

## Resumen de Funcionalidades Principales

- **Módulo de Programas**: Gestión de la información relacionada con los programas ofrecidos por el CEDA, incluyendo detalles de los cursos que componen cada programa.
- **Módulo de Cursos**: Permite la gestión de los cursos impartidos, con información detallada sobre modalidad, horas, facilitadores, y estudiantes matriculados.
- **Módulo de Facilitadores**: Manejo de los facilitadores, con la posibilidad de visualizar los cursos que han impartido.
- **Módulo de Reportes**: Generación de reportes automáticos de programas, facilitadores y estudiantes. También incluye reportes obligatorios de capacitación docente y evaluación de cursos.
- **Módulo de Bitácora/Historial**: Registro de todos los reportes generados por el sistema, con la opción de descargar y visualizar los detalles de cada uno.

## Reglas de Desarrollo

### Control de Versiones

- **Commits:**
  - Realizar commits frecuentes con mensajes claros y descriptivos para documentar los cambios realizados.
  - Cada commit debe reflejar un cambio coherente y no interferir con el trabajo de otros colaboradores.

- **Branches:**
  - Utilizar ramas (branches) para el desarrollo de nuevas características o correcciones.
  - Antes de fusionar una rama con la rama principal (`main`), asegúrate de que la funcionalidad esté implementada y probada.

### Documentación

- **Documentación Interna:**
  - Comentar el código adecuadamente para facilitar su comprensión y mantenimiento.
  - Mantener la documentación interna actualizada a medida que el código evoluciona.

## Funcionalidades Clave del Sistema

### Programas

- **Gestión de Programas**: El sistema permite gestionar programas académicos, incluyendo la creación, modificación y consulta de los programas. La duración y estado de los programas se calculan automáticamente.
- **Añadir Programas**: Los usuarios pueden añadir programas con información relevante como nombre y objetivos. El estado del programa (inactivo, en curso, completado) se gestiona automáticamente según el estado de los cursos que lo componen.

### Cursos

- **Gestión de Cursos**: El sistema permite gestionar cursos, incluyendo la información de modalidad, duración, facilitadores y estudiantes matriculados.
- **Añadir Cursos**: Se pueden registrar nuevos cursos con toda la información necesaria, y el estado del curso (inactivo, en curso, completado) se actualiza automáticamente según las fechas.
- **Visualización de Cursos**: Los usuarios pueden ver los cursos completados y matriculados, con detalles como facilitadores, fechas y estudiantes.

### Facilitadores

- **Gestión de Facilitadores**: El sistema permite gestionar los facilitadores, con detalles como nombre, correo electrónico y los cursos que han impartido.
- **Añadir Facilitadores**: Los usuarios pueden registrar nuevos facilitadores y modificar su información.

### Reportes

- **Generación de Reportes**: El sistema permite generar reportes automáticos de facilitadores, estudiantes y programas. También genera reportes de capacitación docente y certificados de finalización de curso.
- **Reporte de Evaluación**: Se generan formularios de evaluación para los cursos finalizados y se envían automáticamente a los estudiantes, con recordatorios en caso de no completar la evaluación.


## Equipo

- **Desarrollador**: Gabriel Cerdas y Fabián Guzmán
- **Colaboradores**: Sebastián, Gustavo, Martha