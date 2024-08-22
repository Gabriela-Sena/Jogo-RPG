# Jogo RPG Console - Gabriela Sena da Silva

Este é um jogo RPG em modo console desenvolvido em C#. O objetivo deste projeto é demonstrar conceitos de Programação Orientada a Objetos (POO) como herança, polimorfismo e interfaces, utilizando `enum` para definir raças e classes de personagens.

## Funcionalidades

- Criação de personagens com diferentes raças e classes.
- Sistema de combate básico entre personagens.
- Implementação de profissões que os personagens podem ter.
- Utilização de `enum` para representar raças e classes.

## Estrutura do Projeto

### Enums

- **Raca**: Define as possíveis raças dos personagens.
  - `Humano`
  - `Elfo`
  - `Anao` (Anão)
  - `Orc`

- **Classe**: Define as possíveis classes dos personagens.
  - `Guerreiro`
  - `Mago`
  - `Arqueiro`

### Classes

- **Personagem**: Classe abstrata base para todos os personagens.
  - Propriedades: `Nome`, `Raca`, `Classe`, `Forca`, `Agilidade`, `Inteligencia`, `Vida`
  - Métodos Abstratos: `Atacar()`, `Defender()`

- **Raças**:
  - `Humano`: Implementa a classe `Personagem` com atributos e comportamentos específicos.
  - `Elfo`: Implementa a classe `Personagem` com atributos e comportamentos específicos.
  - `Anao` (Anão): Implementa a classe `Personagem` com atributos e comportamentos específicos.
  - `Orc`: Implementa a classe `Personagem` com atributos e comportamentos específicos.

- **Profissões**:
  - `Ferreiro`: Implementa a interface `IProfissao`.
  - `Alquimista`: Implementa a interface `IProfissao`.

- **GerenciadorDePersonagens**: Classe responsável por criar personagens e gerenciar combates.

- **Program**: Classe principal que inicia o jogo, cria personagens e realiza um combate.