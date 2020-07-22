# Kata Life 

## Antes de empezar
- Unity 2018.4.16f1
- [Twitch Link](https://www.twitch.tv/videos/681730266)
- [YouTube Link](https://www.youtube.com/watch?v=jqWzNBGKzJQ)

## Descripción

El objetivo de esta Kata es aprender y practicar la técnica de Desarrollo Guiado por Pruebas, mejor conocido como TDD (Test-driven development).
Vas a programar una barra de vida de un jugador, que se le pueda, por ejemplo, sumar o restar vida.

Por favor tener en cuenta *Clean Code*, *DRY* y *KISS* en cada iteración.

#### Restricciones
* Escribe el mejor código que puedas, pero que sea simple.
* No hagas más de lo que pide cada iteración.

## Primera iteración:
Se puede sumar y restar vida a la barra del jugador. El mínimo es 0 y el máximo es 100. Empieza en 100.
Si el jugador pierde vida (lo atacan) cuando está en 0, el número no tiene que ir a negativo, y si el jugador gana vida (toma una poción) cuando está en 100, el número no tiene que superarlo.

## Segunda iteración:
El jugador puede tomar una poción mágica la cual le da 50 de vida, aún si está en el máximo se le suma. (quedaría en 150). 
Si el jugador hace heal, no sigue creciendo, no importa si está entre 101 y 150, sólo le sumaría cuando esté de vuelta en algo menor a 100.

## Tercera iteración:
El jugador puede agarrar el poder “Shield”. Este poder hace que por un ataque el jugador no pueda ser herido (restar vida).

## Cuarta iteración:
El jugador puede estar envenenado y esto hace que cada ataque sea x2.


## Bibliografía complementaria
- [TDD in Unity using MVP](https://engineering.etermax.com/how-to-tdd-in-unity-using-the-mvp-pattern-a646ffbe996f) 
- [Pair Programming](https://martinfowler.com/articles/on-pair-programming.html)
- [TDD](https://www.paradigmadigital.com/techbiz/tdd-una-metodologia-gobernarlos-todos/)
- [TDD](https://www.guru99.com/test-driven-development.html)
- [Clean Code](https://www.amazon.com/-/es/Robert-C-Martin/dp/0132350882)
