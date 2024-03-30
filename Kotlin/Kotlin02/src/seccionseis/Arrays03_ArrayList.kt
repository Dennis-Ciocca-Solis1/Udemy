package seccionseis

fun main(args: Array<String>) {//ARRAY LIST

    val arrayList= ArrayList<String>()

    arrayList.add("Uva")
    arrayList.add("Pera")
    arrayList.add("Kiwi")

    println("El elemento en la posición 2 es: " + arrayList[2])

    print("Todos los elementos son: ")
    for (elemento in arrayList){ //Leer los elementos por "objeto"
        print(elemento + " ")
    }
    println()

    println("Todos los elementos por índice son: ")
    for (indice in 0..2){ //Leer los elementos por "índice"
        println(arrayList[indice])
    }

//-------------------------------------------------------------
    //Otras maneras de añadir elementos a un Array

    arrayList[1]= ("Fresa")

    arrayList.set(2, "Mango")

   /* println("Todos los elementos por índice son: ")
    for (indice in 0..2){ //Leer los elementos por "índice"
        println(arrayList[indice])
    }*/
    println(arrayList) //Leer todos los elementos del ArrayList

    if (arrayList.contains("Kiwi")){
        println("Se ha encontrado")
    }else{
        println("No se ha encontrado")
    }
//--------------------------------------------------------------

    //RECORRER EL TAMAÑO TOTAL DEL "ARRAY"
    for (tamañaDesconocido in 0..arrayList.size -1){
        println(arrayList[tamañaDesconocido])
    }



}