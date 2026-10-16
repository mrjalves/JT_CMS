# Plugins

Plugins Blazor carregados dinamicamente. Cada plugin possui modos **View** (exibição) e **Edit** (edição no Site Builder), declarados em `Templates/*/manifest.json`.

| Plugin | Categoria | Descrição |
|---|---|---|
| [Base](JT_CMS.Web.Plugins.Base/README.md) | – | Classes base e componentes compartilhados |
| [TextHTML](JT_CMS.Web.Plugins.TextHTML/README.md) | Content | Texto/HTML livre |
| [RichText](JT_CMS.Web.Plugins.RichText/README.md) | Content | Editor de texto rico |
| [IFrame](JT_CMS.Web.Plugins.IFrame/README.md) | Content | Incorpora páginas externas |
| [Block](JT_CMS.Web.Plugins.Block/README.md) | Content | Insere blocos reutilizáveis |
| [ContactUs](JT_CMS.Web.Plugins.ContactUs/README.md) | Content | Formulário de contato |
| [ContentViewer](JT_CMS.Web.Plugins.ContentViewer/README.md) | Content | Lista e detalhe de conteúdos dinâmicos |
| [Admin](JT_CMS.Web.Plugins.Admin/README.md) | Admin | Telas administrativas |

## Criando um plugin

1. Crie um projeto referenciando `JT_CMS.Web.Plugins.Base`.
2. Implemente `XxxViewPlugin` e `XxxEditPlugin` herdando de `BasePlugin`/`BaseEditPlugin`.
3. Registre o plugin no `manifest.json` (nome, assembly, tipos, ícone, stylesheets).
4. Referencie o projeto no host `JT_CMS.csproj`.

## 🖼️ Imagens

> Coloque as imagens desta seção em [`docs/images/frontend/plugins`](../../../docs/images/frontend/plugins/).

<!--
Exemplo de uso (descomente após adicionar a imagem):
![Descrição da imagem](../../../docs/images/frontend/plugins/nome-da-imagem.png)
-->
