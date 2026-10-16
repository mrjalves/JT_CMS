# JT_CMS.Providers.EmailProviders.Abstractions

Contratos (abstrações) do provider de **e-mail**. Permite trocar a implementação concreta sem alterar o restante do sistema.

## Contrato

```csharp
public interface IEmailProvider
{
    Task Send(string from, string recipients, string? subject, string? body, CancellationToken cancellationToken = default);
    Task Send(string recipients, string? subject, string? body, CancellationToken cancellationToken = default);
}
```

## Como usar

Injete `IEmailProvider` via injeção de dependência. A implementação padrão está em [JT_CMS.Providers.EmailProviders](../JT_CMS.Providers.EmailProviders/README.md).

## 🖼️ Imagens

> Coloque as imagens desta seção em [`docs/images/providers`](../../../../docs/images/providers/).

<!--
Exemplo de uso (descomente após adicionar a imagem):
![Descrição da imagem](../../../../docs/images/providers/nome-da-imagem.png)
-->
