// ASYNC / AWAIT

//SET TIMEOUT: hace que una acción se ejecute después de un tiempo determinado sólo una vez
/*setTimeout( () => {
    console.log('set timeout...')
}, 2000);*/

//SET INTERVAL: repite una acción (una y otra vez) después en una intervalo de tiempo
/*setInterval( () => {
    console.log('set timeout...')
}, 2000);*/

function descargarNuevosClientes() {
    return new Promise( resolve => {
        console.log('Descargando clientes... espere...');

        setTimeout(() => {
            resolve('Los clientes fueron descargados')
        }, 5000);
    });
}

async function app() {
    try {
        const resultado = await descargarNuevosClientes();
        console.log(resultado);
    } catch (error) {
        console.log(error);
    }    
}

app();

console.log('Este código no se bloquea')