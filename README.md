# CleanArchitectureDotNetCore

A .NET Core implementation of **Clean Architecture**, designed to demonstrate best practices in building scalable, maintainable applications.

---

## 🧱 Architecture Overview

This solution is broken into several distinct layers, each with a clear responsibility:

- **Domain**  
  Contains core business models, entities, and domain logic. No external framework or infrastructure dependencies.
  
- **Application**  
  Holds use cases, commands & queries, and service interfaces. Orchestrates business logic and application flow.
  
- **Infrastructure**  
  Implements external concerns: data access (EF Core, SQL, etc.), file storage, external APIs.
  
- **Presentation (Web API)**  
  ASP.NET Core Web API layer exposing application functionality.
