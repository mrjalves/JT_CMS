# JT_CMS.Providers.TemplateRenderingProviders.Abstractions

Contratos (abstrações) do provider de **renderização de templates**. Permite trocar a implementação concreta sem alterar o restante do sistema.

## Contrato

```csharp
public interface ITemplateRenderingProvider
{
    string Render(string? content, Dictionary<string, object> keyValues);
}
```

## Como usar

Injete `ITemplateRenderingProvider` via injeção de dependência. A implementação padrão está em [JT_CMS.Providers.TemplateRenderingProviders](../JT_CMS.Providers.TemplateRenderingProviders/README.md).

## 🖼️ Imagens

> Coloque as imagens desta seção em [`docs/images/providers`](../../../../docs/images/providers/).

<!--
Exemplo de uso (descomente após adicionar a imagem):
![Descrição da imagem](../../../../docs/images/providers/nome-da-imagem.png)
-->
