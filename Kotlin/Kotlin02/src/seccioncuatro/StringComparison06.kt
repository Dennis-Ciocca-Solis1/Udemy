package seccioncuatro

fun main(args:Array<String>){

    val nombre1: String= "Dennis"
    val nombre2: String= "dennis"

    /*if (nombre1 === nombre2)
        println("Son iguales")
    else
        println("No son iguales")*/

    /*if (nombre1.equals(nombre2))
        println("Son iguales")
    else
        println("No son iguales")*/

    if (nombre1.equals(nombre2,true)) //Ignore Case (agregar true)
        println("Son iguales")
    else
        println("No son iguales")

}