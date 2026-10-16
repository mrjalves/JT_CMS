# JT_CMS.Providers.ApiTokenProviders

Implementação padrão do provider de **tokens de API**: `JwtApiTokenProvider`.

Gera e valida chaves/segredos de API baseados em JWT/HMAC.

## Registro

```csharp
services.AddJwtApiTokenProvider();
```

## Configuração (`appsettings.json`)

```json
"Providers": { "ApiToken": { "JwtApiTokenConfig": { "Secret": "SUA_CHAVE_SECRETA" } } }
```

## Estrutura

| Arquivo | Descrição |
|---|---|
| `JwtApiTokenProvider.cs` | Implementação de `IApiTokenProvider` |
| `ServiceExtensions.cs` | Método de extensão para registro no DI |

Contrato: [JT_CMS.Providers.ApiTokenProviders.Abstractions](../JT_CMS.Providers.ApiTokenProviders.Abstractions/README.md)

## 🖼️ Imagens

> Coloque as imagens desta seção em [`docs/images/providers`](../../../../docs/images/providers/).

<!--
Exemplo de uso (descomente após adicionar a imagem):
![Descrição da imagem](../../../../docs/images/providers/nome-da-imagem.png)
-->
