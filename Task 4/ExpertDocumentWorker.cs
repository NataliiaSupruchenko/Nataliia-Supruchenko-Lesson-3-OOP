using System;

namespace Task_4
{
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Document is saved in a new formt"); 
        }
    }
}
