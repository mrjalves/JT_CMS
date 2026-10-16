# Providers

Pontos de extensão de infraestrutura do JT_CMS. Cada provider possui um projeto de **abstrações** e uma **implementação padrão**, registrados no `Program.cs` do host.

| Provider | Interface | Implementação padrão |
|---|---|---|
| [ApiTokenProviders](ApiTokenProviders/README.md) | `IApiTokenProvider` | JWT |
| [CacheProviders](CacheProviders/README.md) | `ICacheProvider` | Memória |
| [EmailProviders](EmailProviders/README.md) | `IEmailProvider` | SMTP |
| [FileStorageProviders](FileStorageProviders/README.md) | `IFileStorageProvider` | Disco local |
| [MessageBusProviders](MessageBusProviders/README.md) | `IMessagePublisher` / `IMessageHandler` | Memória |
| [TemplateRenderingProviders](TemplateRenderingProviders/README.md) | `ITemplateRenderingProvider` | Scriban |

## 🖼️ Imagens

> Coloque as imagens desta seção em [`docs/images/providers`](../../docs/images/providers/).

<!--
Exemplo de uso (descomente após adicionar a imagem):
![Descrição da imagem](../../docs/images/providers/nome-da-imagem.png)
-->
