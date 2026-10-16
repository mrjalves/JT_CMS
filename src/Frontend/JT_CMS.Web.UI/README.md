# JT_CMS.Web.UI

Aplicação Blazor que renderiza os sites e hospeda o **Site Builder** (editor visual de páginas).

## Estrutura

| Pasta | Descrição |
|---|---|
| `Components/` | `SiteBuilder`, toolbar, `AdminSidebar`, `PluginContainer`, `PluginsSection`, `PageSettingsModal`, `TailwindStyles` |
| `DynamicRendering/` | `LayoutProcessor` e segmentos (`HtmlSegment`, `ComponentSegment`) que montam o layout com plugins |
| `PluginLoader/` | Carregamento dinâmico de plugins (`PluginLoadContext`) |
| `MessageHandlers/` | Reação a eventos (ex.: regenerar estilos Tailwind) |
| `Setup/` | Assistente de instalação (`SetupView`) |
| `Styles/` | Fontes SCSS (npm) compiladas para `wwwroot/css` |
| `wwwroot/` | CSS, JS, imagens e arquivos do setup |
| `RemoteFileProviderMiddleware.cs` | Serve arquivos armazenados pelo provider de storage |
| `ServiceExtensions.cs` | `AddCmsServices` / `UseCmsServices` |

## Compilar estilos

```bash
cd Styles
npm install
npm run build
```

## 🖼️ Imagens

> Coloque as imagens desta seção em [`docs/images/frontend/web-ui`](../../../docs/images/frontend/web-ui/).

<!--
Exemplo de uso (descomente após adicionar a imagem):
![Descrição da imagem](../../../docs/images/frontend/web-ui/nome-da-imagem.png)
-->
