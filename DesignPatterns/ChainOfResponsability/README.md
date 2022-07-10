# O poblema que vamos resolvera ser resolvido é o seguinte:

 - Resolver a aprovação de orçamento de cliente.
 - O importante para o nosso código é o valor do orçamento, uma vez que vamos passá-lo por uma cadeia de responsabilidades, as quais vão tratá-lo.
 - Se o valor do orçamento estiver dentro dos parâmetros do vendedor - um handler -, este mesmo pode aprovar o orçamento; caso contrário, passa a responsabilidade dessa tratativa para o próximo handler na cadeia - ou seja, um gerente.

# Handlers:
 - Seller
 - Manager
 - Director
 - CEO