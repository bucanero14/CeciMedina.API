# Ceci Medina API
Este proyecto se encarga de ejecutar la lógica de negocio del sitio web

## Estructura
El proyecto se divide en 5 capas

 1. Core: Aquí se guardan todas las interfaces y modelos de negocio
 2. Data: Aquí se guardan las configuraciones de base de datos (Entity Framework), sus repositorios y la unidad de trabajo.
 3. Infrastructure: Aquí se guarda toda la configuración e implementación de algún servicio externo que se conecte con la aplicación, como un servicio de envío de correos o de facturación.
 4. Services: Aquí se almacena toda la lógica de negocio de la aplicación. La lógica de negocio se implementa utilizando las interfaces dentro de Core y sus implementaciones dentro de los proyectos de Infrastructure y Data.
 5. API: Esta es la capa de presentación del proyecto. El proyecto es un web API, por lo que no hay una interfaz gráfica, solo endpoints.

 