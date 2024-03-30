package seccioncinco

fun main(args:Array<String>){
    val nums = 1..25
    for (elemento in nums){
        print(" " + elemento)
    }
    println("----------------------------------------------")

    for (elemento in nums step 3){
        print(" " + elemento)
    }
    println("----------------------------------------------")

//---------------------------------------------------------
    for (elemento in nums.reversed()){
        print(" " + elemento)
    }
    println()

    /* for (elemento in 15 downTo 0 step 3) {
        print(" " + elemento)
    }*/

    var nums2 = 15 downTo 0 //step 3
    for (elemento in nums2){
        print(" " + elemento)
    }
    println()
//----------------------------------------------------------
    //var nums2 = 1 until 16 //step 3
    for (elementos in 1 until 16 /*step 3*/){ //llega hasta el último menos 1

            print(" "+ elementos)
    }
    println()

//-----------------------------------------------------------
    var chars = 'A'..'z'

    for (elementos in chars){
        print(" " + elementos)
    }

}