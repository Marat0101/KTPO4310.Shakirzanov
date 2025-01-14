using System;

namespace KTPO4310.Shakirzanov.Lib.src.LogAn
{
    public class LogAnalyzer
    {
        
        public bool WasLastFileNameValid { get; set; }
        public bool IsValidLogFileName(string fileName)
        {
            WasLastFileNameValid = false;

            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException("имя файла должно быть задано");
            }
            if (fileName.EndsWith(".log", StringComparison.CurrentCultureIgnoreCase))
            {
                return false;
            }
            
            WasLastFileNameValid = true;
            return true;
        }
    }
}
