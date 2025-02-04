using System;
using System.Collections.Generic;

namespace Ets2SetupTraffic
{
    public class SinusSpikeSpeedCalculator
    {
        //private const double SPIKEFACTOR = 0.4; // koliko je spike u odnosu na amplitudu. manji broj veći spike
        //private const double SPIKEZONE = 0.1; // kolika je zona koju gledamo na vrhovima i gudurama u koju upada kandidat za spike. manji broj vrlo usko ili niti jedan.

        public static string Calc(
            SinSpikeGenericModel model,
            //int minRange, int maxRange, int minCritical, int phase, double spikeFactor, double spikeZone, 
            int phase,
            out int spikeCount,
            ref List<int> speeds
            )
        {
            
            spikeCount = 0;
            try
            {
                if (speeds == null) { speeds = new List<int>(); }
                
                if (model.MinSpeed>= model.MaxSpeed)
                {
                    return "Error: minRange must be less than maxRange.";                    
                }

                if (model.MinCriticalSpeed> model.MinSpeed)
                {
                    return "Error: minCriticalRange must be less than minRange.";
                }

                // Calculate amplitude and midline
                double amplitude = (model.MaxSpeed - model.MinSpeed) / 2.0;
                double midline = model.MinSpeed + amplitude;

                
                double step = 2 * Math.PI / phase; // Step size for the cycle
                

                for (int i = 0; i < phase; i++)
                {
                    double angle = i * step; // Calculate the angle
                    double y = midline + amplitude * Math.Sin(angle); // Calculate the sine value

                    // Logic for critical points
                    if (Math.Abs(y - (midline + amplitude)) < model.SpikeZone) // Max peak
                    {
                        spikeCount++;
                        double adjusted = midline + amplitude + amplitude / model.SpikeFactor;
                        speeds.Add(Convert.ToInt32(Math.Floor(adjusted)));
                        //Console.WriteLine($"Index {i}: {adjusted:F2} (Adjusted Max)");
                    }
                    else if (Math.Abs(y - (midline - amplitude)) < model.SpikeZone) // Min peak
                    {
                        spikeCount++;
                        double adjusted = midline - amplitude - amplitude / model.SpikeFactor;
                        int calcMin = Convert.ToInt32(Math.Floor(adjusted));
                        if (calcMin < model.MinCriticalSpeed)
                        {
                            calcMin = model.MinCriticalSpeed;
                        }
                        speeds.Add(calcMin);

                        //Console.WriteLine($"Index {i}: {adjusted:F2} (Adjusted Min)");
                    }
                    else
                    {
                        speeds.Add(Convert.ToInt32(Math.Floor(y)));

                        //Console.WriteLine($"Index {i}: {y:F2}");
                    }
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return string.Empty;
        }        
    }
}
