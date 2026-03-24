mkdir TodoApiProject
cd TodoApiProject
dotnet new sln -n TodoSolution
dotnet new webapi -n TodoApi
dotnet sln add TodoApi/TodoApi.csproj
cd TodoApi
mkdir Controllers
mkdir Models
mkdir Services
mkdir Data
dotnet add package Microsoft.EntityFrameworkCore.InMemory --version 8.0.0
dotnet add package Microsoft.EntityFrameworkCore --version 8.0.0
dotnet restore
dotnet list package

