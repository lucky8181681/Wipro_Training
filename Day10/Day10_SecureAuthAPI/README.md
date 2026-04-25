# 🔐 Day10 - SecureAuthAPI

## 📌 Overview
This project is an ASP.NET Core Web API that implements user authentication with secure password handling using SHA256 hashing.

---

## 🚀 Features
- User Registration
- Secure Password Hashing
- User Login with validation
- API testing using Swagger

---

## 🛠️ Tech Stack
- ASP.NET Core Web API
- C#
- Swagger (OpenAPI)
- System.Security.Cryptography

---

## 🔗 API Endpoints

### 🔹 Register
POST `/api/auth/register`  
Takes username and password, stores password in hashed format.

### 🔹 Login
POST `/api/auth/login`  
Validates user credentials by comparing hashed passwords.

---

## 🔐 Security
- Passwords are hashed using SHA256
- No plain text password storage

---

## 🧪 How to Run
1. Run the project
2. Open browser:
   http://localhost:5112/swagger
3. Test the APIs using Swagger UI

---

## 🎯 Outcome
Developed a secure Web API for user authentication and gained understanding of backend API development and password security.