package seccioncuatro

fun main(args:Array<String>){

    print("Ingrese Nota1: ")
    var nota1:Int= readLine()!!.toInt()

    print("Ingrese Nota2: ")
    var nota2:Int= readLine()!!.toInt()

    print("Ingrese Nota3: ")
    var nota3:Int= readLine()!!.toInt()

    var promedio = (nota1 + nota2 + nota3) / 3

    if (promedio == 20)
        println("Su calificación es excelente. Su promedio es de: $promedio")
    else if (promedio == 19)
        println("Su calificación es bastante aceptable. Su promedio es de: $promedio")
    else if (promedio >=13 && promedio <=18)
    println("Su calificación es regular. Su promedio es de: $promedio")
    else
    println("Su calificación es insuficiente. Su promedio es de: $promedio")

    /*if (promedio < 13)
        println("Su calificación es reprobatoria. Su promedio es de: $promedio")
    else if (promedio <=16)
        println("Su calificación es regular. Su promedio es de: $promedio")
    else if( promedio <=19)
        println("Su calificación es bastante aceptable. Su promedio es de: $promedio")
    else
        println("Su calificación es excelente. Su promedio es de: $promedio")
*/

}