//FUNCIONES

//Hoisting: quiere decir que Javascript se ejecuta en 2 vueltas
//en la 1ra vuelta registra a la función
//en la 2da vuelta ejecuta la función

// Declaración de Función
sumar();

function sumar() {
    console.log(10 + 10);
}

//-----------------------------------------------------------------------------------------------------
// Expresión de la función
const sumar2 = function() { // esta forma solo permite llamar a la función después de crearla(no antes)
    console.log( 3 + 3);
}

sumar2(); 

//------------------------------------------------------------------------------------------------------
//IIFE son funciones que se llaman a sí mismas (no necesitan tener nombre de función)
(function() { 
    console.log('Esto es una función');
})();


