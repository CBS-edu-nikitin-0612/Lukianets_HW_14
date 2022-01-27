using System;

namespace Task4
{
    internal class DocumentWorker
    {
        private DocumentWorker _document;

        /// <summary>
        /// Returns new class instace of type depending on the key value.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static DocumentWorker InitializeDocument(string key)
        {
            if (key == "pro")
                return new ProDocumentWorker();
            else if (key == "expert")
                return new ExpertDocumentWorker();
            else
                return new DocumentWorker();
        }

        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }
}
