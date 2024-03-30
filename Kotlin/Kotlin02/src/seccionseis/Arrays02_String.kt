package seccionseis

fun main(args:Array<String>){//ARRAY DE TIPO "STRING"

    //agregar elementos al "Array"
    val fruta= Array<String>(2){""}
    //se puede omitir la palabra "String"

    for(indice in 0..1){
        print("Ingresa la fruta del índice [$indice]: ")
        fruta[indice]= readLine()!!
    }

    //leer los elementos ingresados
    for (indice in 0..1){
        println("La fruta en el índice [$indice] es: " + fruta[indice])
    }



}