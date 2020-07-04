using System;

public class Program
{
	private static Computer _computer;
	private static Mobile _mobile;
	public static void Main()
	{
		_computer = new Computer();
		_mobile = new Mobile();
		_computer.Test();
		Console.WriteLine();
		_mobile.Test();
	}
}


public interface IDevice
{
	public string Action { get; set; }
	public void run();
}

public class Ram : IDevice
{
    public string Action { get; set; }

    public void run()
    {
		Console.WriteLine("Storing Data");
    }
}

public class Motherboard : IDevice
{
	public string Action { get; set; }

	public void run()
	{
		Console.WriteLine("Connecting everything");
	}
}

public class Cpu : IDevice
{
	public string Action { get; set; }

	public void run()
	{
		Console.WriteLine("Calculating");
	}
}

public class HardDrive : IDevice
{
	public string Action { get; set; }

	public void run()
	{
		Console.WriteLine("Writing Data");
	}
}
public class PowerSupply : IDevice
{
	public string Action { get; set; }

	public void run()
	{
		Console.WriteLine("Producing Power");
	}
}
public class Screen : IDevice
{
	public string Action { get; set; }

	public void run()
	{
		Console.WriteLine("Displaying stuff");
	}
}
public class Battery : IDevice
{
	public string Action { get; set; }

	public void run()
	{
		Console.WriteLine("Charging...");
	}
}

public class Computer
{
	IDevice[] devices = new IDevice[5];
	
    public Computer()
    {
		devices[0] = new Motherboard();
		devices[1] = new Cpu();
		devices[2] = new Ram();
		devices[3] = new HardDrive();
		devices[4] = new PowerSupply();
	}

	public void Test()
	{
		Console.WriteLine("Testing computer");
		foreach (IDevice item in devices)
        {
			item.run();
        }
	}
}

public class Mobile
{
	IDevice[] devices = new IDevice[5];

	public Mobile()
	{
		devices[0] = new Motherboard();
		devices[1] = new Cpu();
		devices[2] = new Ram();
		devices[3] = new Screen();
		devices[4] = new Battery();
	}

	public void Test()
	{
		Console.WriteLine("Testing Mobile");
		foreach (IDevice item in devices)
		{
			item.run();
		}
	}
}