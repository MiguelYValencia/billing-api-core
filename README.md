# Billing API Core 🧾🚀

Web API de alto rendimiento para la gestión de facturación electrónica, desarrollada con **.NET 8** siguiendo los principios de **Clean Architecture** y **Domain-Driven Design (DDD)**.



## 🏗️ Arquitectura del Proyecto

El proyecto está estructurado en 4 capas para garantizar el desacoplamiento y la facilidad de pruebas:

* **Domain:** El núcleo del sistema. Contiene entidades, excepciones de dominio y reglas de negocio. No tiene dependencias externas.
* **Application:** Define las interfaces y la lógica de negocio (Casos de uso). Maneja los DTOs y el mapeo de datos.
* **Infrastructure:** Implementación de la persistencia (Entity Framework Core), servicios externos y acceso a datos.
* **API (Presentation):** Punto de entrada del sistema. Controladores RESTful documentados con Swagger/OpenAPI.

## 🛠️ Stack Tecnológico & Patrones

* **Framework:** .NET 8 (C#)
* **ORM:** Entity Framework Core (Code First)
* **Patrones de Diseño:**
    * **Repository Pattern:** Para abstraer la lógica de acceso a datos.
    * **Dependency Injection:** Inyección de dependencias nativa de .NET.
    * **DTO Pattern:** Transferencia de datos segura entre capas.
* **Principios:** SOLID, DRY y Clean Code.

## 🚀 Características Principales

- [x] Gestión de facturas y clientes.
- [x] Arquitectura escalable y mantenible.
- [x] Procesamiento asíncrono de peticiones (`async/await`).
- [x] Validación de modelos mediante Data Annotations.

---
## 🔗 Contacto
Desarrollado por **Miguel Ychu Valencia** [![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/miguel-humberto-ychu-valencia-5231b517b/)
[![Portfolio](https://img.shields.io/badge/Portfolio-000000?style=for-the-badge&logo=firefox&logoColor=white)](https://miguelyvalencia.github.io/portfolio/)
