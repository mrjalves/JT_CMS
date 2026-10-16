# JT_CMS.Providers.CacheProviders

Implementação padrão do provider de **cache**: `InMemoryCacheProvider`.

Cache em memória usado pela camada de repositórios em cache.

## Registro

```csharp
services.AddInMemoryCacheProvider();
```



## Estrutura

| Arquivo | Descrição |
|---|---|
| `InMemoryCacheProvider.cs` | Implementação de `ICacheProvider` |
| `ServiceExtensions.cs` | Método de extensão para registro no DI |

Contrato: [JT_CMS.Providers.CacheProviders.Abstractions](../JT_CMS.Providers.CacheProviders.Abstractions/README.md)

## 🖼️ Imagens

> Coloque as imagens desta seção em [`docs/images/providers`](../../../../docs/images/providers/).

<!--
Exemplo de uso (descomente após adicionar a imagem):
![Descrição da imagem](../../../../docs/images/providers/nome-da-imagem.png)
-->
