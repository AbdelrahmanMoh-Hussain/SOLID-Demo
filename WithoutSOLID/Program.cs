using WithoutSOLID.LiskovSubstitution;

// Liskov's Substitution
Square square = new Square(5);
square.Width = 10; // This will also change the height, violating Liskov's Substitution Principle
Console.WriteLine(square.Area()); // Output: 100, but we expected 25 if it were a true square
