# JT_CMS.Providers.MessageBusProviders

Implementação padrão do provider de **barramento de mensagens**: `InMemoryMessagePublisher`.

Publica mensagens de eventos (ex.: criação de página/usuário) para os `IMessageHandler` registrados em `JT_CMS.Services/MessageHandlers`.

## Registro

```csharp
services.AddInMemoryMessageBusProvider();
```



## Estrutura

| Arquivo | Descrição |
|---|---|
| `InMemoryMessagePublisher.cs` | Implementação de `IMessagePublisher` |
| `ServiceExtensions.cs` | Método de extensão para registro no DI |

Contrato: [JT_CMS.Providers.MessageBusProviders.Abstractions](../JT_CMS.Providers.MessageBusProviders.Abstractions/README.md)

## 🖼️ Imagens

> Coloque as imagens desta seção em [`docs/images/providers`](../../../../docs/images/providers/).

<!--
Exemplo de uso (descomente após adicionar a imagem):
![Descrição da imagem](../../../../docs/images/providers/nome-da-imagem.png)
-->
