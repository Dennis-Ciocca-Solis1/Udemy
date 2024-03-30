// OBJETOS

const producto = {
    nombreProducto : "Monitor 20 Pulgadas",
    precio: 300,
    disponible: true
}

// console.log(producto.nombreProducto);
// console.log(producto.precio);
// console.log(producto.disponible);
// +++++++++++++++++++++++++++++++++
// console.log(producto["precio"]); //otra forma

// Agregar nuevas propiedades
producto.imagen = 'imagen.jpg';  //puedes agregar una propiedad a un objeto existente

// Eliminar una propiedad del objeto
delete producto.disponible;
console.log(producto);