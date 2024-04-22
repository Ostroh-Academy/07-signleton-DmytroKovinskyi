using System;
using System.Collections.Generic;

public class Device
{
    public string Name { get; set; }

    public void TurnOn()
    {
        Console.WriteLine($"Пристрiй '{Name}' увiмкнено.");
    }

    public void TurnOff()
    {
        Console.WriteLine($"Пристрiй '{Name}' вимкнено.");
    }
}

public class HomeAutomationSystem
{
    private static HomeAutomationSystem instance;
    private List<Device> devices;

    private HomeAutomationSystem()
    {
        devices = new List<Device>();
    }

    public static HomeAutomationSystem GetInstance()
    {
        if (instance == null)
        {
            instance = new HomeAutomationSystem();
        }
        return instance;
    }

    public void AddDevice(Device device)
    {
        devices.Add(device);
        Console.WriteLine($"Пристрiй '{device.Name}' додано до системи монiторингу.");
    }

    public void MonitorDevices()
    {
        foreach (var device in devices)
        {
            Console.WriteLine($"Монiторимо пристрiй '{device.Name}'.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        HomeAutomationSystem system = HomeAutomationSystem.GetInstance();

        Device light = new Device { Name = "Джерело свiтла" };
        Device thermostat = new Device { Name = "Термостат" };
        system.AddDevice(light);
        system.AddDevice(thermostat);

        system.MonitorDevices();

        HomeAutomationSystem anotherSystem = HomeAutomationSystem.GetInstance();
        if (system == anotherSystem)
        {
            Console.WriteLine("Це один i той самий екземпляр системи монiторингу.");
        }
        else
        {
            Console.WriteLine("Помилка! Сталася помилка при отриманнi єдиного екземпляру системи монiторингу.");
        }
    }
}
