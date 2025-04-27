# Ejercicios de Programación Orientada a Objetos en C# 12 y .Net Framework 4.8.1
En este repositorio se encuentran ejercicios para resolverlos con el paradigma de programación orientada
a objetos y las soluciones a los mismos.

## ¿Como aprendo programación orientada a objetos en C# 12?
Revisa mi repositorio de [programación orientada a objetos](https://github.com/miguel835/POOcsharp) en este 
tengo archivos de los temas de programación orientada a objetos 

## Tabla de contenido por tema

### 1. Clases y objetos

### [Hola mundo](https://github.com/miguel835/EjerciciosPOO/tree/master/HolaMundo)
Crear una aplicación de consola en C# que imprima "Hola Mundo" utilizando el concepto de Programación 
Orientada a Objetos (POO). Define una clase llamada Saludo.
Dentro de la clase Saludo, crea un método llamado MostrarMensaje que no reciba parámetros y que
imprima en consola el mensaje "Hola Mundo".
En el método Main de tu aplicación, crea una instancia de la clase Saludo y
llama al método MostrarMensaje para ejecutar la impresión del mensaje en consola.

### [Entrada de datos](https://github.com/miguel835/EjerciciosPOO/tree/master/EntradaDatos)
Crea una aplicación de consola en C# que capture datos ingresados por el usuario,
convierte estos datos a diferentes tipos y demuestre el uso de control de excepciones
para evitar errores por entradas incorrectas. Crea una clase llamada EntradaDatos.
El programa debe capturar datos de edad y altura desde la consola, realizando las conversiones
necesarias para trabajar con tipos int y float. Además utiliza un control de excepciones para 
manejar las entradas de datos no validas, adicionalmente deberas mostrar la edad y altura del usuario.

### 2. Principios fundamentales de POO (abstracción, encapsulamiento, herencia y polimorfismo), modificadores de acceso, constructores y destructores, herencia

### [Geometria punto circulo rectangulo](https://github.com/miguel835/EjerciciosPOO/tree/master/GeometriaPuntoCirculoRectangulo)
Son tres ejercicios en uno 

Crear una clase Punto que representa un punto en el plano cartesiano la clase debe tener atributos para
las coordenadas x e y implementar un constructor que inicialice las coordenadas implementar metodos 
para obtener las coordenadas (getX(), getY()), calcular la distancia al origen 
(distanciaAlOrigen()), calcular la distancia a otro punto (distanciaA(Punto otroPunto)) y representar el punto
como una cadena de texto (toString()).

Crear una clase Circulo que represente un circulo la clase debe tener atributos para el radio 
y la posición (utilizando un objeto Punto del ejercicio anterior) implementar un constructor que 
inicialice el radio y la posición implementar métodos para obtener el radio (getRadio() ), 
calcular el area (calcularArea() ), calcular el perimetro (calcularPerimetro() ) y representar
el circulo como una cadena de texto (toString()).

Crear una clase Rectangulo que represente un rectangulo la clase debe tener atributos para 
la base, la altura y la posición (utilizando un Punto del ejercicio anterior) implementar un constructor 

### [Clase cuenta bancaria](https://github.com/miguel835/EjerciciosPOO/tree/master/ClaseCuentaBancaria)
Crear una clase CuentaBancaria que represente una cuenta bancaria
- La clase debe tener atributos para el numero de cuenta, el titular, el saldo y el tipo de cuenta (ahorro, corriente)
- Implementar un constructor que inicialice los atributos
- Implementar metodos para depositar dinero (depositar(double monto)), retirar dinero (retirar(double monto)), 
consultar saldo (consultarSaldo()) y obtener el tipo de cuenta (getTipoCuenta()). 

### [Clase empleado](https://github.com/miguel835/EjerciciosPOO/tree/master/ClaseEmpleado)
Crear un clase empleado que represente a un empleado
- La clase debe tener atributos para el nombre,  el numero de empleado, el salario y el departamento
- Implementar un constructor que inicialice los atributos
- Implementar métodos para obtener el nombre (getNombre()), obtiene el numero de empleado (getNumeroEmpleado() ),
obtener el salario (getSalario() ), obtener el departamento (getDepartamento() ), aumentar el salario 
(aumentarSalario(double porcentaje)), y representar el empleado como una cadena de texto (toString()

### [Clase cliente](https://github.com/miguel835/EjerciciosPOO/tree/master/ClaseCliente)
Son tres ejercicios en uno.

Crear una clase Cliente que representa a un cliente de una tienda.
- La clase debe tener atributos para el nombre, la dirección, el telefono y el numero de cliente.
- Implementar un constructor que inicialice los atributos
- Implementar metodos para obtener el nombre (getNombre() ), obtener la dirección(getDireccion() ), obtener el telefono
(getTelefono() ), obtener el numero de cliente (getNumeroCliente() ), y representar el cliente como una cadena
de texto (toString() 

Crear una clase Pedido que represente un pedido de un cliente
- La clase debe tener atributos para el cliente (utilizando un objeto cliente del ejercicio anterior), la fecha del pedido,
la lista de productos (utilizando un array o lista) y el total del pedido
- Implementar un constructor que inicialice los atributos
- Implementar metodos para agregar un producto al pedido (agregarProducto(Producto producto)), calcular el total del 
pedido (calcularTotal() ), y representar el pedido como una cadena de texto (toString()

Crear una clase Producto que represente un producto en venta
- La clase debe tener atributos para el nombre, el precio, la cantidad en stock y la descripción
- Implementar un constructor que inicialice los atributos
- Implementar metodos para obtener el nombre (getNombre() ), obtener el precio (getPrecio() ), obtener la cantidad en 
stock (getCantidadStock() ), obtener la descripción (getDescripción() ), vender un producto (vender(int unidades)) y 
representar el producto como una cadena de texto (toString() 

### [Ejercicio UNEMI](https://github.com/miguel835/EjerciciosPOO/tree/master/EjercicioUNEMI)
Diseñe clases como estudiante, docente, persona para que permita guarda datos de estudiantes y docentes
simule como si fuera una base de datos de la UNEMI, usar herencia y crear métodos. 

### [Generador de contraseñas básico](https://github.com/miguel835/EjerciciosPOO/tree/master/GeneradorDeContrase%C3%B1asB%C3%A1sico)
Diseñe una clase Password que permita la generación de una contraseña, y que el usuario pueda ingresar
la cantidad de caracteres que desea para su contraseña a generar.

### 3. Programación genérica (generics)

### 4. Interfaces y clases abstractas, relaciones entre clases (composición y agregación, asociación, dependencia)

### [Clase moto](https://github.com/miguel835/EjerciciosPOO/tree/master/ClaseMoto)
Una empresa de construcción de motocicletas requiere el desarrollo de un software que controle 
el software de este vehículo. El software debe implementar una clase motocicleta que tenga al menos 
tres propiedades y dos métodos que usted considere importantes. Además, esta clase debe estar compuesta de
al menos dos clases más de algunas de sus partes (pueden ser: motor, tanque, neumáticos, carburador, etc.),
estas dos clases de composición deben tener también dos propiedades cada una.
