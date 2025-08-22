using System;
using System.Diagnostics;

class Checker
{
    const float MIN_TEMPERATURE = 95.0f;
    const float MAX_TEMPERATURE = 102.0f;
    const int MIN_PULSE = 60;
    const int MAX_PULSE = 100;
    const int MIN_SPO2 = 90;

    public static bool CheckTemperature(float temperature)
    {
        if (temperature > MAX_TEMPERATURE || temperature < MIN_TEMPERATURE)
        {
            Console.WriteLine("Temperature is critical!");
            BlinkAlert();
            return false;
        }
        else
        {
            Console.WriteLine("Temperature is normal");
            return true;
        }
    }

    public static bool CheckPulseRate(int pulseRate)
    {
        if (pulseRate < MIN_PULSE || pulseRate > MAX_PULSE)
        {
            Console.WriteLine("Pulse Rate is critical!");
            BlinkAlert();
            return false;
        }
        else
        {
            Console.WriteLine("Pulse Rate is normal");
            return true;
        }
    }

    public static bool CheckOxygenSaturation(int spo2)
    {
        if (spo2 < MIN_SPO2)
        {
            Console.WriteLine("Oxygen Saturation is critical!");
            BlinkAlert();
            return false;
        }
        else
        {
            Console.WriteLine("Oxygen Saturation is normal");
            return true;
        }
    }
    
    public static bool IsAllVitals_OK(float temperature, int pulseRate, int spo2)
    {
        bool IsTemperature_OK  = CheckTemperature(temperature);
        bool IsPulseRate_OK    = CheckPulseRate(pulseRate);
        bool IsSpo2_OK         = CheckOxygenSaturation(spo2);
        
        if (IsTemperature_OK && IsPulseRate_OK && IsSpo2_OK)
        {
            Console.WriteLine("Result: All vitals are within normal range.\n");
            return true;
        }
        else
        {
            Console.WriteLine("Result: One or more vitals are critical!\n");
            return false;
        }
    }

    private static void BlinkAlert()
    {
        for (int i = 0; i < 6; i++)
        {
            Console.Write("\r* ");
            System.Threading.Thread.Sleep(1000);
            Console.Write("\r *");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine("\n");
    }
