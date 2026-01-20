# ADR 002 - Estratégia de Persistência com MongoDB

## Status
Aceito

## Contexto
O desafio define o uso de MongoDB como banco de dados principal. MongoDB é um banco NoSQL orientado a documentos, que não se beneficia de um ORM relacional tradicional.

## Decisão
Foi decidido utilizar o **MongoDB Driver oficial para .NET**, implementando o padrão de **repositórios** para abstrair o acesso aos dados.

A camada de domínio não possui dependência direta com o banco de dados, garantindo isolamento e aderência aos princípios da Clean Architecture.

## Consequências
- Melhor aderência ao modelo NoSQL
- Maior controle sobre consultas e performance
- Facilidade para testes e substituição de infraestrutura
- Evita acoplamento indevido com tecnologias de persistência
