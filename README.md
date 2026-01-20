# Hypesoft Challenge - Sistema de Gestão de Produtos

Este repositório contém a implementação do desafio técnico da **Hypesoft**, consistindo em um sistema completo de gestão de produtos com foco em arquitetura moderna, boas práticas e escalabilidade.

## 🧠 Visão Geral

A aplicação permite:
- Gestão de produtos e categorias
- Controle de estoque
- Dashboard com indicadores
- Autenticação e autorização via Keycloak
- Arquitetura baseada em Clean Architecture, DDD e CQRS

## 🛠️ Stack Tecnológica

### Backend
- .NET 9
- MongoDB
- Clean Architecture + DDD
- CQRS + MediatR
- FluentValidation
- Serilog

### Frontend
- Next.js 14 (App Router)
- React 18 + TypeScript
- TailwindCSS + shadcn/ui
- TanStack Query
- React Hook Form + Zod

### Infraestrutura
- Docker & Docker Compose
- Keycloak
- Nginx

## 📁 Estrutura do Repositório

```text
backend/    # API e regras de negócio
frontend/   # Interface do usuário
docker/     # Configurações de containers
docs/       # Documentação técnica e decisões arquiteturais

## 📐 Decisões Arquiteturais

As principais decisões arquiteturais do projeto estão documentadas utilizando **ADR (Architecture Decision Records)** e podem ser encontradas em:

- `docs/adr/001-architecture-overview.md`
- `docs/adr/002-mongodb-persistence.md`
- `docs/adr/003-frontend-nextjs.md`

