# JT_CMS.Repositories.LiteDb

Persistência em [LiteDB](https://www.litedb.org/) (banco embutido, arquivo único). **É o padrão** do projeto e dispensa instalação de servidor.

```json
{
  "Database": "LiteDb",
  "ConnectionStrings": { "DefaultConnection": "Filename=./JT_CMS.db" }
}
```

Principais arquivos: `LiteDBContext.cs`, `LiteDBOptions.cs`, `LiteDbServiceExtensions.cs` (`AddLiteDbRepositories`) e um repositório por entidade.

## 🖼️ Imagens

> Coloque as imagens desta seção em [`docs/images/backend/repositories`](../../../../docs/images/backend/repositories/).

<!--
Exemplo de uso (descomente após adicionar a imagem):
![Descrição da imagem](../../../../docs/images/backend/repositories/nome-da-imagem.png)
-->
