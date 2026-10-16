# JT_CMS.Repositories.EFCore.SqlServer

Provider EF Core para **SQL Server**.

## Uso

`appsettings.json`:

```json
{
  "Database": "sqlserver",
  "ConnectionStrings": { "DefaultConnection": "<sua connection string>" }
}
```

Registro feito por `AddSqlServerRepositories` (chamado por `RepositoryServiceExtensions` no host).

## Conteúdo

- `Setup.sql` – script de criação do esquema.
- `SetupRepository.cs` – executa a instalação inicial.
- `*ServiceExtensions.cs` – configuração do DbContext.

## 🖼️ Imagens

> Coloque as imagens desta seção em [`docs/images/backend/repositories`](../../../../docs/images/backend/repositories/).

<!--
Exemplo de uso (descomente após adicionar a imagem):
![Descrição da imagem](../../../../docs/images/backend/repositories/nome-da-imagem.png)
-->
