# Movies API

## Rationales

- Lembrar ver o que foi instalado pra usar o Postgres
- dotnet tool install --global dotnet-ef 
- dotnet add package Microsoft.EntityFrameworkCore.Design
- dotnet ef migrations add Initial 
  - Initial é o nome ele faz o diff do esquema existente pro novo.
  - Sempre tem um up (o que é adicionado) e o down (se quiser desfazer)
- dotnet ef database update -> estudar mas deve ser pra aplicar todas as migrations
- https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/init
- See about profiles 
- CancellationToken
- https://learn.microsoft.com/en-us/ef/core/modeling/inheritance