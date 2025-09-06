# Functional-Program-Notebook
F# Programming


# Functional Program Notebook

This repo is my personal F# learning notebook.  
Each **lecture/topic** is its own F# console project inside the `topics/` folder.  
The repo is managed with a `.sln` solution file so all projects can be built together.

---

## 📂 Project Layout
```
Functional-Program-Notebook/
├─ Functional-Program-Notebook.sln   # Solution groups all projects
├─ topics/
│  ├─ 01-fs-intro/
│  │   ├─ HelloWorld.fsproj
│  │   └─ Program.fs
│  ├─ 02-recursion/
│  │   ├─ Recursion.fsproj
│  │   └─ Program.fs
│  └─

```

## 🚀 Everyday Commands

### Run a specific lecture project
```bash
dotnet run --project topics/<lecture-name>/<lecture-name>.fsproj

dotnet run --project topics/01-fs-intro/HelloWorld.fsproj

# 1. Create project under topics/
dotnet new console -lang "F#" -o topics/<lecture-name>

# 2. Add it to the solution
dotnet sln Functional-Program-Notebook.sln add topics/<lecture-name>/<lecture-name>.fsproj

dotnet new console -lang "F#" -o topics/03-pattern-matching
dotnet sln Functional-Program-Notebook.sln add topics/03-pattern-matching/03-pattern-matching.fsproj

dotnet build Functional-Program-Notebook.sln
dotnet clean Functional-Program-Notebook.sln
```