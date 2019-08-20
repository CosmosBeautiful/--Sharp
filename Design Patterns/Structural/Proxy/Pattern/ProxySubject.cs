using System;

namespace Proxy
{
    enum Role
    {
        guest,
        user,
        administrator
    }

    class ProxySubject : Subject
    {
        Subject subject;
        Role role;

        public ProxySubject (Subject subject, Role role)
        {
            this.subject = subject;
            this.role = role;
        }

        public override void Read()
        {
            this.subject.Read();
        }

        public override void Create()
        {
            if (Role.user == role || Role.administrator == role)
            {
                this.subject.Create();
            }
            else
            {
                //throw new UnauthorizedAccessException("Create: Access denied.");
                Console.WriteLine("Create: Access denied.");
            }

        }

        public override void Update()
        {
            if (Role.administrator == role)
            {
                this.subject.Update();
            }
            else
            {
                Console.WriteLine("Update: Access denied.");
            }
        }

        public override bool Delete()
        {
            if (Role.administrator == role)
            {
                return this.subject.Delete();
            }
            else
            {
                Console.WriteLine("Delete: Access denied.");
                return false;
            }
        }

       

      
    }
}
