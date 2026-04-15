# 🎓 Student Management System API

A robust and scalable **ASP.NET Core Web API** for managing students, built using **Clean Architecture principles**, **Repository Pattern**, and **Unit Testing**.

---

## 🚀 Features

* 🔐 Authentication & Authorization (JWT Ready)
* 👨‍🎓 Manage Students (CRUD Operations)
* 🧩 Clean Architecture (Services, Repositories, DTOs)
* 🔄 AutoMapper for object mapping
* 🧪 Unit Testing with xUnit & Moq
* 📦 Entity Framework Core with SQL Server
* 📊 Structured and maintainable codebase

---

## 🛠️ Tech Stack

* ASP.NET Core Web API
* Entity Framework Core
* SQL Server
* AutoMapper
* xUnit
* Moq
* Swagger (OpenAPI)
* Serilog (Logging)

---

## 📂 Project Structure

```
StudentManagementSystem/
│
├── Controllers/
├── Models/
├── DTOs/
├── Repositories/
├── Services/
├── Data/
├── Helpers/
├── Middleware/
├── Migrations/
├── StudentManagement.Tests/
│
└── Program.cs
```

---

## 📌 API Endpoints

### Students

| Method | Endpoint           | Description        |
| ------ | ------------------ | ------------------ |
| GET    | /api/students      | Get all students   |
| GET    | /api/students/{id} | Get student by ID  |
| POST   | /api/students      | Create new student |
| PUT    | /api/students/{id} | Update student     |
| DELETE | /api/students/{id} | Delete student     |

---

## ⚙️ How to Run

### 1. Clone the repository

```bash
git clone https://github.com/mohhameddelsayedd/Student-Management-System.git
```

### 2. Navigate to project

```bash
cd Student-Management-System
```

### 3. Update database

```bash
dotnet ef database update
```

### 4. Run the project

```bash
dotnet run
```

---

## 🧪 Running Tests

```bash
dotnet test
```

---

## 📷 API Documentation

Swagger UI will be available at:

```
https://localhost:<port>/swagger
```

---

## 💡 Key Highlights

* Designed with **Separation of Concerns**
* Follows **SOLID principles**
* Ready for **real-world backend development**
* Scalable and maintainable structure

---

## 👨‍💻 Author

**Mohamed Elsayed**
Backend Developer (.NET)

---

## 📬 Contact

* 📧 Email: [mohameddelsayedd114@gmail.com](mailto:mohameddelsayedd114@gmail.com)
* 📱 Phone: 01018520046

---

## ⭐ Give it a Star

If you like this project, please ⭐ the repository!
