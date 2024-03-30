package secciontres

fun main(args:Array<String>){

    var num1=10
    val num2=5

    val resultado:Int?

    //resultado = ++num1 + num2 (primero incrementa; luego suma)
    //resultado = --num1 + num2 (primero decrementa, luego suma)

    //resultado = num1++ + num2 (1ro suma; luego incrementa el "num1")
    resultado = num1-- + num2 //(1ro suma; luego decrementa el "num1")

    println("El resultado es: $resultado")
    println("El num1 ahora vale: $num1")

}