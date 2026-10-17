namespace WithSOLID.LiskovSubstitution
{
    public record Rectangle(double Width, double Height) : IShape
    {
        public double Area() => Width * Height;
    }
}
