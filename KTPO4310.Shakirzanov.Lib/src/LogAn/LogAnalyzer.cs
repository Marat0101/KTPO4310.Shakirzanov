using KTPO4310.Shakirzanov.Lib.src.LogAn;

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
