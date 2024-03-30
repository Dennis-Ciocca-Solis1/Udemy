package seccioncuatro

fun main(args:Array<String>){

    print("Ingrese la medida en metros: ")
    var medida:Double= readLine()!!.toDouble()

    if (medida >= 1.80) {

        if (medida > 5.00) {
            println("La medida $medida sobrepasa los límites aceptados")
        } else {
            println("La medida $medida es aceptable")
        }
    }
        else{
        println("Lo siento, no es aceptable")}

}

