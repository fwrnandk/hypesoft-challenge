ADR-001: Escolha da Arquitetura Clean + CQRS para Backend

Status: Aceito
Data: 21/01/2026
Autores: Fernando Santos

1. Contexto

Para o backend do projeto Hypesoft Challenge, precisamos de uma arquitetura que:

Seja manutenível e escalável para futuros módulos (produtos, categorias, dashboard).

Permita testes unitários e integração de forma simples.

Separe responsabilidades entre Domain, Application, Infrastructure e API.

Atenda aos padrões de mercado em startups e empresas sólidas.

2. Decisão

Adotar Clean Architecture combinada com CQRS:

Domain: entidades, agregados e interfaces de repositório.

Application: comandos (Commands) e consultas (Queries) via MediatR.

Infrastructure: implementações concretas de repositórios e integração externa (MongoDB, Keycloak).

API: controllers REST expostos com Swagger, autenticação via JWT/Keycloak.

Motivos:

Separação clara de responsabilidades.

Facilita testes unitários (Application e Domain desacoplados).

CQRS permite otimizar consultas e comandos de forma independente.

Compatível com evolução futura (microserviços, Docker, CI/CD).

3. Consequências

Positivas:

Código organizado por camada e responsabilidade.

Facilita onboarding de novos devs e manutenção.

Preparado para expansão do sistema (produtos, categorias, etc).

Negativas / Considerações:

Inicialmente exige mais código boilerplate.

Curva de aprendizado para quem não conhece CQRS/MediatR.

4. Decisão Alternativa Considerada

Arquitetura Monolítica simples (Controllers + Repositórios)

Mais rápido para implementar.

Difícil de manter e testar em projetos maiores.

Conclusão: Clean Architecture + CQRS é melhor para manutenção, testes e evolução futura.