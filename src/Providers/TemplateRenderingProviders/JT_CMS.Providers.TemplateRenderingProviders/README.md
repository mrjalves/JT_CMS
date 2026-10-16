# JT_CMS.Providers.TemplateRenderingProviders

Implementação padrão do provider de **renderização de templates**: `ScribanTemplateRenderingProvider`.

Renderiza templates [Scriban](https://github.com/scriban/scriban) (arquivos `.sbn`) com um dicionário de valores.

## Registro

```csharp
services.AddScribanTemplateRenderingProvider();
```



## Estrutura

| Arquivo | Descrição |
|---|---|
| `ScribanTemplateRenderingProvider.cs` | Implementação de `ITemplateRenderingProvider` |
| `ServiceExtensions.cs` | Método de extensão para registro no DI |

Contrato: [JT_CMS.Providers.TemplateRenderingProviders.Abstractions](../JT_CMS.Providers.TemplateRenderingProviders.Abstractions/README.md)

## 🖼️ Imagens

> Coloque as imagens desta seção em [`docs/images/providers`](../../../../docs/images/providers/).

<!--
Exemplo de uso (descomente após adicionar a imagem):
![Descrição da imagem](../../../../docs/images/providers/nome-da-imagem.png)
-->
