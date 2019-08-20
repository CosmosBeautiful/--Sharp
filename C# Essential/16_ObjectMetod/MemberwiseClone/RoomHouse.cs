using System;

namespace MemberwiseClone
{


    class TypeHouse
    {
        public string type;
    }

    class AddressHouse
    {
        public string address;
        public TypeHouse typeHouse = new TypeHouse();

        public AddressHouse(string Address, string TypeHouse)
        {
            address = Address;
            typeHouse.type = TypeHouse;
        }
    }

    class RoomHouse : AddressHouse
    {
        public int area;
        public int quantityRoom;

        public RoomHouse(int Area, int QuantityRoom, string Address, string TypeHouse) 
            :base(Address, TypeHouse)
        {
            area = Area;
            quantityRoom = QuantityRoom;
        }

        //Ссылочный тип, клонируется ссылками
        public RoomHouse SurfaceClone() //Поверхностное клонирование
        {
            return MemberwiseClone() as RoomHouse;
        }

        public RoomHouse DeepClone() //Глубокое клонирование
        {
            return new RoomHouse(this.area, this.quantityRoom, this.address, this.typeHouse.type);
        }

        public override string ToString()
        {
            return String.Format("[{0}, {1}, {2}, {3}]", typeHouse.type, area, quantityRoom, address);
        }
    }
}
