package secciontres

fun main(args:Array<String>){
/*
    print("Ingrese cantidad de artículos: ")
    var cantidad:Int=readLine()!!.toInt()

    print("Ingrese costo unitario: ")
    var costo:Double=readLine()!!.toDouble()

    var total= cantidad * costo

    print("El total a pagar es: $total")
*/
    print("Ingrese 1er número: ")
    var num1:Int= readLine()!!.toInt()

    print("Ingrese 2er número: ")
    var num2:Int= readLine()!!.toInt()

    print("Ingrese 3er número: ")
    var num3:Int= readLine()!!.toInt()

    print("Ingrese 4er número: ")
    var num4:Int= readLine()!!.toInt()

    var suma = num1 + num2
    var multip = num3 * num4

    println()
    println("La suma de los 2 primeros números es: $suma")
    println("La multiplicación del 3er y 4to número es: $multip")

}