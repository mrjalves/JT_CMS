# JT_CMS.Repositories.EFCore

Base comum para os bancos relacionais via **Entity Framework Core**.

| Item | Descrição |
|---|---|
| `JT_CMSDbContext.cs` | `DbContext` da aplicação |
| `DbModels/` | Modelos de tabela (`PageModel`, `UserModel`, ...) |
| `Repositories/` | Implementações dos repositórios |
| `MappingProfile.cs` | AutoMapper entre entidades e modelos |
| `EFCoreServiceExtensions.cs` | Registro comum |

Os projetos `.Sqlite`, `.SqlServer`, `.MySql` e `.PostgreSQL` fornecem apenas o *provider* específico e o `Setup.sql`.

## 🖼️ Imagens

> Coloque as imagens desta seção em [`docs/images/backend/repositories`](../../../../docs/images/backend/repositories/).

<!--
Exemplo de uso (descomente após adicionar a imagem):
![Descrição da imagem](../../../../docs/images/backend/repositories/nome-da-imagem.png)
-->
