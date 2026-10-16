# JT_CMS.Repositories.EFCore.Sqlite

Provider EF Core para **SQLite**.

## Uso

`appsettings.json`:

```json
{
  "Database": "sqlite",
  "ConnectionStrings": { "DefaultConnection": "<sua connection string>" }
}
```

Registro feito por `AddSqliteRepositories` (chamado por `RepositoryServiceExtensions` no host).

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
