// MÁS ARRAYS METHODS

const meses = ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo'];

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
//-------------------------------------------------------------------------------------
// Verificando si un elemento existe con un forEach
meses.forEach(function(mes) { //'mes' es un parámetro inventado
    if(mes == 'Marzo') {
        console.log('Marzo si existe'); 
    }
});

// Includes (también verifica si un elemento existe)
let resultado = meses.includes('Diciembre');
console.log('El Resultado de \'includes\' es: ' + resultado);

//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
// 'Some' es ideal para verificar la existencia de un elemento en un arreglo de objetos

//let resultado;

/*resultado = carrito.some(function(producto) {
    return producto.nombre === 'Celular PRO'
})*/

//Otra forma: Arrow function
resultado = carrito.some(producto => producto.nombre === 'Celular PRO');

console.log('El Resultado de \'some\' es: ' + resultado);

//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
// 'Reduce' reduce el array insertado a un solo valor. Esta reducción se da a partir de una función que insertamos como parámetro.

//let resultado;

/*resultado = carrito.reduce(function(total, producto) { //'producto' es un parámetro inventado que traerá el precio de cada elemento de 'carrito' 
    return total + producto.precio //'total' es un parámetro inventado que almacenará la suma total de producto.precio
}, 0); //el '0' indica el valor inicial desde el cual 'total' empezará a sumar*/

//Otra forma: Arrow function
resultado = carrito.reduce((total,producto) => total + producto.precio,0);

console.log('El Resultado de \'reduce\' es: ' + resultado);

//------------------------------------------------------------------------------------

// Filter: sirve para obtener sólo los valores que cumplan con una condición

//let resultado;

resultado = carrito.filter(function(producto) {//parámetro inventado que representará a los precios del arreglo 'carrito'
    return producto.precio > 400
});

console.log(resultado);

//++++++++++++++++++++++++++++++++++++++++++++++

//let resultado;

//Traer todos los elementos menos a uno
resultado = carrito.filter(function(producto) { 
    return producto.nombre !== 'Celular'
});

console.log(resultado);
