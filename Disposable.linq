<Query Kind="Program" />

void Main()
{
	
}

class BaseClass : IDisposable
{
   // Флаг определяет, был ли уже вызван метод Dispose
   bool disposed = false;

   // Реализация шаблона освобождения ресурсов, вызывается программистом
   public void Dispose()
   { 
      Dispose(true);
      GC.SuppressFinalize(this);           
   }

   // Защищенная реализация шаблона
   protected virtual void Dispose(bool disposing)
   {
      if (disposed)
         return; 

      if (disposing) {
         // Освобождение всех управляемых ресурсов
         //
      }

      // Освобождение неуправляемых ресурсов
      //
      disposed = true;
   }
   
   ~BaseClass()
   {
      Dispose(false);
   }
}

