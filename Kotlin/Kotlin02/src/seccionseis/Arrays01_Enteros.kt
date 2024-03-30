package seccionseis

fun main(args: Array<String>) {//ARRAY DE TIPO "ENTEROS"

    val arrayUno= Array<Int>(5){0}
    //se puede omitir la palabra "Int"

    arrayUno[1]= 5
    arrayUno[2]= -15
    arrayUno[3]= 50
    arrayUno[4]= 100

    println("Array en la posición 3 es: " + arrayUno[3])
    println()

    //ACCEDER A TODOS LOS ELEMENTOS POR OBJETO
    for (elemento in arrayUno) {
        println(elemento)
    }
    println("Se terminó la búsqueda de valores por objeto)")
    println()

    //ACCEDER A LOS ELEMENTOS, PERO POR ÍNDICE
    for(indice in 0..4){
        println(arrayUno[indice])
    }
    println("Se terminó la búsqueda de valores por índice")
    println()
}