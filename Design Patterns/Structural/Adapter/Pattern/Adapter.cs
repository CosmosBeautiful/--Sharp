namespace Adapter
{
    class Adapter : Write
    {
        Paintbrush paintbrush = new Paintbrush();

        public override void WriteWords()
        {
            paintbrush.drawing = words;
            paintbrush.Draw();
        }
    }
}
