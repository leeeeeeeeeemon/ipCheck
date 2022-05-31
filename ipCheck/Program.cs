// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string ip1 = Console.ReadLine();
string[] ip1Split = ip1.Split('.');
if(ip1Split.Length != 4 || Convert.ToInt32(ip1Split[0]) < 0 || Convert.ToInt32(ip1Split[1]) < 0 || Convert.ToInt32(ip1Split[2]) < 0 || Convert.ToInt32(ip1Split[3]) < 0 || Convert.ToInt32(ip1Split[0]) > 255 || Convert.ToInt32(ip1Split[1]) > 255 || Convert.ToInt32(ip1Split[2]) > 255 || Convert.ToInt32(ip1Split[3]) > 255)
{
    Console.WriteLine("Неверно введенный адресс");
}
else
{
    
    string ip2 = Console.ReadLine();
    string[] ip2Split = ip2.Split('.');
    if(ip2Split.Length != 4 || Convert.ToInt32(ip2Split[0]) < 0 || Convert.ToInt32(ip2Split[1]) < 0 || Convert.ToInt32(ip2Split[2]) < 0 || Convert.ToInt32(ip2Split[3]) < 0 || Convert.ToInt32(ip2Split[0]) > 255 || Convert.ToInt32(ip2Split[1]) > 255 ||  Convert.ToInt32(ip2Split[2]) > 255 || Convert.ToInt32(ip2Split[2]) > 255)
    {
        Console.WriteLine("Неверно введенный адресс");
    }
    else
    {
        int ip2bit2 = ((Convert.ToInt32(ip2Split[0]) * (256*256*256)) + (Convert.ToInt32(ip2Split[1]) *(256 * 256) ) + (Convert.ToInt32(ip2Split[2]) * 256) + Convert.ToInt32(ip2Split[3]) + 1 );
        int ip2bit1 = ((Convert.ToInt32(ip1Split[0]) * (256 * 256 * 256)) + (Convert.ToInt32(ip1Split[1]) * (256 * 256)) + (Convert.ToInt32(ip1Split[2]) * 256) + Convert.ToInt32(ip1Split[3]) + 1 );
        int result = (ip2bit2 - ip2bit1);

        Console.WriteLine(result);
    }
}

