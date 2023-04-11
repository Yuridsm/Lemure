# Specification

Encapsulate business rules and query criteria into a single object. The goal of this pattern is to simplify the code and make it more expressive, allowing you to focus on the business logic rather than the details of querying data.

In the DDD Specification Pattern, a specification is an object that represents a predicate or a boolean expression that can be evaluated against a domain object. A specification can be composed of other specifications using logical operators such as AND, OR, and NOT.

Specification files:

    - LuxuryCarSpecification
        - Have color Black
        - Two year ago
        - Car Body Seda
    - YearCarSpecification
        - Current year car
