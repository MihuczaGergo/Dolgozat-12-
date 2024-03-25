using ClassLibrary.Data;
using ClassLibrary.Models;

Context _context = new Context();

if (!_context.Alkalmazottak.Any())
{
    var adatok = File.ReadAllLines(@"C:\Users\Diak\dev\nj-i2n\Asztali alkalmazások fejlesztése\12.csv").Skip(1);
    foreach (var item in adatok)
    {
        _context.Alkalmazottak.Add(new Alkalmazottak(item));
    }
    _context.SaveChanges();
    Console.WriteLine("Adatok feltöltése sikeres!");
}

Console.WriteLine("Adatok kiírása:");
foreach (var item in _context.Alkalmazottak)
{
    Console.WriteLine(item);
}
