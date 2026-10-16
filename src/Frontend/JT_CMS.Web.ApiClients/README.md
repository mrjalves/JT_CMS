# JT_CMS.Web.ApiClients

Clientes HTTP tipados para a `JT_CMS.Web.Api`.

| Arquivo | Descrição |
|---|---|
| `GeneratedApiClients.cs` | Clientes gerados com **NSwag** a partir do Swagger (`config.nswag`) |
| `FileClient.cs` | Upload/download de arquivos |
| `ApiClientFactory.cs` | Criação de clientes autenticados |
| `ClientSettings.cs` | `Url` e `Key` da API (`appsettings.json` → `ClientSettings`) |
| `Services/AuthManager.cs` | Login, token e sessão |
| `Services/SetupManager.cs` | Fluxo de setup inicial |
| `ApiClientException.cs`, `ApiExceptionResult.cs` | Tratamento de erros da API |

Para regenerar os clientes, execute o NSwag com `config.nswag` com a API em execução.

## 🖼️ Imagens

> Coloque as imagens desta seção em [`docs/images/frontend/api-clients`](../../../docs/images/frontend/api-clients/).

<!--
Exemplo de uso (descomente após adicionar a imagem):
![Descrição da imagem](../../../docs/images/frontend/api-clients/nome-da-imagem.png)
-->
