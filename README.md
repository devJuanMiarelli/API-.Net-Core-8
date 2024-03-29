### Versão do .NET

- .NET Core 8

### Installs do projeto

- Install Microsoft.EntityFrameworkCore; (8.0.3)
- Install Microsoft.EntityFrameworkCore.Design; (8.0.3)
- Install Microsoft.EntityFrameworkCore.SQLServer; (8.0.3)
- Install Microsoft.EntityFrameworkCore.Tools; (8.0.3)

### Database

- SQL Server 2022.
- SQL Server management studio 20. (Windows Authentication)

### Para rodar projeto (Migrations)

- Rodar Migrations: 
-> Ferramentas -> Gerenciador de pacotes do NuGet -> Console do gerenciador de pacotes:
 
    - Add-Migration InitialDB -Context ApplicationDbContext
    - Update-Database -Context ApplicationDbContext


### Exercício 2 - Oracle ou SQL Server

- Tabelas e querys criadas dentro de "DATABASE.txt".

### Exercício 3  - Microsserviços

- Resolução dentro de "microservices.txt" e diagrama "microservices.png".