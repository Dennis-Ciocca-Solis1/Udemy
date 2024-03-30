//144 ** SELECCIONANDO ELEMENTOS: querySelector, querySelectorAll, getElementById **

//console.log('funciona correctamente') //con esto verificamos si logramos conectar correctamente el js con el html

// QUERY SELECTOR: selecciona y retorna 0 o 1 elemento.
/*
const heading = document.querySelector('.header__texto h2') //nombre_clase""etiqueta
console.log(heading);

//Otra forma:
/*const heading = document.querySelector('#heading') // con sólo el 'id'
console.log(heading);

//Cambiando propiedades a un objeto (cambiando el texto de 'Blog de café con consejos y cursos' a 'Nuevo Heading')
heading.textContent = "Nuevo Heading";

//Agregando una nueva clase a una etiqueta
heading.classList.add('nueva-clase');

console.log(heading); //mostrando todos los cambios*/

//***************************************************************************************************************************
//145 QUERY SELECTOR ALL: Selecciona y retorna de 0 a 'todos los elementos espeficicados que existan'.
/*
//Seleccionando todos los enlaces de la clase 'navegacion'
//const enlaces = document.querySelectorAll('.navegacion a') //nombre_clase""etiquetas 'a' 
console.log(enlaces);*/

//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//Seleccionando un elemento en específico de todos los existentes
/*const enlaces = document.querySelectorAll('.navegacion a') //nombre_clase""etiquetas 'a' 
//console.log(enlaces[0]); //mostrando sólo 1 en específico

//---------------------------------------------------------------------------
//Cambiando el contenido del texto de un elemento en una posición en concreto
enlaces[0].textContent = 'Nuevo Texto para Enlace de la posición 0';

//Otra forma poco usada:
//const enlaces = document.querySelectorAll('.navegacion a')[0].textContent = 'Nuevo Texto para Enlace de la posición 0';
//------------------------------------------------------------------------------------------------------------------------

//Modificando una dirección de un enlace
//enlaces[0].href = 'http://google.com'; //pasó de Nosotros.html a google.com

//Agregando una nueva clase a un elemento en particular
enlaces[0].classList.add('clase-nueva');

//Eliminando una clase a un elemento en particular
enlaces[0].classList.remove('navegacion__enlace'); //sólo se usa el '.' cuando seleccionas una clase. Ejm: ('.navegacion a')*/

//***************************************************************************************************************************
//GET ELEMENT BY ID
/*const heading2 = document.getElementById('heading');
console.log(heading2);*/

//****************************************************************************************************************************
//146 GENERAR HTML DESDE JAVASCRIPT...
/*
//Generando un nuevo enlace <a></a> //por defecto, el enlace se crea vacío y sin atributos 
const nuevoEnlace = document.createElement('A');

//console.log(nuevoEnlace);

//Agregándole un 'href' al enlace
nuevoEnlace.href = 'nuevo-enlace.html';

//console.log(nuevoEnlace);

//Agregándole un 'texto' al enlace
nuevoEnlace.textContent = 'Tienda Virtual';

//console.log(nuevoEnlace);

//Agregándole una 'clase' al enlace
nuevoEnlace.classList.add('navegacion__enlace');

console.log(nuevoEnlace);

//<a href="nuevo-enlace.html" class="navegacion__enlace">Un Nuevo Enlace</a> //así quedó

//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//Agregando el nuevo enlace creado a un lugar del documento HTML
const navegacion = document.querySelector('.navegacion'); //este seleccionará el primer elemento de la clase 'navegacion'

navegacion.appendChild(nuevoEnlace); 
//appendChild nos permite insertar un nuevo elemento en el último lugar de la clase seleccionada en el paso anterior*/

//*************************************************************************************************************************
//147 EVENTOS EN JAVASCRIPT

//Evento 'LOAD'

console.log('1');

// window.addEventListener('load', function() { // Esta función se ejecuta al final, luego de que todos los demás elementos se hayan cargado
//     console.log('2');
// });

//otra forma de hacer este mismo evento addEventListener:
window.addEventListener('load', imprimir); //crear la función imprimir abajo

//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

//Otra forma de realizar un evento Load:
window.onload = function() {
    console.log('3')
};

//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
document.addEventListener('DOMContentLoaded', function() {  // Este se ejecuta cuando el HTML ha sido descargado pero no espera por CSS o imágenes...
                                                            // y se ejecuta antes que los eventos addEventListener y onload
    console.log('4');
});

console.log('5');

function imprimir(){
    console.log(2);
}

// Evento 'Scroll'
window.onscroll = function(e) { //cuenta la cantidad de líneas que hemos hecho 'scroll'
    console.log('scrolling...');    
}
