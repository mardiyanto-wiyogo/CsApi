# Identity Server Backend (C# .NET)

## Overview

This project is a **custom Identity Server backend** built with **ASP.NET Core (.NET)**. It provides authentication and authorization capabilities using **JWT (JSON Web Tokens)** and supports **user and role management**. The service is designed to act as a centralized identity provider for other applications or APIs.

This project is intentionally implemented **without external identity providers** (e.g., Auth0, Keycloak) to demonstrate core identity concepts and backend engineering skills.

---

## Goals

* Provide secure user authentication using email and password
* Issue JWT tokens for authenticated users
* Support role-based authorization
* Expose APIs for user and role management
* Serve as a reusable identity backend for other services

---

## Core Features

### Authentication

* Login using email and password
* Secure password hashing
* JWT token issuance
* Configurable token expiration

### User Management

* Create, read, update, and delete users
* Enable or disable user accounts
* Store credentials securely (hashed passwords only)

### Role Management

* Define system roles (e.g. Admin, User)
* Assign one or more roles to users
* Remove roles from users
* Include roles as claims in JWT tokens

### Authorization

* JWT-based authentication middleware
* Role-based access control on protected endpoints

---

## API Endpoints (High-Level)

### Authentication

```
POST /api/auth/login
```

Request:

```json
{
  "email": "user@example.com",
  "password": "password123"
}
```

Response:

```json
{
  "accessToken": "<jwt-token>",
  "expiresIn": 3600
}
```

---

### Users

```
GET    /api/users
GET    /api/users/{id}
POST   /api/users
PUT    /api/users/{id}
DELETE /api/users/{id}
```

---

### Roles

```
GET    /api/roles
POST   /api/roles
POST   /api/users/{id}/roles
DELETE /api/users/{id}/roles/{roleName}
```

---

## Data Model (Conceptual)

### User

* Id
* Email (unique)
* PasswordHash
* IsActive
* CreatedAt
* UpdatedAt

### Role

* Id
* Name

### UserRole

* UserId
* RoleId

---

## Security Considerations

* Passwords are never stored in plain text
* Password hashing uses a strong hashing algorithm
* JWT tokens are signed and validated on each request
* Sensitive configuration is stored securely

---

## Identity Implementation Approach

This project uses a **custom identity implementation** rather than ASP.NET Identity.

### Rationale

* Full control over data models and authentication flow
* Clear demonstration of authentication and authorization fundamentals
* Minimal framework abstraction for portfolio and learning purposes

The system explicitly implements:

* Password hashing and validation
* User and role relationships
* JWT generation and validation

---

## Technology Stack

* **.NET 8 / .NET 7**
* **ASP.NET Core Web API**
* **Entity Framework Core**
* **JWT Bearer Authentication**
* Database: SQL Server / PostgreSQL / MySQL (configurable)

---

## Architecture

* API Layer (Controllers)
* Application Layer (Use Cases / Services)
* Domain Layer (Entities, Business Rules)
* Infrastructure Layer (EF Core, Security, Persistence)

---

## Configuration

Key configuration values:

* JWT signing key
* Token expiration time
* Database connection string

All configuration is managed via `appsettings.json` and environment variables.

---

## Out of Scope (Initial Version)

* OAuth2 / OpenID Connect flows
* Refresh tokens
* Social login providers
* Multi-factor authentication

---

## Future Enhancements

* Refresh token support
* Audit logs (login attempts, role changes)
* API rate limiting
* OpenID Connect compatibility

---

## Intended Usage

This service is intended to be consumed by:

* Backend APIs requiring authentication
* Internal services within a microservice architecture
* Portfolio demonstration of identity and security concepts

---

## Status

🚧 **In Development**

This README defines the initial scope and requirements of the project.
