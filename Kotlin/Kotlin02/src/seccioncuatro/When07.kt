package seccioncuatro

fun main(args:Array<String>){

    val x=20

    when(x){
        1 -> println("El valor es 1")
        2 -> println("El valor es 1")
        3 -> println("El valor es 3")
        //verificar variable en un rango
        in 5..15 -> println("El valor está entre 5 y 15")
        //verificar que variable no esté en un rango
        !in 5..15 -> println("El valor no está entre 5 y 15")
        else -> println("El valor está fuera de rango.")
    }

    /*val promedio = 13

    when(promedio){
        20-> println("Su calificación es excelente.")
        19-> println("Su calificación es prometedora.")
        in 13..18 -> println("Su calificación es regular")
        //13,14,15,16,18-> println() ==> Permite excluir un número del rango
        else -> println("Su calificación es desaprobatoria")
    }*/

    //CONVERTIR "WHEN" EN UNA EXPRESIÓN
    val promedio = 13
    val resultado = when(promedio){
        20-> "Su calificación es excelente."
        19-> "Su calificación es prometedor."
        in 13..18 -> "Su calificación es regular"
        //13,14,15,16,18-> "Su calificación..." ==> Permite excluir un número del rango
        else -> "Su calificación es desaprobatoria"
    }
    println(resultado)
}