package secciondos

fun main(args:Array<String>){

    var num1: Int=5
    var num2: Int=10
    var strnumero: String="20"

    num1=strnumero.toInt() //Convertir String to Int

    strnumero=num2.toString() //Convertir Int to String

    println(num1)
    println(num2)

    //var num3:Float? Puede contener o no un valor
    var num3:Float?=12.5f
    num3 = num1.toFloat() //Convertir Int to Float
    println(num3)

    var num4:Double= 12.5 //Convertir Float to Double
    num4=num2.toDouble()
    println(num4)

}
