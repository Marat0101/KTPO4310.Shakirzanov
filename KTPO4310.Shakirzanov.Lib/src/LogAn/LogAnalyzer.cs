using KTPO4310.Shakirzanov.Lib.src.LogAn;
using System;
using System.IO;

namespace KTPO4310.Ivanov.Lib.src.LogAn
{
    // The LogAnalyzer class *inside* the namespace
    public class LogAnalyzer
    {
        public bool IsValidLogFileName(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                return false;
            }

            try
            {
                return Path.GetExtension(fileName).Equals(".log", StringComparison.OrdinalIgnoreCase);
            }
            catch (ArgumentException)
            {
                return false; // Handle the exception appropriately – perhaps log it.
            }
        }
    }
}

namespace KTPO4310.Shakirzanov.Lib.src.LogAn
{
    /// <summary> Анализатор лог. файлов </summary>
    public class LogAnalyzer
    {
        /// <summary> Проверка правильности имени файла</summary>
        public bool IsValidLogFileName(string fileName)
        {
            IExtensionManager extensionManager = ExtensionManagerFactory.Create(); //Получаем менеджер из фабрики
            return extensionManager.IsValid(fileName);
        }
    }
}
