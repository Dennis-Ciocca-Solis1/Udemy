package seccioncinco

fun main(args:Array<String>){

   /* var multiplo=8

    for (index in 1..400){
        if (index%8==0){
            print(" " + index)
        }
    }*/

/*    var num=0..400
    for (multiplos in 8..400 step 8){
        print(" " + multiplos)
    }*/

    print("Ingrese 1er Número: ")
    var num1 : Int = readLine()!!.toInt()

    print("Ingrese 2er Número: ")
    var num2 : Int = readLine()!!.toInt()

    print("Ingrese 3er Número: ")
    var num3 : Int = readLine()!!.toInt()

    var pares=0
    var impares=0

    if(num1%2==0){
        pares++
    }else{
        impares++
    }

    if(num2%2==0){
        pares++
    }else{
        impares++
    }

    if(num3%2==0){
        pares++
    }else{
        impares++
    }

    println("Cantidad de pares: $pares")
    println("Cantidad de impares: $impares")
}
