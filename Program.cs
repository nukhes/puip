using System.Net.NetworkInformation;

if (NetworkInterface.GetIsNetworkAvailable()) {
  var https = new HttpClient();
  string ip = await https.GetStringAsync("https://api.ipify.org");
  Console.WriteLine($"\nYour public IP: {ip}");
} else {
  Console.WriteLine("You are not connected to the Internet!");
}
Console.ReadLine();