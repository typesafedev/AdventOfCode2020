using static Inputs.Constants;

var zipped = Input1
    .Split(Environment.NewLine)
    .Select(x => int.Parse(x))
    .Zip(Input1
        .Split(Environment.NewLine)
        .Skip(1)
        .Select(x => int.Parse(x)))
    .Select(z => z.First < z.Second ? "Increasing" : "Decreasing");

// Console.WriteLine($"Count lines:{Input1.Split(Environment.NewLine).Count()}");
// zipped.ToList().ForEach(Console.WriteLine);
Console.WriteLine($"Increasing measurements: {zipped.Where(x => x == "Increasing").Count()}");

