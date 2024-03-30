package secciondos

fun main(args:Array<String>){

    println("Ingrese su nombre: ")
    val nombre=readLine()

    println("Ingrese su edad: ")
    //val edad=readLine()
    val edad:Int= readLine()!!.toInt()//Convertir lo ingresado a Int
    println("El nombre ingresado fue: $nombre")
    println("La edad ingresada fue: $edad")

}