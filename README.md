# 📝 ToDoList Console App

A simple console-based task manager built with C# for managing personal tasks. This application allows users to **add**, **view**, and **remove** tasks, with **persistent storage** using JSON.

## 📦 Features

- ✅ View your current tasks
- ➕ Add new tasks
- ❌ Remove tasks
- 💾 Automatic saving and loading to/from a local JSON file
- 💡 User-friendly and clean command-line interface

## 🛠 Technologies Used

- C# (.NET)
- JSON serialization (`System.Text.Json`)
- File I/O (`System.IO`)

## 📂 Project Structure

ToDoList/
│
├── Program.cs # Entry point of the app
├── TodoListManager.cs # Core logic for task handling
├── todoList.json # File where tasks are saved (auto-created)

bash
Kopiera

## 🚀 How to Run

1. Clone the repository:
   git clone https://github.com/your-username/ToDoList.git
   cd ToDoList

Build and run the application:

bash
dotnet run
