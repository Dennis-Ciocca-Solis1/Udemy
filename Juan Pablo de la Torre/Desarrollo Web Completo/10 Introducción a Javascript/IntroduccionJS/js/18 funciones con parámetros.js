//FUNCIONES CON PARÁMETROS

function sumar(numero1 = 0, numero2 = 0) { //asignandole un valor por default en caso no se introduzca alguno de los argumentos
             //numero1 y numero2 son parametros
    console.log(numero2 + numero1);
}
sumar(10, 5); // Argumentos o los valores reales
sumar(3, 3);
sumar(3, 6);
sumar(1);//aquí solo se ingresó un solo argumento

//Otra forma
const sumar2 = function(n1, n2) {
    console.log(n1 + n2);
}
sumar2(5, 10);