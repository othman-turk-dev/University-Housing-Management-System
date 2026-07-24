# University Housing Management System (UHMS)

A full-stack University Housing Management System designed to simplify the management of student accommodation, subscriptions, violations, sales, inventory, and financial operations within a university residence.

The system is built on a layered architecture and provides a RESTful Web API for seamless integration with desktop and other client applications. It also includes a modern, user-friendly interface designed to make daily operations easier for administrators.

---

# Overview

Managing a university residence involves much more than assigning students to rooms. It requires handling subscriptions, tracking violations, managing inventory and sales, recording financial transactions, and providing administrators with real-time statistics.

This project brings all these operations together into a single integrated management system with a clean and practical user interface.

---

# Features

## Authentication & Authorization

- Secure Login
- Default credentials:
  - Username: `othman`
  - Password: `@Admin11`
- JWT Authentication
- Refresh Tokens
- Password Hashing (BCrypt)
- Role-Based Authorization

---

## Dashboard

- Total Students
- Total Rooms
- Full Rooms
- Students by Specialization
- Violation Statistics

---

## Student Management

- Add Student
- Update Student
- Delete Student
- View Student Details
- Search Students
- Filter by:
  - Specialization
  - Academic Level
  - Room Location
- Print Student Reports

---

## Room Management

- Add Rooms
- Room Statistics
- View Students Inside a Room
- Search by Room Location
- Filter by:
  - Location
  - Room Status
  - Occupancy

---

## Subscription Management

- Create New Subscription
- Renew Subscription
- Filter by:
  - Subscription Type
  - Subscription Status
  - Subscription Date
- Generate Reports

---

## Violation Management

- Add Violations
- Pay Violations
- Delete Violations
- View Student Violations
- Statistics
- Search by Student
- Filter by:
  - Violation Type
  - Payment Status
  - Date
- Annual Reports

---

## Product & Inventory Management

- Add Products
- Update Products
- Purchase Additional Stock
- Inventory Statistics
- Product Reports

---

## Sales Management

- Sell Products
- Sales History
- Search by Date
- Search by Seller
- View Sale Details
- Monthly Sales Reports

---

## Financial Management (Bank)

### Student Transactions

- Subscription Payments
- Subscription Renewals
- Violation Payments

Search Options:

- Date
- Student Name
- Operation Type

Reports:

- Monthly Report
- Complete Financial Report

### Inventory Transactions

- Product Sales
- New Product Purchases
- Stock Purchases

Search Options:

- Date
- Transaction Type

Reports:

- Monthly Report
- Complete Inventory Report

---

## User Management

- Add Users
- Update Users
- Activate Users
- Deactivate Users
- Search by Username

---

# Architecture

The project follows a layered architecture to ensure maintainability and separation of concerns.

```text
Presentation Layer (WinForms with Guna UI2)
        │
RESTful Web API
        │
Business Layer
        │
Data Access Layer
        │
SQL Server Database
```

---

# Technologies Used

- C#
- .NET
- ASP.NET Core Web API
- WinForms
- Guna UI2
- Entity Framework Core (Database First)
- SQL Server
- LINQ
- Async / Await
- JWT Authentication
- Refresh Tokens
- BCrypt
- Logger
- Transactions
- Swagger / OpenAPI
- RESTful API

---

# API Endpoints

| Module | Method | Endpoint | Description |
|--------|--------|----------|-------------|
| Authentication | POST | `/api/auth/login` | Authenticate user and return tokens |
| Authentication | POST | `/api/auth/refresh` | Refresh access token |
| Students | GET | `/api/students` | Get all students |
| Students | POST | `/api/students` | Add a new student |
| Students | PUT | `/api/students` | Update student data |
| Students | DELETE | `/api/students/{universityNumber}` | Delete a student |
| Rooms | GET | `/api/rooms` | Get all rooms |
| Rooms | POST | `/api/rooms` | Add a new room |
| Subscriptions | GET | `/api/Studentsubscriptions` | Get all subscriptions |
| Subscriptions | POST | `/api/Studentsubscriptions` | Create a new subscription |
| Violations | GET | `/api/violations` | Get all violations |
| Violations | POST | `/api/violations` | Add a new violation |
| Products | GET | `/api/products` | Get all products |
| Products | POST | `/api/products` | Add a new product |
| Sales | GET | `/api/sales` | Get sales history |
| Sales | POST | `/api/sales` | Create a new sale |
| Bank | GET | `/api/Bank/StudentOperations` | Get financial transactions |
| Users | GET | `/api/users` | Get all users |
| Users | POST | `/api/users` | Add a new user |

---

# Database Modules

- Students
- Rooms
- Specializations
- Student Subscriptions
- Subscription Types
- Violations
- Violation Types
- Products
- Sales
- Sale Details
- Bank
- Users

---

# Database Diagram (ERD)

The following diagram illustrates the database structure and relationships used throughout the system.

<p align="center">
  <img src="./2-%20Database/Database%20Diagram.png" alt="Database Diagram" width="1000">
</p>

---

# Design Principles

- Layered Architecture
- Separation of Concerns
- Repository Pattern
- Dependency Injection
- DTO Pattern
- RESTful API Design
- Clean Code Practices

---

# Future Improvements

- Email Notifications
- QR Code / Barcode Support
- Online Student Portal
- Analytics Dashboard
- Cloud Deployment
- Multi-language Support

---

# Purpose

This project was developed as a comprehensive software engineering project to apply enterprise application development concepts using C# and ASP.NET Core.

It combines student housing management, subscriptions, violations, inventory, sales, and financial operations into a single integrated platform while emphasizing clean architecture, a modern interface, scalable design, and real-world backend development practices.

## Demo
Watch the system demo: https://youtu.be/kFjFK8aHA5k?si=6gfkIsfptx-GzeiZ
