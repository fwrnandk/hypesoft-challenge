# Hypesoft Challenge

Este projeto foi desenvolvido como parte do desafio técnico da Hypesoft, com foco em boas práticas de arquitetura, organização de código e escalabilidade.


## 📌 Visão Geral

API REST desenvolvida em .NET 9 utilizando Clean Architecture e CQRS, com separação clara de responsabilidades entre as camadas de domínio, aplicação, infraestrutura e API.


## 🧱 Arquitetura

O projeto segue os princípios da Clean Architecture, organizado da seguinte forma:

- **Hypesoft.Domain**  
  Contém entidades, regras de negócio e contratos (interfaces).

- **Hypesoft.Application**  
  Implementa os casos de uso da aplicação utilizando CQRS com MediatR.

- **Hypesoft.Infrastructure**  
  Implementações concretas de repositórios e integrações externas.

- **Hypesoft.API**  
  Camada de entrada da aplicação (Controllers, Swagger, autenticação).


## 🧠 Padrões e Decisões Técnicas

- **CQRS** para separar leitura e escrita
- **MediatR** para desacoplamento entre camadas
- **Repository Pattern** para abstração de persistência
- **Swagger** para documentação e testes da API


## 🔐 Autenticação

A aplicação está preparada para autenticação via JWT, com integração planejada com o **Keycloak** para gerenciamento de identidade e autorização.


## 🚀 Como rodar o projeto

### Pré-requisitos
- .NET SDK 9.0+

### Executando a API

dotnet restore
dotnet run --project Hypesoft.API


Após iniciar, o Swagger estará disponível em:

https://localhost:5001/swagger


## 🛠 Tecnologias Utilizadas

- .NET 9
- ASP.NET Core
- MediatR
- Swagger / OpenAPI
- Docker (em andamento)
- Keycloak (planejado)

## 📦 Funcionalidades

- CRUD de Usuários
- CRUD de Produtos
- CRUD de Categorias
- Endpoints REST
- Swagger para testes
- [ ] Produtos e Categorias
- [ ] Testes automatizados
