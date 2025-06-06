# Insight

Es una API backend desarrollada en .NET 8.0 diseñada para digitalizar la gestión de intervenciones psicológicas. Proporciona una API segura para que los psicólogos registren, consulten y gestionen información sobre las intervenciones y los pacientes, sustituyendo el registro manual por una solución digital. 

---

🧠 **Objetivo**

El equipo de psicólogas maneja actualmente la gestión de la información en documentos físicos y no cuenta con una herramienta digital que permita registrar, consultar y (a definir) compartir de forma eficiente dicha información sobre las intervenciones realizadas con cada niño/a y su comportamiento antecedente, lo que limita la capacidad de actuar con rapidez y precisión, especialmente durante situaciones de crisis. **Este backend proporciona una API segura para la gestión de esta información.**

---

🔒 **Seguridad Implementada**

* **Autenticación:** Se ha implementado un sistema de autenticación basado en **JWT (JSON Web Tokens)** para proteger la API. Los usuarios pueden iniciar sesión proporcionando sus credenciales y reciben un token que deben incluir en las solicitudes posteriores para acceder a los recursos protegidos.
* **Autorización:** El **`PatientController`** ahora está protegido y requiere autenticación para acceder a sus endpoints, asegurando que solo los usuarios autenticados puedan gestionar la información de los pacientes.
* **Clave Secreta:** La clave secreta para la firma de los tokens JWT se gestiona a través de **variables de entorno** para mayor seguridad.

---

🛠️ **Tecnologías**

* .NET 8.0
* EF Core 8.0.408
* MySQL
* Docker
* Swagger para la documentación y prueba de la API
* JWT (JSON Web Tokens) para autenticación y autorización de usuarios.
* Microsoft.AspNetCore.Authentication.JwtBearer para el soporte de JWT en ASP.NET Core.
* CORS (Cross-Origin Resource Sharing) para gestionar las políticas de acceso entre dominios. (AllowAnyOrigin)
* Git Flow para control de versiones.
* EF Core Migrations para gestión del esquema de base de datos.
* Estrategias de validación de datos basadas en Data Annotations.
* Railway para el despliegue.
---

📁 **Estructura del repositorio**

Proyecto-FOO/
│
├── README.md
├── .gitignore
├── ProyectoFoo.sln
│
├── src/
│ ├── ProyectoFoo.API/ # Capa de presentación (controllers, configuración, modelos de request/response)
│ ├── ProyectoFoo.Application/ # Lógica de negocio (casos de uso, interfaces)
│ ├── ProyectoFoo.Domain/ # Entidades de dominio, reglas base y servicios de dominio
│ ├── ProyectoFoo.Infrastructure/ # Acceso a datos (EF Core, repositorios), servicios externos
│ └── ProyectoFoo.Shared/ # Helpers y utilidades compartidas
│



🧱 **Principios de arquitectura y desarrollo**

Este proyecto está diseñado siguiendo los principios de **Arquitectura Limpia** , con el objetivo de mantener un alto grado de cohesión, bajo acoplamiento, facilidad de pruebas y escalabilidad en el tiempo.

#### 📐 Clean Architecture

- **API**: Capa de presentación (ASP.NET) que configura servicios, middlewares y rutas.

- **Application**: Contiene la lógica de negocio mediante el patrón CQRS con comandos/consultas y controladores. Depende solo de `Domain`.

- **Domain**: Entidades centrales del sistema y reglas de negocio. No depende de ninguna otra capa.

- **Infrastructure**: Implementaciones de acceso a datos, servicios externos y otras cuestiones técnicas. Depende de `Application` y `Domain`.

- **Shared**: Componentes y utilidades comunes compartidas entre capas.

#### 🧩 Patrones y principios aplicados.
El sistema implementa los siguientes principios de desarrollo:

- **Arquitectura limpia**: Separación de responsabilidades con capas centradas en el dominio.
- **Principios SOLID**: Enfoque en la responsabilidad única y la segregación de interfaces
- **Inyección de dependencias**: Centralizada mediante extensiones de servicio
- **CQRS (Command Query Responsibility Segregation)**: Separación de responsabilidades de comandos y consultas
- **Patrón Repository**: Abstracción de la lógica de acceso a los datos.
- **MediatR** para la gestión de comandos y queries de forma desacoplada.


#### ✅ Buenas prácticas

- Uso de **Data Annotations** para validaciones
- Control de versiones con **Git Flow**
- Configuración sensible aislada con **variables de entorno**

---

⚙️ **Configuración**

La configuración sensible, como la clave secreta JWT y la cadena de conexión a la base de datos, se gestiona a través de **variables de entorno** para mayor seguridad y flexibilidad entre diferentes entornos (desarrollo, pruebas, producción).

---

📚 **Documentación Swagger**

Swagger está habilitado para facilitar la exploración y prueba de la API.

- En desarrollo: `https://localhost:7224/swagger`
- En producción: (https://proyecto-foo-production.up.railway.app/index.html)

---

🛠️ **Despliegue**

Este proyecto se despliega automáticamente mediante [**Railway**](https://railway.app/):

🔗 (https://proyecto-foo-production.up.railway.app/index.html)

---

👥 **Autores**

Proyecto desarrollado por el equipo de desarrolladores de BackEnd. 
**[Rodrigo Joquera]**
**[Valeria Naranjo]**

[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/valnaranjos/Proyecto-FOO)