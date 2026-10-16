# JT_CMS.Repositories.Caching

*Decorators* que adicionam **cache** aos repositórios usando `ICacheProvider`. Habilitado no host com:

```csharp
services.AddCachedRepositories();
```

Deve ser chamado **após** o registro do repositório real (`AddRepositoryServices`). Leituras são servidas do cache e escritas invalidam as chaves relacionadas.

## 🖼️ Imagens

> Coloque as imagens desta seção em [`docs/images/backend/repositories`](../../../../docs/images/backend/repositories/).

<!--
Exemplo de uso (descomente após adicionar a imagem):
![Descrição da imagem](../../../../docs/images/backend/repositories/nome-da-imagem.png)
-->
