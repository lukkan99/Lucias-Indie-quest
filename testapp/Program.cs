Double lightyears = 4.365;
Double parsecs = (9460730472580800 * lightyears) / 30856775812799588;
Console.WriteLine($"Distance to Alpha Centauri in parsecs: {parsecs}\nfrends comparetion:{Math.Round(parsecs,4).Equals(1.3383)}");