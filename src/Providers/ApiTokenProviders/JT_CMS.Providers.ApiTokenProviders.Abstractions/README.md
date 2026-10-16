# JT_CMS.Providers.ApiTokenProviders.Abstractions

Contratos (abstrações) do provider de **tokens de API**. Permite trocar a implementação concreta sem alterar o restante do sistema.

## Contrato

```csharp
public interface IApiTokenProvider
{
    string GenerateKey();
    string GenerateSecret(string apiKey);
    bool Validate(string apiKey, string secretKey);
}
```

## Como usar

Injete `IApiTokenProvider` via injeção de dependência. A implementação padrão está em [JT_CMS.Providers.ApiTokenProviders](../JT_CMS.Providers.ApiTokenProviders/README.md).

## 🖼️ Imagens

> Coloque as imagens desta seção em [`docs/images/providers`](../../../../docs/images/providers/).

<!--
Exemplo de uso (descomente após adicionar a imagem):
![Descrição da imagem](../../../../docs/images/providers/nome-da-imagem.png)
-->
