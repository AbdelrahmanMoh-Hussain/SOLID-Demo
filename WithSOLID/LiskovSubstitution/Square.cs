namespace WithSOLID.LiskovSubstitution
{
    public record Square(double Side) : IShape
    {
        public double Area() => Side * Side;
    }
}
