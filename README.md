# 🧾 1. Descripción General del Proyecto

## 📛 Nombre del Proyecto

**TiemposDeComida.API**

---

## 🧩 ¿Qué resuelve?

Este proyecto desarrolla una API RESTful para gestionar **reservas de mesas en restaurantes**. El sistema permite que los clientes puedan ver disponibilidad de mesas, realizar reservas y gestionar sus propias citas, mientras que los administradores pueden controlar la gestión completa de los restaurantes, sus mesas y los horarios disponibles.

Con este sistema se busca digitalizar el proceso de reservas, evitar sobreocupación, mejorar la experiencia del cliente, y facilitar la gestión interna del restaurante.

---

## ⚙️ Tecnologías Utilizadas

- **Lenguaje:** C# (.NET 8)
- **Framework:** ASP.NET Core Web API
- **ORM:** Entity Framework Core
- **Base de Datos:** SQL Server (u otro sistema relacional)
- **Autenticación:** Identity + JWT (JSON Web Tokens)
- **Mapeo de Objetos:** AutoMapper
- **Validación:** FluentValidation
- **Documentación API:** Swagger (Swashbuckle)
- **Inyección de Dependencias**
- **Arquitectura por capas (limpia)**

---

## 🎯 Objetivo de Aprendizaje

Este proyecto fue creado con el propósito de:

- Aplicar buenas prácticas de desarrollo backend moderno.
- Dominar la arquitectura por capas y el patrón de diseño Repository.
- Implementar autenticación y autorización robusta usando Identity y JWT.
- Aprender el uso de DTOs, AutoMapper y separación de responsabilidades.
- Ganar experiencia en el desarrollo de APIs RESTful seguras, mantenibles y escalables.
- Documentar de forma profesional un proyecto técnico para futuras referencias o portafolio.

# 🏗️ 2. Estructura del Proyecto y Capas

Este proyecto sigue una **arquitectura en capas** que separa responsabilidades y mejora la mantenibilidad, escalabilidad y claridad del código.

---

## 📁 Estructura General del Proyecto

## 🧱 Descripción de cada capa

### ✅ 1. `TiemposDeComida.API`

- Es la **capa de presentación**.
- Contiene los controladores (`Controllers`) que exponen los endpoints de la API.
- Maneja configuración de Swagger, JWT, CORS, AutoMapper, y Dependency Injection.

---

### 🧠 2. `TiemposDeComida.Business`

- Lógica del negocio central.
- Contiene servicios (`Services`) e interfaces que definen los casos de uso de la aplicación.
- Coordina la comunicación entre la capa de presentación (API) y la capa de datos.
- Usa DTOs desde `Shared` para evitar exponer entidades directamente.

---

### 🧬 3. `TiemposDeComida.Domain`

- Capa más pura del sistema.
- Define las **entidades** (modelos del negocio) y las **interfaces de los repositorios**.
- No depende de Entity Framework ni de ninguna tecnología específica.

---

### 💾 4. `TiemposDeComida.Data`

- Capa de persistencia (infraestructura).
- Contiene el `DbContext`, migraciones, configuraciones de EF Core.
- Implementa los repositorios definidos en la capa `Domain`.
- Gestiona operaciones CRUD contra la base de datos.

---

### 📦 5. `TiemposDeComida.Shared` (opcional pero muy útil)

- Contiene:
  - DTOs.
  - Validaciones.
  - Mapeos de AutoMapper.
  - Enumeraciones, constantes, helpers, etc.
- Facilita el compartir estructuras entre las capas sin acoplarlas directamente.

---

## 📌 Principios aplicados

- **Separación de responsabilidades (SRP)**
- **Inversión de dependencias**
- **Desacoplamiento entre capas**
- **Uso de DTOs para proteger el dominio**
- **Patrón Repositorio + Unit of Work**

---

## 🧩 Diagrama conceptual actualizado

```plaintext
┌──────────────────────────┐
│   TiemposDeComida.API    │ ← HTTP Requests
└──────────┬───────────────┘
           ↓
┌──────────────────────────┐
│ TiemposDeComida.Business │ ← Servicios, Interfaces
└──────────┬───────────────┘
           ↓
┌──────────────────────────┐
│  TiemposDeComida.Domain  │ ← Entidades, Contratos
└──────────┬───────────────┘
           ↓
┌──────────────────────────┐
│   TiemposDeComida.Data   │ ← Repositorios, EF Core
└──────────────────────────┘

+--------------------------------+
|  TiemposDeComida.Shared (DTOs) |
+--------------------------------+
↑ Utilizado por todas las capas