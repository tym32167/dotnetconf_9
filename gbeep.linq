<Query Kind="Program" />

void Main()
{
	new GBeep();

	for(var i=0; i<10; i++)
	{
		var data = new int[100];
		Thread.Sleep(100);
		GC.Collect();
	}
}

public sealed class GBeep
{
	~GBeep()
	{
		"BEEP".Dump();
		
		if (!AppDomain.CurrentDomain.IsFinalizingForUnload()
			&& !Environment.HasShutdownStarted)
		{
			new GBeep();
		}
	}
}