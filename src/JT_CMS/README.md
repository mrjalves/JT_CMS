# JT_CMS (Host)

Projeto executável que une API, UI, repositórios, providers e plugins.

## Executar

```bash
dotnet run --project src/JT_CMS
```

Acesse `http://localhost:5000` — no primeiro acesso o assistente de **Setup** permite escolher o template (`Blank`, `Default` ou `Portfolio`).

## Estrutura

| Item | Descrição |
|---|---|
| `Program.cs` | Registro de serviços, providers e pipeline HTTP |
| `RepositoryServiceExtensions.cs` | Seleciona o banco conforme `Database` |
| `appsettings.json` | Configuração |
| `Templates/` | [Templates de site](Templates/README.md) |
| `files/` | Arquivos enviados (storage local) |
| `Properties/launchSettings.json` | Perfis de execução (porta 5000) |

## Configuração

| Chave | Descrição |
|---|---|
| `Database` | `LiteDb`, `MongoDB`, `Sqlite`, `SqlServer`, `MySql`, `PostgreSQL` |
| `ConnectionStrings:DefaultConnection` | Conexão com o banco |
| `ClientSettings` | URL e chave da API usada pela UI |
| `JwtOptions` | Emissor, audiência, segredo e expiração do JWT |
| `Providers:Email` | Servidor SMTP |
| `Providers:FileStorage` | Pasta de arquivos |
| `Providers:ApiToken` | Segredo dos tokens de API |

> ⚠️ Altere todos os segredos e credenciais antes de publicar em produção e prefira *User Secrets*/variáveis de ambiente.

## 🖼️ Imagens

> Coloque as imagens desta seção em [`docs/images/host`](../../docs/images/host/).

<!--
Exemplo de uso (descomente após adicionar a imagem):
![Descrição da imagem](../../docs/images/host/nome-da-imagem.png)
-->
