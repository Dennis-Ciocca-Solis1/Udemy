//NOTIFICATION API

//Creando una notificación

//seleccionando un botón y almacenándolo en una variable
/*const boton = document.querySelector('#boton');

boton.addEventListener('click', () => {
    Notification.requestPermission()
        .then(resultado => console.log(`El resultado es ${resultado}`) )
})

if(Notification.permission == 'granted') {
    new Notification('Esta es una notificación', {
        icon: 'img/ccj.png',
        body: 'Código con Juan, los mejores tutoriales'
    })
}*/

//Seleccionando un botón y almacenándolo en una variable
/*const boton = document.querySelector('#boton');*/

//Evento click
boton.addEventListener('click',function(){
    Notification.requestPermission()
        //.then(resultado => console.log('El resultado es: ', resultado) )
        .then(resultado => console.log(`El resultado es ${resultado}`) )
});

//Creando notificación
if (Notification.permission == 'granted') {//si el permiso es igual a 'granted' se enviará notificación
    new Notification('IMPORTANTE!!!',{ //título de la notificación
        icon: 'img/javascript.png', //imagen de la notificación
        body: 'Aprende JavaScript' //mensaje de la notificación
    })    
}