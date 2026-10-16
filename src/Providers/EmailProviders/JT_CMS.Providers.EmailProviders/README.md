# JT_CMS.Providers.EmailProviders

Implementação padrão do provider de **e-mail**: `SmtpEmailProvider`.

Envia e-mails via SMTP (ex.: recuperação de senha, formulário de contato).

## Registro

```csharp
services.AddSmtpEmailProvider();
```

## Configuração (`appsettings.json`)

```json
"Providers": { "Email": { "SmtpServerConfig": {
  "Server": "smtp.exemplo.com", "Port": 587, "Username": "", "Password": "",
  "EnableSsl": true, "From": "admin@exemplo.com" } } }
```

## Estrutura

| Arquivo | Descrição |
|---|---|
| `SmtpEmailProvider.cs` | Implementação de `IEmailProvider` |
| `ServiceExtensions.cs` | Método de extensão para registro no DI |

Contrato: [JT_CMS.Providers.EmailProviders.Abstractions](../JT_CMS.Providers.EmailProviders.Abstractions/README.md)

## 🖼️ Imagens

> Coloque as imagens desta seção em [`docs/images/providers`](../../../../docs/images/providers/).

<!--
Exemplo de uso (descomente após adicionar a imagem):
![Descrição da imagem](../../../../docs/images/providers/nome-da-imagem.png)
-->
