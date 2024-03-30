//FETCH API: Sirve para extraer los datos desde un origen de datos(base de datos)
/*
function obtenerEmpleados() {    

    fetch('http://www.google.com/api') // podría ir una 'url' de una API de Google
    fetch('empleados.json') //pasándole un origen de datos

    const archivo = 'empleados.json'

    fetch(archivo) //haciéndole 'fetch' a la variable archivo que contiene el .json de empleados
        .then(resultado => {
            return resultado.json();//retorna la información como un .json y se lo envía al siguiente '.then'
            return resultado.text();//retorna la información igual al texto empleado en 'empleados.json'
        })
        .then(datos =>{ //aquí accedemos a los datos ('datos' es una variable recién inventada)
            console.log(datos);
        })

        //--------------------------------------------------------------------------------------------------------------
        //Otra forma más corta
        .then(resultado => resultado.json())

        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        .then(datos => console.log(datos)) //de esta manera, sólo nos muestra los elementos del arreglo
        .then(datos => console.log(datos.empleados)) //de esta manera, nos permite acceder a los elementos del arreglo

        //--------------------------------------------------------------------------------------------------------------
        //Una 2da manera de acceder a los elementos es usando 'Destructuring'
        .then(resultado => resultado.json())

        .then(datos =>{

        const {empleados} = datos;
        
        console.log(empleados);
        })
        
        //--------------------------------------------------------------------------------------------------------------
        //3ra forma de acceder a los elementos del arreglo, pero de manera individual,
        //es iterando sobre el arreglo existente
        .then(resultado => resultado.json())

        .then(datos =>{

            const {empleados} = datos;

            empleados.forEach(empleado => {//variable inventada recién
                console.log(empleado);

                
                //Accediendo a los datos, pero de manera aún más detallada 
                console.log(empleado.id);
                console.log(empleado.nombre);
                console.log(empleado.puesto);      
                
                //Mostrando los datos en el body de la página
                document.querySelector('.contenido').textContent += " " + empleado.nombre; 
                                                                más-igual es para que no resscriba los datos
                
            })        

        })

}

obtenerEmpleados();*/

//----------------------------------------------------------------------------------------------------------------------------------
//Creando la misma función, pero asíncrona
async function obtenerEmpleados() {

    const archivo = 'empleados.json';   

    const resultado = await fetch(archivo);
    const datos = await resultado.json(); //declarando el tipo de datos que se va a mostrar (.json o .text)
    //se pone un 2do 'await' porque la variable 'datos' sí depende del resultado de la variable 'resultado'

    console.log(datos); //mosntrando los datos
}

obtenerEmpleados();

