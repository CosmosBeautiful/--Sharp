using System;

namespace Equals
{
    class Block
    {
        public int length;
        public int width;
        public int height;

        public Block(int Length, int Width, int Height)
        {
            length = Length;
            width = Width;
            height = Height;
        }

        public override bool Equals(object obj) //данный метод предоставляет сравнение объектов
        {
            if (obj == null && this.GetType() != obj.GetType())
            {
                return false;
            }

            Block block = (Block)obj;
            return (length == block.length) && (width == block.width) && (height == block.height);
        }

        public override int GetHashCode() 
        {
            return (length*1000) ^ (width*100) ^ (height*10);
        }

        public override string ToString()
        {
            return String.Format("Длина: {0}, Ширина: {1}, Выстота: {2} ", length, width, height);
        }
    }
}
