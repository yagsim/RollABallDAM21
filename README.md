# odoo
Repositorio de Roll a ball ,juego donde una pelota situada en un laberinto debera conseguir el máximo numero de monedas superando obstáculos.
Los obstáculos se crearon mediante la interfaz de unity y con la ayuda del proBuilder en la creación de cilindros,escaleras,puertas... y de asset store para algunos filtros y imagenes.
(/imagenes/Laberinto.png)
Para ello hago uso de varios scripts:
- Paso 1.Player controller:
Donde se le da movimiento a una pelota y velocidad para ello usaremos Vectores de movimiento en X y en Y,no usaremos z porque solo queremos movernos hacia adelante y atrás y hacia los lados.
También disponemos de otro método donde al colisionar con el PickUp(moneda) este desaparecera.

- Paso 2.Camera Controller:
  Este script lo que hace el seguir el movimiento de la pelota con una camara para mostrar su camino.Para ello debemos desactivar el vector 3 sino también girara en z y se movera según el movimiento de la pelota.

- Paso 3.Rotator:
  Simplemente hacemos girar a la moneda recogiendo el tiempo del ordenador y dando una velocidad según este.
(/imagenes/Coin.png)
- Paso 4.RampController:
\n Al entrar en contacto con las ramplas del tag:"plane"  le dara a la bola una velocidad extra hasta que entre en contacto con el suelo .
Aquí recogemos el rigidbody(bola) y le multiplicamos una velocidad al estar en contacto con la bola si el tag cambia a suelo vuelve su velocidad inicial.

- Paso 5.Realentizador:
  Método parecido al Ramp pero esta vez en plano y restando velocidad.
(/imagenes/Realentizador.png)

- Paso 6.Agujero:
  Se trata de un cilindro que al entrar en contacto con el cambia de posición la bola hacia otra mesa.Esta mesa se encuentra debajo de la principal y es la misma pero se podría modificar para ir subiendo niveles.
Este método espera 1segundo y pondra la bola en la posición de inicio.
(/imagenes/Agujero.png)

#Paso 7.Score:(Método no acabado).
  Muestra en el Text de arriba las monedas recolectadas.





