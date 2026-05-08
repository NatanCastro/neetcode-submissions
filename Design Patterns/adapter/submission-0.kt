class SquareHole(private val sideLength: Double) {
    fun canFit(square: Square): Boolean {
        return sideLength >= square.getSideLength()
    }
}

open class Square(private val sideLength: Double = 0.0) {
    open fun getSideLength(): Double = sideLength
}

class Circle(private val radius: Double) {
    fun getRadius(): Double = radius
}

class CircleToSquareAdapter(circle: Circle) : Square() {
    private val square: Square = Square(circle.getRadius() * 2.0)

    override fun getSideLength(): Double {
        return square.getSideLength()
    }
}
