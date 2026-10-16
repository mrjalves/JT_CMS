# JT_CMS.Providers.FileStorageProviders.Abstractions

Contratos (abstrações) do provider de **armazenamento de arquivos**. Permite trocar a implementação concreta sem alterar o restante do sistema.

## Contrato

```csharp
public interface IFileStorageProvider
{
    Task Upload(string fileName, Stream fileContent, CancellationToken cancellationToken = default);
    Task<Stream?> Download(string fileName, CancellationToken cancellationToken = default);
    Task Delete(string fileName, CancellationToken cancellationToken = default);
}
```

## Como usar

Injete `IFileStorageProvider` via injeção de dependência. A implementação padrão está em [JT_CMS.Providers.FileStorageProviders](../JT_CMS.Providers.FileStorageProviders/README.md).

## 🖼️ Imagens

> Coloque as imagens desta seção em [`docs/images/providers`](../../../../docs/images/providers/).

<!--
Exemplo de uso (descomente após adicionar a imagem):
![Descrição da imagem](../../../../docs/images/providers/nome-da-imagem.png)
-->
