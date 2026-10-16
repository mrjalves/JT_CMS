# JT_CMS.Providers.CacheProviders.Abstractions

Contratos (abstrações) do provider de **cache**. Permite trocar a implementação concreta sem alterar o restante do sistema.

## Contrato

```csharp
public interface ICacheProvider
{
    void Remove(string key);
    void Set<T>(string key, T value);
    bool TryGetValue<T>(string key, out T? value);
}
```

## Como usar

Injete `ICacheProvider` via injeção de dependência. A implementação padrão está em [JT_CMS.Providers.CacheProviders](../JT_CMS.Providers.CacheProviders/README.md).

## 🖼️ Imagens

> Coloque as imagens desta seção em [`docs/images/providers`](../../../../docs/images/providers/).

<!--
Exemplo de uso (descomente após adicionar a imagem):
![Descrição da imagem](../../../../docs/images/providers/nome-da-imagem.png)
-->
