
Die d1 = new Die();
Console.WriteLine($"Value of d1: {d1.faceValue}");

Die d2 = new Die(3);
Console.WriteLine($"Value of d2: {d2.faceValue}");

d1.Shake();
d2.Shake();
Console.WriteLine($"Value of d1: {d1.faceValue}");
Console.WriteLine($"Value of d2: {d2.faceValue}");

// Will throw error
d2 = new Die(7);