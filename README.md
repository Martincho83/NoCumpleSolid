# Código que NO cumple con OCP, ISP y DIP:
## El siguiente código de ejemplo tiene varias violaciones de los principios SOLID:

* OCP (Open/Closed Principle): La clase TransporteService debe ser modificada cada vez que se agrega un nuevo tipo de transporte.
* ISP (Interface Segregation Principle): La interfaz ITransporte tiene métodos que no son necesarios para todas las clases que la implementan.
* DIP (Dependency Inversion Principle): TransporteService depende directamente de clases concretas y no de abstracciones.
