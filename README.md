# Checkpoint 002 — ASP.NET Core MVC (Clínica Veterinária)

Sistema CRUD para cadastro de animais, desenvolvido com ASP.NET Core MVC e Entity Framework Core, incluindo Migrations e persistência em SQL Server (LocalDB).

## Objetivo

Atender aos requisitos da Checkpoint:

- Migration configurada
- Tabela essencial (sem relacionamentos)
- CRUD completo
- Listagem de itens cadastrados

## Stack

- .NET 10
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server LocalDB

## Estrutura do Projeto

cp2-advanced-business-.net/
├── Controllers/
├── Data/
├── Migrations/
├── Models/
├── Views/
├── wwwroot/
├── docs/
│   └── evidencias/
├── appsettings.json
└── Program.cs

## Modelagem

### Entidade: Animal

- Id
- Nome
- Especie
- Raca
- Idade
- Peso
- NomeTutor
- TelefoneTutor
- DataCadastro

## Migrations

Criar migration:

dotnet ef migrations add InitialCreate

Aplicar no banco:

dotnet ef database update

## CRUD

Funcionalidades:

- Listar animais
- Criar animal
- Editar animal
- Visualizar detalhes
- Excluir animal

Rota principal:

/Animais

## Como Executar

dotnet restore
dotnet build
dotnet ef database update
dotnet run

Acesse:

http://localhost:5298/Animais

## Evidências

Local:

docs/evidencias/

## Conclusão

O projeto atende todos os requisitos da Checkpoint 2, incluindo uso de Migration, CRUD completo e persistência em banco de dados.
