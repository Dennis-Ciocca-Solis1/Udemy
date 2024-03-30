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

//Seleccionando todos los enlaces de la clase 'navegacion'
/*const enlaces = document.querySelectorAll('.navegacion a') //nombre_clase""etiquetas 'a' 
console.log(enlaces);*/

//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//Seleccionando un elemento en específico de todos los existentes
const enlaces = document.querySelectorAll('.navegacion a') //nombre_clase""etiquetas 'a' 
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
enlaces[0].classList.remove('navegacion__enlace'); //sólo se usa el '.' cuando seleccionas una clase. Ejm: ('.navegacion a')

//***************************************************************************************************************************
//GET ELEMENT BY ID

const heading2 = document.getElementById('heading');
console.log(heading2);