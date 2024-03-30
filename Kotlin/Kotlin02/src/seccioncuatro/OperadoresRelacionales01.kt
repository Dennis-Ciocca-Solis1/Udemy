package seccioncuatro

fun main(args:Array<String>){
    println("Comparador menor que; mayor que")
    println(7<10) //arroja "true"
    println(7>10) //arroja "false"

    println("Comparador igual que ")
    println(7==7) //arroja "true"
    println(7==10) //arroja "false"

    println("Comparador diferente que ")
    println(7!=7) //arroja "false"
    println(7!=10) //arroja "true"

    println("Comparador \"y\"")
    println(7>=6 && 9<10) //arroja "true"
    println(7<8 && 10<=9) //arroja "false"

    println("Comparador \"o\"")
    println(7<6 || 9<10) //arroja "true"
    println(7<6 || 10<10) //arroja "false"

    println("Comparador \"boolean\"")
    var num1:Boolean=true

    //println(num1) //true
    println(!num1) //false



}