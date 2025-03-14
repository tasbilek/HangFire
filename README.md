# Hangfire with Factory Design Pattern

📌 A background job processing system using Hangfire, .NET 9, MemoryStorage, and Minimal API.

---

## 📖 Table of Contents
- [Overview](#overview)
- [Features](#features)
- [Tech Stack](#tech-stack)
  - [Design Pattern](#design-pattern)
  - [Libraries](#libraries)
- [Setup](#setup)
  - [Prerequisites](#prerequisites)
  - [Running Locally](#running-locally)
- [Contributing](#contributing)
- [License](#license)

---

## 🔍 Overview
This project demonstrates the usage of **Hangfire** with **.NET 9**, utilizing **MemoryStorage** for job persistence and **Minimal API** for lightweight HTTP endpoints. Additionally, it incorporates the **Factory Design Pattern** to create background job services in a structured and scalable manner.

---

## 🚀 Features
✅ **.NET 9** as the core framework.  
✅ **Hangfire** for background job processing.  
✅ **MemoryStorage** as the job persistence mechanism.  
✅ **Minimal API** for lightweight HTTP endpoints.  
✅ **Factory Design Pattern** for service creation and dependency injection.

---

## 🛠 Tech Stack
### ⚙️ Design Pattern
- **Factory Design Pattern**

### 📚 Libraries
- **Hangfire**
- **Hangfire.AspNet.Core**
- **Hangfire.MemoryStorage**
- **Microsoft.AspNetCore.OpenApi**
- **Scalar.AspNetCore**

---

## 🛠 Setup
### 🔗 Prerequisites
- [🔗 .NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)

### ▶️ Running Locally
1. Clone the repository:
   ```bash
   git clone https://github.com/tasbilek/Hangfire.git
   cd Hangfire
   ```
2. Restore the dependencies:
   ```bash
   dotnet restore
   ```
3. Run the application:
   ```bash
   dotnet run
   ```
   The scalar page will be accessible at [http://localhost:5000/scalar/v1](http://localhost:5000/scalar/v1) (or as configured).

### 📊 Accessing Hangfire Dashboard
Once the application is running, you can access Hangfire's dashboard at:
```
http://localhost:5000/hangfire
```

---

## 🤝 Contributing
Feel free to fork this repository, submit issues, and create pull requests to improve the project.

---

## 📜 License
This project is licensed under the [MIT License](https://opensource.org/licenses/MIT).
