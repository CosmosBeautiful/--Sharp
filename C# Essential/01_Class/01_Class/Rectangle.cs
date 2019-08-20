namespace Class
{
    class Rectangle
    {
        private double side1;
        private double side2;

        private double area;
        private double perimeter;

        public double Area { get { return area; } }
        public double Perimeter { get { return perimeter; } }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }


        public double AreaCalculator()
        {
            this.area = this.side1 * this.side2;
            return this.area;
        }

        public double PerimeterCalculator()
        {
            this.perimeter = (this.side1 + this.side2 * 2);
            return Perimeter;
        }
    }
}
