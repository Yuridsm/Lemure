# Intenção

Agregar responsabilidades adicionais a um objeto dinamicamente. Os Decorators fornecem uma alternativa flexível ao uso de subclasses para extensão de funcionalidades.

- Usa composição ao invés de herança.


# Problema

Eu tenho uma e-commerce que vendo alguns produtos destacados em 3 categorias:
- Camisas
    - Camisa Básica
    - Camisa com estampa de anime
    - Camisa com estampa de bandas musicais
    - Camisa de time
- Canecas
    - Caneca sem estampa
    - Caneca com estampa
- Agendas
    - Agenda sem argola
    - Agenda com argola
    - Agenda com Planner

Com o passar do tempo novos categorias podem entrar no e-commerce bem como diversos tipos dentro de uma mesma categoria podem surgir. Isso acarreta em muitas classes (quase que massivamente), por isso, vale a pena usar o Decorator Pattern para decorar as minhas classes de categória de produto, deste modo, aplicando o Open/Closed Principle no código, deixando-o testável e manutenível com o passar do tempo.