using WithSOLID.LiskovSubstitution;

// Liskov's Substitution
Square square = new Square(5);
square.Side = 10; // This will not change the area calculation, adhering to Liskov's Substitution Principle
Console.WriteLine(square.Area()); // Output: 100, as expected

// Dependency Inversion
