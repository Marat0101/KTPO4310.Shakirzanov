using System;
using  System.Configuration;
using KTPO4310.Shakirzanov.Lib.src.LogAn;
using System.Linq;


public class FileExtensionManager : IExtensionManager
{
    private readonly string[] _allowedExtensions;

    public FileExtensionManager()
    {
        string extensionsString = ConfigurationManager.AppSettings["AllowedExtensions"];

    }

    public bool IsValid(string fileName)
    {
        string ext = System.IO.Path.GetExtension(fileName)?.ToLowerInvariant();
        return _allowedExtensions.Contains(ext);
    }
}

namespace KTPO4310.Shakirzanov.Lib.src.LogAn
{
    /// <summary>Менеджер расширений файлов</summary>
    public class FileExtensionManager : IExtensionManager
    {
        /// <summary>проверка правильности расширения</summary>

        public FileExtensionManager()
        {
        }

        public bool IsValid(string fileName)
        {
            //читать конфигурационный файл
            //вернуть true
            //если конфигурация поддерживается

            throw new NotImplementedException();
        }
    }
}