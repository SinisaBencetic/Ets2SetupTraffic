<add key="TruckMinSpeed" value="0"/> <!-- Unesite odgovarajuću vrijednost -->
    <add key="TruckMaxSpeed" value="0"/> <!-- Unesite odgovarajuću vrijednost -->
    <add key="TruckMinCriticalSpeed" value="0"/> <!-- Unesite odgovarajuću vrijednost -->
    <add key="CarMinSpeed" value="0"/> <!-- Unesite odgovarajuću vrijednost -->
    <add key="CarMaxSpeed" value="0"/> <!-- Unesite odgovarajuću vrijednost -->
    <add key="CarMinCriticalSpeed" value="0"/> <!-- Unesite odgovarajuću vrijednost -->
    <add key="BusMinSpeed" value="0"/> <!-- Unesite odgovarajuću vrijednost -->
    <add key="BusMaxSpeed" value="0"/> <!-- Unesite odgovarajuću vrijednost -->
    <add key="BusMinCriticalSpeed" value="0"/> <!-- Unesite odgovarajuću vrijednost -->



using System.Configuration;

private void LoadFormValues()
{
    txtSinTruckMin.Text = ConfigurationManager.AppSettings["TruckMinSpeed"];
    txtSinTruckMax.Text = ConfigurationManager.AppSettings["TruckMaxSpeed"];
    txtSinTruckMinCritical.Text = ConfigurationManager.AppSettings["TruckMinCriticalSpeed"];

    txtSinBusMin.Text = ConfigurationManager.AppSettings["BusMinSpeed"];
    txtSinBusMax.Text = ConfigurationManager.AppSettings["BusMaxSpeed"];
    txtSinBusMinCritical.Text = ConfigurationManager.AppSettings["BusMinCriticalSpeed"];

    txtSinCarMin.Text = ConfigurationManager.AppSettings["CarMinSpeed"];
    txtSinCarMax.Text = ConfigurationManager.AppSettings["CarMaxSpeed"];
    txtSinCarMinCritical.Text = ConfigurationManager.AppSettings["CarMinCriticalSpeed"];
}
