# ADR 003 - Frontend com Next.js 14

## Status
Aceito

## Contexto
A aplicação requer boa performance, SEO básico e uma experiência de usuário fluida, além de integração com autenticação via OAuth2/OpenID Connect.

## Decisão
Foi adotado o **Next.js 14 com App Router**, permitindo:
- Server-side rendering quando necessário
- Code splitting automático
- Estrutura moderna e escalável
- Integração eficiente com autenticação e APIs externas

A estilização utiliza **TailwindCSS** e **shadcn/ui**, garantindo consistência visual e produtividade.

## Consequências
- Melhor performance percebida
- Código frontend mais organizado
- Curva de aprendizado moderada
- Facilidade de manutenção e evolução
