
// MÉTODOS DE PROPIEDAD

const reproductor = {
    reproducir : function(id) {
        console.log(`Reproduciendo Canción con el ID: ${id}`)
    },
    pausar: function() {
        console.log('Pausando...')
    },
    crearPlaylist: function(nombre) {
        console.log(`Creando la playlist: ${nombre}`)
    },
    reproducirPlaylist: function(nombre) {
        console.log(`Reproduciendo la playlist: ${nombre}`)
    },
}

//Creando propiedad por fuera de un objeto
reproductor.borrarCancion = function(id) {
    console.log(`Eliminando la canción: ${id}`)
}

//Aplicando los métodos pasándoles un argumento(valor)
reproductor.reproducir(3840);
reproductor.pausar();
reproductor.borrarCancion(20);
reproductor.crearPlaylist('Heavy Metal');
reproductor.reproducirPlaylist('Heavy Metal');