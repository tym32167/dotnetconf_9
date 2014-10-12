<Query Kind="Program" />

void Main()
{
	var timer = new Timer(Callback,null, 0, 200);	
	
	Thread.Sleep(3000);
	
	// timer = null; 
	// timer.Dispose(); 
	// GC.KeepAlive(timer); 
	
	//using(var timer = new Timer(Callback,null, 0, 200))
	//{
	//	Thread.Sleep(3000);
	//}
}

private static void Callback(object state)
{
	string.Format("Called at {0}", DateTime.Now).Dump();
	GC.Collect();
}