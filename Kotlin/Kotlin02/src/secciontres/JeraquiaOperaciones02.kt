package secciontres

fun main(args:Array<String>){

    //Prioridad de la Operaciones

    /*
    * 1.-  ()  : parentesis
    * 2.- ++, -- : antes de la variable
    * 3.-   ^  : potencias
    * 4.- *, / : multiplicación y división
    * 5.- +, - : suma y resta
    * 6.-   %  : residuo o mod
    * 7.-   =  : igual
    * 8.- ++, -- : después de la variable
    */

    val num1=10
    val num2=5
    val num3=2

    val resultado:Int?

    resultado=num1 + num2 * num3 - 1

    println("El resultado es : $resultado")

}