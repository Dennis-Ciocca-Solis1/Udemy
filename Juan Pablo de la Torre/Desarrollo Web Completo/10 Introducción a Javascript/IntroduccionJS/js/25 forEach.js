//ESTRUCTURA DE CONTROL FOREACH

const carrito = [
    { nombre: 'Monitor 20 Pulgadas', precio: 500 },
    { nombre: 'Televisión 50 Pulgadas', precio: 700 },
    { nombre: 'Tablet', precio: 300 },
    { nombre: 'Audifonos', precio: 200 },
    { nombre: 'Teclado', precio: 50 },
    { nombre: 'Celular', precio: 500},
    { nombre: 'Bocinas', precio: 300},
    { nombre: 'Laptop', precio: 800}
];

console.log(carrito);
// ForEach
/*
carrito.forEach(function(producto){ //el parámetro 'producto' almacena cada objeto leído del arreglo
    console.log(producto) // y aquí lo imprime cada vez
});
*/

//recorre el arreglo mostrando sólo el argumento especificado (sólo lo muestra en el html)
carrito.forEach( producto => console.log(producto.nombre)); //argumento (producto.nombre)

//---------------------------------------------------------------------------------------------------
// 'map' crea un nuevo arreglo extrayendo(filtrando) sólo los valores especificados 

const arreglo1 = carrito.map( producto => producto.nombre);

//también puede crear un arreglo dándole un nuevo formato a los datos extraídos
const arreglo2 = carrito.map( producto => `${producto.precio} - ${producto.nombre}`);

console.log(arreglo1);

console.log(arreglo2);


