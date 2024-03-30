package seccioncuatro

fun main(args:Array<String>){

    var num1:Int=7
    var num2:Int=10

    var resultado:Int?

    /*if(num1 > num2)
        resultado = num1
    else
        resultado = num2

    println(resultado)*/

    /*resultado = if(num1 > num2)
        num1
    else
        num2
    println(resultado)*/

    //Esto es una expresión
    resultado = if(num1 > num2) num1 else num2

    println(resultado)

}