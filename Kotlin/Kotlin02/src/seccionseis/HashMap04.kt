package seccionseis

fun main(args: Array<String>) { //HASH MAP

    /*
    @ HashMap se conoce como un KeyValue (una clave y un valor)
    @ Se puede almacenar cualquier valor
    @ Un HashMap no tiene un orden
    */

    val hashMap = HashMap<Int, String>()

    //Key Value
    hashMap.put(1, "Mérida")
    hashMap.put(200, "Villacorta")
    hashMap.put(50,"Iza")
    hashMap.put(100, "Seve")

    //println(hashMap[200])

    hashMap.put(100,"Dennis") //Forma de actualizar un valor

    for (clave in hashMap.keys){ //Recorrer el Hash Map
        println(hashMap[clave])
    }





}