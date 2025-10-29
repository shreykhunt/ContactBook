# 📘 Contact Book

## 🏷️ Project Title
**Contact Book using ASP.NET with CRUD Operations**

---

## 📖 Description
The **Contact Book** is a web-based ASP.NET application that allows users to manage personal and professional contacts efficiently.  
It includes full **CRUD (Create, Read, Update, Delete)** functionality and provides options to **export contact data** into **PDF** and **Excel** formats for easy sharing and backup.  
The system ensures simple, fast, and organized contact management.

---

## ⚙️ Installation Steps

1. **Clone or Download** the project from the repository.  
   ```bash
   git clone https://github.com/yourusername/ContactBook.git
   ```
   *(Or manually download and extract the ZIP file.)*

2. **Open the Project in Visual Studio**
   - Launch **Visual Studio**
   - Go to **File → Open → Project/Solution**
   - Select the `ContactBook.sln` file

3. **Check Required Dependencies**
   - Make sure **.NET Framework / .NET Core SDK** is installed
   - Ensure **Microsoft.EntityFrameworkCore** and **System.Data.SqlClient** packages are restored  
     *(Visual Studio will auto-restore them)*

4. **Configure Database Connection**
   - Open `appsettings.json` (for .NET Core) or `Web.config` (for ASP.NET)
   - Update the connection string with your SQL Server details:
     ```json
     "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=ContactDB;Trusted_Connection=True;"
     }
     ```

5. **Create the Database**
   - Open **SQL Server Management Studio (SSMS)**
   - Create a database named **ContactDB**
   - Run the provided SQL script (if included) or let EF migrations create tables automatically

---

## ▶️ How to Run the Project

1. In Visual Studio, set the project as **Startup Project**  
2. Press **F5** or click **Start Debugging**  
3. The app will open in your default web browser (e.g., `https://localhost:xxxx/`)  
4. Use the navigation menu to:
   - **Add New Contact**
   - **View All Contacts**
   - **Edit or Delete** existing contacts
   - **Export** data to **PDF** or **Excel**

---

## 🧩 Features
- Add, edit, view, and delete contact details  
- Search and filter contacts easily  
- Export data to **PDF** and **Excel**  
- User-friendly interface built in **ASP.NET**  
- Integrated with **SQL Server** backend  
