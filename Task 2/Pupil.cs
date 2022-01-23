using System;

namespace Task_2
{
    class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Pupil.Stady()");
        }
        public virtual void Read()
        {
            Console.WriteLine("Pupil.Read()");
        }
        public virtual void Write() 
        {
            Console.WriteLine("Pupil.Write()");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Public.Relax()");
        }
    }
}
