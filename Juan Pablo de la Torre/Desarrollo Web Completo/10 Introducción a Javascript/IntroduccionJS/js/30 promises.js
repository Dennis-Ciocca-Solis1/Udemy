//PROMISES

const usuarioAutenticado = new Promise( (resolve, reject) => {
    const auth = true;

    if(auth) {
        resolve('Usuario Autenticado'); // 'resolve' si el 'Promise' se cumple
    } else {
        reject('No se pudo iniciar sesión'); // 'reject' si el 'Promise' no se cumple
    }
});

usuarioAutenticado //variable que fue creada arriba 
    /*
    .then(function(resultado){
        console.log(resultado)
    })*/

    //Otra forma:
    .then( resultado => console.log(resultado))

    .catch( error => console.log(error))
    
    /*Otra forma:
    .catch(function(error){
        console.log(error)
    })*/

//# En los Promises existen 3 estados(valores)
// Fulfilled : Ya se cumplió
// Pending : No se ha cumplido, pero tampoco se ha rechazado
// Rejected : Se ha rechazado o no se pudo cumplir