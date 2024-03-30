//OBJECTS METHODS

//"use strict"; // Corre JS en modo estricto (como si fuera un lenguaje de programación convencional)

const producto = {
    nombreProducto : "Monitor 20 Pulgadas",
    precio: 300,
    disponible: true
}

//----------------------------------------------------------------------------------------------------
// Congelar o sellar el objeto para que no se le pueda agregar, modificar, ni eliminar propiedades o elementos
//Object.freeze(producto); // .freeze 

//otra forma
Object.seal(producto); // .seal si permite al menos modificar los elementos de las propiedades existentes

//Cómo saber si un objeto está congelado o sellado 
console.log(Object.isFrozen(producto));
console.log(Object.isSealed(producto));

producto.precio = 'NUEVO PRECIO'; 

delete producto.precio;

console.log(producto);