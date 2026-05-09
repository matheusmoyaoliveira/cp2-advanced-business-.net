# 🐾 Checkpoint 002 — Sistema de Clínica Veterinária

Projeto desenvolvido em **ASP.NET Core MVC com Entity Framework Core**, implementando um CRUD completo para gerenciamento de animais.

---

## 📌 Objetivo
- Migration ✔
- CRUD completo ✔
- Tabela essencial ✔
- Listagem ✔

---

## 🛠️ Tecnologias
- .NET 10
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server LocalDB

---

## 📂 Estrutura
```
Controllers/
Models/
Views/
Data/
Migrations/
docs/evidencias/
```

---

## ▶️ Execução
```
dotnet restore
dotnet build
dotnet ef database update
dotnet run
```

Acesse:
http://localhost:5298/Animais

---

## 📸 Evidências

### Estrutura do Projeto
![Estrutura](docs/evidencias/01-estrutura-projeto.png)

### Model Animal
![Model](docs/evidencias/02-model-animal.png)

### DbContext
![DbContext](docs/evidencias/03-appdbcontext.png)

### Program.cs
![Program](docs/evidencias/04-program-dbcontext.png)

### Migrations
![Migrations](docs/evidencias/06-migrations.png)

### Listagem
![Lista](docs/evidencias/07-tela-listagem-animais.png)

### Create
![Create](docs/evidencias/08-tela-create-animal.png)

### Details
![Details](docs/evidencias/09-tela-details-animal.png)

### Edit
![Edit](docs/evidencias/10-tela-edit-animal.png)

### Delete
![Delete](docs/evidencias/11-tela-delete-animal.png)

---

## 🎯 Conclusão
Projeto atende todos os requisitos com EF Core, Migration e CRUD completo.

---

## 👨‍💻 Autor
Matheus Moya de Oliveira		- RM 562822
Ana Carolina Pereira Fontes		- RM 562145
