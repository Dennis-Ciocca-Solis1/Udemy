// ARROW FUNCTIONS

const sumar2 = (n1, n2) => console.log( n1 + n2); //cuando es sólo una línea no se neceita poner las llaves {}
sumar2(5, 10);

const aprendiendo = tecnologia => console.log(`Aprendiendo ${tecnologia}`)
//cuando sólo hay un parámetro (tecnología), se puede omitir los parentesís

aprendiendo('JavaScript');


// Array Methods con Arrow Functions

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

// forEach
meses.forEach( mes => {
    if(mes == 'Marzo') {
        console.log('Marzo si existe');
    }
});

/*forEach sin Arrow Function */
/* meses.forEach(function(mes) { //'mes' es un parámetro inventado
    if(mes == 'Marzo') {
        console.log('Marzo si existe'); 
    }
}); */

//----------------------------------------------------------------------------
// 'Some': ideal para arreglo de objetos (con Arrow Function)
let resultado;

resultado = carrito.some( producto => producto.nombre === 'Celular');

console.log(resultado);

/* 'Some' Sin Arrow Function*/
/* resultado = carrito.some(function(producto) {
    return producto.nombre === 'Celular'
})

console.log(resultado);*/

//----------------------------------------------------------------------------
// Reduce

//let resultado;

resultado = carrito.reduce( (total, producto) =>  total + producto.precio, 0);

console.log(resultado);

/*'Reduce' sin Arrow Functions */
/*resultado = carrito.reduce(function(total, producto) {
    return total + producto.precio
}, 0);

console.log(resultado);*/

//----------------------------------------------------------------------------
// Filter

//let resultado;

//Filtrar sólo los valores que cumplan con una condición
resultado = carrito.filter( producto => producto.precio > 400);

console.log(resultado);

/*'Filter' sin Arrow Function */
/*resultado = carrito.filter(function(producto) {
    return producto.precio > 400
}); 

console.log(resultado);*/

//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//Traer todos los elementos, menos a uno

//let resultado;

resultado = carrito.filter( producto => producto.nombre !== 'Tablet');
console.log(resultado);

/*'Filter' sin Arrow Function */
/*resultado = carrito.filter(function(producto) { 
    return producto.nombre !== 'Celular'
});

console.log(resultado);*/
