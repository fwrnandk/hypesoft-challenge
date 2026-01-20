# ADR 001 - Visão Geral da Arquitetura

## Status
Aceito

## Contexto
O sistema de gestão de produtos precisa ser escalável, de fácil manutenção e preparado para evolução futura. O desafio exige boas práticas arquiteturais, separação de responsabilidades e integração com serviços externos como autenticação e banco de dados.

## Decisão
Foi adotada uma arquitetura baseada em **Clean Architecture**, utilizando princípios de **Domain-Driven Design (DDD)** e o padrão **CQRS** para separação de comandos e consultas.

A aplicação foi organizada em camadas bem definidas:
- **Domain**: regras de negócio e entidades
- **Application**: casos de uso, comandos, queries e validações
- **Infrastructure**: acesso a dados e integrações externas
- **API**: exposição dos endpoints e configuração da aplicação

O projeto utiliza **MongoDB** como banco de dados principal, acessado via **driver oficial**, evitando o uso inadequado de um ORM relacional.

## Consequências
- Código mais organizado e testável
- Facilidade para evolução e manutenção
- Maior clareza na separação de responsabilidades
- Curva inicial de aprendizado um pouco maior, compensada pela qualidade final
