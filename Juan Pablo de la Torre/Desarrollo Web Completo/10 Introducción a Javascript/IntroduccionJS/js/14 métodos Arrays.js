// ARREGLOS O ARRAYS

const numeros = [10,20,30,40,50];

// Acceder a los valores de un arreglo
// console.log(numeros[0]);
// console.log(numeros[1]);
// console.log(numeros[2]);
// console.log(numeros[3]);
// console.log(numeros[4]);

//Recorriendo el arreglo
numeros.forEach( function(numero) { //'numero' es un parámetro inventado
    console.log(numero);
})

// \** Métodos de los Arreglos -----------------------------------------

// Conocer la longitud de un arreglo
// console.log(meses.length);

// Agregar elementos a un Arreglo
numeros.push(60,70,80); // agrega un elemento/s al final del arreglo
numeros.unshift(-10,-20,-30); // agrega un elemento/s al inicio del arreglo

console.table(numeros); //te muestra el arreglo en formato de tabla

//---------------------------------------------------------------------
//creando una arreglo con el constructor
//const meses = new Array('Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo');

//otra forma
const meses = ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo'];

console.table(meses);

//Accediendo a los valores de un arreglo
console.log(meses[4]);

//---------------------------------------------------------------------

// Eliminando elementos de un Arreglo
// meses.pop(); // elimina el último elemento/s del arreglo
// meses.shift(); // elimina el primer elemento/s del arreglo

// meses.splice(2, 1); //elimina una cantidad de elementos a partir del índice seleccionado
//       splice(índice,cantidad a eliminar) 

// console.table(meses);

//---------------------------------------------------------------------
// Rest Operator o Spread Operator (esta propiedad agrega un nuevo elemento al inicio o final de un arreglo sin modificar el arreglo original)

//const nuevoArreglo = [ ...meses,'Junio',]; //agrega un nuevo elemento al final del arreglo
const nuevoArreglo = ['Junio', ...meses]; //agrega un nuevo elemento al inicio del arreglo

console.log(nuevoArreglo);
