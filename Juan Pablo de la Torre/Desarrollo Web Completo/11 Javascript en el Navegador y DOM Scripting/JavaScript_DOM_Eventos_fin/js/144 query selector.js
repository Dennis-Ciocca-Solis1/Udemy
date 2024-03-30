// Seleccionar elementos...

//console.log('funciona correctamente') //con esto verificamos si logramos conectar correctamente el js con el html

// querySelector: selecciona y retorna 0 o 1 elemento

const heading = document.querySelector('.header__texto h2') //nombre_clase""etiqueta
console.log(heading);

//Otra forma:
/*const heading = document.querySelector('#heading') // con sólo el 'id'
console.log(heading);*/

//Cambiando propiedades a un objeto (cambiando el texto de 'Blog de café con consejos y cursos' a 'Nuevo Heading')
heading.textContent = "Nuevo Heading";

//Agregando una nueva clase a una etiqueta
heading.classList.add('nueva-clase');

console.log(heading); //mostrando todos los cambios