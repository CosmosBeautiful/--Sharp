
namespace Prototype
{
    class PenWriting : Writing
    {
        public PenWriting(string color)
            : base(color)
        {
        }

        public override Writing Clone()
        {
            return new PenWriting(Color);
        }
    }
}
