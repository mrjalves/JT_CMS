# JT_CMS.Providers.FileStorageProviders

Implementação padrão do provider de **armazenamento de arquivos**: `LocalFileStorageProvider`.

Armazena os arquivos enviados no sistema de arquivos local.

## Registro

```csharp
services.AddLocalFileStorageProvider();
```

## Configuração (`appsettings.json`)

```json
"Providers": { "FileStorage": { "FileStorageConfig": { "Path": "files" } } }
```

## Estrutura

| Arquivo | Descrição |
|---|---|
| `LocalFileStorageProvider.cs` | Implementação de `IFileStorageProvider` |
| `ServiceExtensions.cs` | Método de extensão para registro no DI |

Contrato: [JT_CMS.Providers.FileStorageProviders.Abstractions](../JT_CMS.Providers.FileStorageProviders.Abstractions/README.md)

## 🖼️ Imagens

> Coloque as imagens desta seção em [`docs/images/providers`](../../../../docs/images/providers/).

<!--
Exemplo de uso (descomente após adicionar a imagem):
![Descrição da imagem](../../../../docs/images/providers/nome-da-imagem.png)
-->
