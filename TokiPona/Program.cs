Console.WriteLine(@"  _______      _     _   _____                     
 |__   __|    | |   (_) |  __ \                    
    | |  ___  | | __ _  | |__) |___   _ __    __ _ 
    | | / _ \ | |/ /| | |  ___// _ \ | '_ \  / _` |
    | || (_) ||   < | | | |   | (_) || | | || (_| |
    |_| \___/ |_|\_\|_| |_|    \___/ |_| |_| \__,_|
                                                   
                                                   ");
Dictionary<string, string> slovnik_toki = new Dictionary<string,string>();
slovnik_toki.Add("soweli", "kočka/pes/pozemní savec");
slovnik_toki.Add("oko", "oko");
Console.WriteLine("Zadejte slovo v Toki Pona");

foreach(var slova in slovnik_toki)
{
    Console.WriteLine(slova.Key);
    Console.WriteLine(slova.Value);
    Console.WriteLine("---------------------------");
}
