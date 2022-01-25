// Decompiled with JetBrains decompiler
// Type: Lesson_6.Program
// Assembly: Lesson-6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F6B06B06-4352-4E4D-8C94-A1A1D0FD8DA1
// Assembly location: C:\Users\89060\OneDrive\Рабочий стол\HomeWork\HomeWork-\lesson-6\Lesson-6\Lesson-6\obj\Debug\Lesson-6.exe

using System;
using System.Diagnostics;

namespace Lesson_6
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("Список текущих процессов:     ");
      Console.WriteLine("                              ");
      Console.WriteLine("ID           Name Process     ");
      Console.WriteLine("                              ");
      foreach (Process process in Process.GetProcesses())
        Console.WriteLine(process.Id.ToString() + "     " + process.ProcessName);
      Console.WriteLine("                              ");
      Console.WriteLine("Для завершения конкретногоо процесса напишите его 'ID':      ");
      int int32 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Завершить процесс " + Process.GetProcessById(int32)?.ToString() + "???");
      Console.WriteLine("     yes / no    +  Enter  ");
      if (Console.ReadLine() == "yes")
        Process.GetProcessById(int32).Kill();
      Console.ReadKey();
    }
  }
}
