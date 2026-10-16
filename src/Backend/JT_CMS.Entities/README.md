# JT_CMS.Entities

Modelo de domínio do CMS, independente de banco de dados.

## Hierarquia base

- `Entity` → identificador (`Guid`).
- `AuditableEntity` → adiciona dados de auditoria (criação/alteração); `AuditableEntityLog` registra o histórico.
- `SiteAssociatedEntity` → entidades que pertencem a um **Site** (multi-site).

## Entidades principais

| Entidade | Descrição |
|---|---|
| `Site`, `Page`, `Layout`, `Block` | Estrutura e apresentação dos sites |
| `Plugin`, `PluginDefinition`, `PluginContent` | Plugins colocados nas páginas e seus conteúdos |
| `ContentType`, `ContentTypeField`, `Content` | Conteúdos dinâmicos (ex.: blog, projetos) |
| `Folder`, `File` | Gerenciador de arquivos |
| `User`, `Role`, `UserRole`, `Permission`, `Policy` | Segurança e autorização |
| `ApiToken` | Tokens de acesso à API |
| `Settings`, `GlobalSettings` | Configurações por site e globais |

Ver também `SiteAssociatedEntities/` (entidades vinculadas a um site).

## 🖼️ Imagens

> Coloque as imagens desta seção em [`docs/images/backend/entities`](../../../docs/images/backend/entities/).

<!--
Exemplo de uso (descomente após adicionar a imagem):
![Descrição da imagem](../../../docs/images/backend/entities/nome-da-imagem.png)
-->
