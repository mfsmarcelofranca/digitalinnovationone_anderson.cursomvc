# digitalinnovationone_anderson.cursomvc
Projeto da aula: Desenvolvimento de aplicações com .NET - Digital Innovation One - Especialista: Anderson Clavico Moreira

### No curso foi utilizado o Visual Studio e SqlServer
### Para acompanhar a aula foram utilizados:
###### O Visual Code e Comandos dotnet CLI
###### O MySQL - Wampserver
### Comandos utilizados dotnet CLI

#### criar projeto:
###### dotnet new mvc -n nomeProjeto

#### criar migrations:
##### Instalar ferramenta dotnet ef:
###### dotnet tool install --global dotnet-ef

#### Adionar uma migration:
###### dotnet ef migrations add nomeMigration

#### Atualizar ferramenta:
###### dotnet tool update --global dotnet-ef

#### Enviar migrações para base de dados:
###### dotnet ef database update

### Scalfold dotnet CLI
###### dotnet tool install -g dotnet-aspnet-codegenerator

#### Atualizar
###### dotnet tool update -g dotnet-aspnet-codegenerator

#### Adicionando pacote
###### dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design

#### Criando Controller 
###### dotnet aspnet-codegenerator controller -name CategoriaController -m Categoria -dc Context --relativeFolderPath Controllers --useDefaultLayout
###### dotnet aspnet-codegenerator controller -name ProdutoController -m Produto -dc Context --relativeFolderPath Controllers --useDefaultLayout

###### 1- O comando : dotnet aspnet-codegenerator
###### 2- O controller :  controller -name NomeController
###### 3- O model : -m NomeModel
###### 4- O contexto : -dc nomeContext
###### 5- A pasta usada para o Controlador: --relativeFolderPath Controllers
###### 6- O leiaute usado para criar o arquivo: --useDefaultLayout

### Adicionando referencia a outro projeto:
###### dotnet add reference ../CursoMVC/CursoMVC.csproj

### API REST
##### dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
##### dotnet add package Microsoft.EntityFrameworkCore.Design
##### dotnet tool install -g dotnet-aspnet-codegenerator
##### dotnet tool update -g dotnet-aspnet-codegenerator

### criar controller
##### dotnet aspnet-codegenerator controller -name CategoriasController -async -api -m Categoria -dc Context -outDir Controllers
##### dotnet aspnet-codegenerator controller -name ProdutosController -async -api -m Produto -dc Context -outDir Controllers
