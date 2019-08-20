
namespace Prototype
{
    class PencilWriting : Writing
    {
        public PencilWriting(string color)
            : base(color)
        {
        }

        public override Writing Clone()
        {
            return new PencilWriting(Color);
        }
    }
}
