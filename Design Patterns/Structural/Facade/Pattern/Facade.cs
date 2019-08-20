namespace Facade
{
    class Facade
    {
        Ignition ignition = new Ignition();
        Gas gas = new Gas();
        Brake brake = new Brake();

        public void Ignition()
        {
            ignition.OperationA();
            ignition.OperationB();
            ignition.OperationC();
        }

        public void Gas()
        {
            gas.OperationA();
            gas.OperationB();
            gas.OperationC();
            gas.OperationD();
        }

        public void Brake()
        {
            brake.OperationA();
            brake.OperationB();
            brake.OperationC();
        }
    }
}
