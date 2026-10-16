# JT_CMS.Repositories.EFCore.MySql

Provider EF Core para **MySQL**.

## Uso

`appsettings.json`:

```json
{
  "Database": "mysql",
  "ConnectionStrings": { "DefaultConnection": "<sua connection string>" }
}
```

Registro feito por `AddMySqlRepositories` (chamado por `RepositoryServiceExtensions` no host).

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
