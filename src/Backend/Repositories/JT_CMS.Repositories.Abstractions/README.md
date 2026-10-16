# JT_CMS.Repositories.Abstractions

Interfaces de repositório independentes de tecnologia.

- `IEntityRepository<T>` – `Create`, `CreateMany`, `Update`, `Delete`, `DeleteMany`, `GetAll`, `GetById`, `GetByIds`.
- `IAuditableEntityRepository`, `ISiteAssociatedRepository`, `IQueryableRepository` – especializações.
- Um repositório por entidade (`IPageRepository`, `IUserRepository`, `ISiteRepository`, ...).
- `ISetupRepository` – criação do esquema/dados iniciais.
- `IApiExecutionContext` – contexto da requisição (usuário, site).

## 🖼️ Imagens

> Coloque as imagens desta seção em [`docs/images/backend/repositories`](../../../../docs/images/backend/repositories/).

<!--
Exemplo de uso (descomente após adicionar a imagem):
![Descrição da imagem](../../../../docs/images/backend/repositories/nome-da-imagem.png)
-->
