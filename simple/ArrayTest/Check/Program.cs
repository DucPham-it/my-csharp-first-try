// ponytail: one assert that fails if NumberToText breaks; run: dotnet run --project Check/Check.csproj
using XTL;

var t = Utils.NumberToText(21, suffix: false);
System.Diagnostics.Debug.Assert(t.Contains("hai") && t.Contains("mươi") && t.Contains("một"), t);
if (!(t.Contains("hai") && t.Contains("mươi") && t.Contains("một")))
{
    Console.Error.WriteLine($"FAIL: {t}");
    return 1;
}
Console.WriteLine($"ok: {t}");
return 0;
