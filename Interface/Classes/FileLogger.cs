using System;

namespace Interface;

class FileLogger : ILogger
{
    public void WriteLog()
    {
        Console.WriteLine("Dosya yoluyla loglandı.");
    }
}