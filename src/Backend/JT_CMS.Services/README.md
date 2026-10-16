# JT_CMS.Services

Camada de **regras de negócio**. Cada entidade possui um serviço (`PageService`, `SiteService`, `UserService`, `FileService`, ...), registrado por `AddApplicationServices()` (`ServiceExtensions.cs`) via `IAutoRegisterService`.

## Estrutura

| Pasta/Arquivo | Descrição |
|---|---|
| `*Service.cs` | Serviços por entidade (CRUD + regras) |
| `MessageHandlers/` | Handlers de eventos publicados no barramento de mensagens |
| `Models/` | Templates (`SiteTemplate`, `PageTemplate`, ...), `JwtOptions`, `UserToken`, etc. |
| `Permissions/` | `IPermissionManager` / `PermissionManager` – autorização por política |
| `SetupService.cs` | Instalação inicial e importação de templates de site |
| `UserTokenProvider.cs` | Geração de JWT e tokens de redefinição de senha |
| `MappingProfile.cs` | Mapeamentos AutoMapper |

Configuração JWT em `appsettings.json` (`JwtOptions`).

## 🖼️ Imagens

> Coloque as imagens desta seção em [`docs/images/backend/services`](../../../docs/images/backend/services/).

<!--
Exemplo de uso (descomente após adicionar a imagem):
![Descrição da imagem](../../../docs/images/backend/services/nome-da-imagem.png)
-->
