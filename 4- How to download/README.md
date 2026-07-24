# 🚀 Installation Guide

Follow the steps below to set up and run the project locally.

---

## 📥 Step 1: Clone the Repository

```bash
git clone https://github.com/othman-turk-dev/University-Housing-Management-System.git
```

---

## 🗄️ Step 2: Create the Database

Create or restore the SQL Server database using the provided SQL script.

Make sure all required tables are created successfully.

---

## 💻 Step 3: Open the Solutions

Open the backend solution:

```text
Project Server/
└── University Housing Management Project/
    └── University Housing Management System.sln
```

using Visual Studio.

---

## ⚙️ Step 4: Configure the Database Connection

Navigate to:

```text
API
└── appsettings.json
```

Update the connection string:

```json
"ConnectionStrings": {
  "DefaultConnection": "Your SQL Server Connection String"
}
```

---

## 📦 Step 5: Restore NuGet Packages

Restore all required NuGet packages.

```text
Build → Restore NuGet Packages
```

---

## ▶️ Step 6: Run the Backend API

Set the API project as the startup project and run the application.

Swagger will be available at:

```text
/swagger
```

---

## 🖥️ Step 7: Run the Desktop Application

Open the client solution:

```text
Project Client/
└── University Housing Management Project/
    └── University Housing Management System.sln
```

Set the WinForms project as the startup project and run it.

> **Note:** The Backend API must be running before starting the desktop application.

---

# 📋 Requirements

- Visual Studio
- .NET 9 SDK
- .NET Framework 4.8
- SQL Server