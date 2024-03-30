package seccioncuatro

fun main(args:Array<String>){

    println("Ingrese sueldo: ")
    var sueldo:Double= readLine()!!.toDouble()

    if(sueldo > 2000){

        println("Sí paga impuestos")
    }

}