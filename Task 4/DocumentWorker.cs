using System;


namespace Task_4
{
    class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Document is open");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Document editing avaliable in PRO version");
        }
        public virtual void SaveDocument() 
        {
            Console.WriteLine("Document saving avaliable in PRO version");
        }
    }
}
