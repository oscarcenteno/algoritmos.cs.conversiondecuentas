# algoritmos.cs.conversiondecuentas
Ilustración de cómo verificar un algoritmo que retorna una lista de strings.

[![Build status](https://ci.appveyor.com/api/projects/status/mptkpbrt1gg0k24e?svg=true)](https://ci.appveyor.com/project/oscarcenteno/algoritmos-cs-conversiondecuentas)

## Tipos de algoritmos
Los algoritmos los diferenciamos de acuerdo a su tipo de retorno:
- Un dato escalar (un string, boolean, un número o una fecha)
- Una lista de escalares

Observemos que en este ejemplo tenemos dos algoritmos bien delimitados. Cada uno tiene sus pruebas unitarias bien realizadas:
* Uno que convierte una sola cuenta (string): Sus funciones se verifican con Assert.AreEqual.
* Uno que utiliza el anterior para convertir una lista de cuentas: se verifica con CollectionAssert.AreEqual

