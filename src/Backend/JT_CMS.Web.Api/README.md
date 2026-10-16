# JT_CMS.Web.Api

API REST (ASP.NET Core) com documentação **Swagger**. É consumida pelo frontend através de `JT_CMS.Web.ApiClients`.

## Estrutura

| Pasta | Descrição |
|---|---|
| `Controllers/` | Um controller por recurso (Account, User, Role, Site, Page, Layout, Block, Content, ContentType, File, Folder, Plugin, PluginDefinition, Settings, GlobalSettings, ApiToken, Setup) |
| `Models/` | DTOs de requisição e resposta, agrupados por recurso; `ApiResult`, `ApiPagingResult` |
| `Attributes/` | `PolicyAttribute` – exige política de acesso |
| `Filters/` | Tratamento de resultado/exceção e autenticação por API Token |
| `Middleware/` | `JwtAuthorizationMiddleware` |
| `Extentions/` | Registro da API e do Swagger |
| `Validation/` | Validadores customizados (ex.: `Slug`) |

Todas as respostas seguem o envelope `ApiResult`.

## 🖼️ Imagens

> Coloque as imagens desta seção em [`docs/images/backend/web-api`](../../../docs/images/backend/web-api/).

<!--
Exemplo de uso (descomente após adicionar a imagem):
![Descrição da imagem](../../../docs/images/backend/web-api/nome-da-imagem.png)
-->
