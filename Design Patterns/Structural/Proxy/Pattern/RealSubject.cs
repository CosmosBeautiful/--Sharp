using System;

namespace Proxy
{
    class RealSubject : Subject
    {
        public override void Create()
        {
            Console.WriteLine("Create - OK!");
        }

        public override void Read()
        {
            Console.WriteLine("Read - OK!");
        }

        public override void Update()
        {
            Console.WriteLine("Update - OK!");
        }

        public override bool Delete()
        {
            try
            {
                Console.WriteLine("Delete - OK!");
                return true;
            }
            catch
            {
                return false;
            }
            
        }
    }
}
