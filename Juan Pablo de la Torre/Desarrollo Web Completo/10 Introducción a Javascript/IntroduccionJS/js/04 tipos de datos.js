//STRING O CADENA DE TEXTO

//const producto = "Monitor 21 Pulgadas";
//const producto = "Monitor de 21\"" //Mostrando comillas dobles en un string

//const producto2 = String("Monitor 32 Pulgadas"); //Aclarando tipo de dato

//const producto3 = new String('Monitor 50 Pulgadas');//Lo convierte en objeto

//console.log(producto);
//console.log(producto2);
//console.log(producto3);

//Mostrando el tipo de dato
//console.log(typeof producto);
//console.log(typeof producto2);
//console.log(typeof producto3); //'new String' lo convierte en objeto, ya no es string


const tweet = 'Aprendiendo JavaScript con el curso de Desarrollo Web Completo';

const producto2 = 'Monitor HD"';
const nombre = 'Juan Pablo';
const email = 'correo@correo.com';

// 'length' es para la longitud. En JS 'length' no es un método sino una propiedad'
console.log(tweet.length);
console.log(producto2);

// 'IndexOf' (retorna la posición donde empieza la palabra que se está buscando)
console.log(tweet.indexOf('JavaScript'));//retorna la posición 12
console.log(producto2.indexOf('Tablet'));//cuando no existe lo que se está buscando retorna '-1'
console.log(email.indexOf('@'));

// 'Includes' (retorna true o false si encuentra la palabra)
console.log(tweet.includes('JavaScript'));
console.log(producto2.includes('Tablet'));
