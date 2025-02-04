using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ets2SetupTraffic
{
    class TrafficManager
    {
        public static KeyValuePair<bool, string> SinusSpikeDebug(SinSpikeGenericModel model, List<string> vehicleList)
        {        
            List<int> truckSpeed = new List<int>();
            int phase = vehicleList.Count / model.CycleMultiplier;
            List<int> speeds = new List<int>();
            string msg = SinusSpikeSpeedCalculator.Calc(model, phase, out int spikeCount, ref speeds);
            if (!string.IsNullOrEmpty(msg))
            {
                return new KeyValuePair<bool, string>(false, msg);
            }
            msg = $" max:{speeds.Max()} spike %: {(((double)spikeCount * model.CycleMultiplier) / vehicleList.Count * 100).ToString("F2")}";

            return new KeyValuePair<bool, string>(true, msg);
        } 

        public static string RunSinusSpike(SinSpikeModel model)
        {
            var truckList = GetTruckList();

            List<int> truckSpeed = new List<int>();
            int truckPhase = truckList.Count / model.Truck.CycleMultiplier;
            string msg = SinusSpikeSpeedCalculator.Calc(model.Truck, truckPhase, out int spikeCount1, ref truckSpeed);
            if (!string.IsNullOrEmpty(msg))
            {
                return msg;
            }

            Debug.Print("*************** Trucks *******************");
            int i = 0;
            foreach (var truckFileName in truckList)
            {
                Debug.Print($"{truckFileName} :  {truckSpeed[i].ToString()}");
                AssignVehicleSpeed(truckFileName, truckSpeed[i]);

                i++;
                if (i == truckPhase)
                {
                    i = 0;
                }
            }

            var carList = GetCarList();
            var carSpeed = new List<int>();
            int carPhase = carList.Count / model.Car.CycleMultiplier;
            msg = string.Empty;
            msg = SinusSpikeSpeedCalculator.Calc(model.Car, carPhase, out int spikeCount2, ref carSpeed);
            if (!string.IsNullOrEmpty(msg))
            {
                return msg;
            }
            Debug.Print("*************** Cars *******************");
            i = 0;
            foreach (var carFileName in carList)
            {
                Debug.Print($"{carFileName} :  {carSpeed[i].ToString()}");
                AssignVehicleSpeed(carFileName, carSpeed[i]);

                i++;
                if (i == carPhase)
                {
                    i = 0;
                }
            }


            var busList = GetBusList();
            var busSpeed = new List<int>();
            int busPhase = busList.Count / model.Bus.CycleMultiplier;
            msg = string.Empty;
            msg = SinusSpikeSpeedCalculator.Calc(model.Bus, busPhase, out int spikeCount3, ref busSpeed);
            if (!string.IsNullOrEmpty(msg))
            {
                return msg;
            }

            Debug.Print("*************** Bus *******************");
            i = 0;
            foreach (var busFileName in busList)
            {
                Debug.Print($"{busFileName} :  {busSpeed[i].ToString()}");
                AssignVehicleSpeed(busFileName, busSpeed[i]);

                i++;
                if (i == busPhase)
                {
                    i = 0;
                }
            }
            
            return msg;
        }

        public static void Run(MainFormModel mainFormModel)
        {
            var truckList = GetTruckList();

            foreach (var truckFileName in truckList)
            {
                var truckSpeed = new Random().Next(mainFormModel.TruckMinSpeed, mainFormModel.TruckMaxSpeed);
                AssignVehicleSpeed(truckFileName, truckSpeed);
            }

            var carList = GetCarList();

            foreach (var carFileName in carList)
            {
                var carSpeed = new Random().Next(mainFormModel.CarMinSpeed, mainFormModel.CarMaxSpeed);
                AssignVehicleSpeed(carFileName, carSpeed);
            }


            var busList = GetBusList();

            foreach (var busFileName in busList)
            {
                var busSpeed = new Random().Next(mainFormModel.BusMinSpeed, mainFormModel.BusMaxSpeed);
                AssignVehicleSpeed(busFileName, busSpeed);
            }
        }

        private static void AssignVehicleSpeed(string truckFileName, int speed)
        {
            const string maxSpeedMatch = "(?<=max_speed:\\s+)\\d+";
            string path = Path.Combine(ModPath("VehicleAiRelativePath"), truckFileName);
            var fileContent = File.ReadAllText(path);
            fileContent = Regex.Replace(fileContent, maxSpeedMatch, speed.ToString());
            File.WriteAllText(path, fileContent);
        }

        public static List<string> GetVehicleList(string matchExpression, string configVehicleRelativePathKey)
        {
            List<string> result = new List<string>();
            string fileContent = File.ReadAllText(ModPath(configVehicleRelativePathKey));
            var matches = Regex.Matches(fileContent, matchExpression);
            for (int i = 0; i < matches.Count; i++)
            {
                result.Add(matches[i].Value);
            }
            return result;
        }

        public static List<string> GetBusList()
        {
            const string busExpressionMatch = "(?<=@include \"ai/)[a-zA-Z0-9_/.]+";
            return GetVehicleList(busExpressionMatch, "BusListFilePath");
        }

        public static List<string> GetCarList()
        {
            const string carExpressionMatch = "(?<=@include \"ai/)[a-zA-Z0-9_/.]+";
            return GetVehicleList(carExpressionMatch, "CarListFilePath");
        }

        public static List<string> GetTruckList()
        {
            const string truckName = "(?<=@include \"ai/)[a-zA-Z0-9_/.]+";
            return GetVehicleList(truckName, "TruckListFilePath");
        }

        public static string ModPath(string configKeyOfRelativePath)
        {
            var rootPath = ConfigurationManager.AppSettings["Ets2_SetupTrafficMod_Root"];
            var filePath = ConfigurationManager.AppSettings[configKeyOfRelativePath];
            return Path.Combine(rootPath, filePath);
        }
    }
}
