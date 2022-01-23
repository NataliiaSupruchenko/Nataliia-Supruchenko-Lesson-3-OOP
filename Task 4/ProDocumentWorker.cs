using System;


namespace Task_4
{
    class ProDocumentWorker: DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Document edited"); 
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Document is saved in the old format, saving in other formats is avaliable in the EXPERT version"); 
        }
    }
}
