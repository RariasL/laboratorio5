Dictionary<string, string> paisesyCapitales = new Dictionary<string, string>
{
    {"francia","Paris" },
    {"españa","Madrid" },
    {"italia", "Roma" }
};

foreach (KeyValuePair<string,string> par in paisesyCapitales)
{
    Console.WriteLine("la capital de " + par.Key + "es" + par.Value + ".");
}