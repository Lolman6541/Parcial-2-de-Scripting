# Parcial-2-de-Scripting

Consideraciones y Particularidades del Diseño Orientado a Objetos:

- Se utiliza la abstracción y la herencia para modelar diferentes partes de la moto (FrontWheel, BackWheel, Chassis, Engine, Muffler) como subclases de la clase abstracta Part. Para definir comportamientos comunes y especializados para cada tipo de parte.
- Se aplicó encapsulación para ocultar los detalles internos de las clases y proporcionar una interfaz controlada y segura para interactuar con las partes de la moto.
- Se hace uso del polimorfismo al definir el método ModifyParameters en la clase abstracta Part y luego implementarlo de manera específica en cada subclase. Esto permite que cada parte modifique los parámetros de la moto de acuerdo con su función específica.

Consideraciones y particularidades del Proyecto:

- El proyecto se enfoca en implementar un juego de carreras de motos que se centra en la personalización de componentes para mejorar los parámetros del vehículo. Los requisitos funcionales incluyen la personalización de partes (llantas, chasis, motor, etc.) y la lógica asociada a cómo afectan a los parámetros de la moto.
- Se realiza la implementación de pruebas unitarias utilizando NUnit para validar que cada parte de la moto y sus funcionalidades. Se prueban escenarios como la creación de la moto, la adición de partes, y la modificación de parámetros.


Integrantes :
Juan Pablo Arango Zuleta y Abraham Peláez Trujillo 
