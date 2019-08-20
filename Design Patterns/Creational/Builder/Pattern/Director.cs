namespace Builder
{
    class Director
    {
        Builder _builder;

        public Director(Builder builder)
        {
            this._builder = builder;
        }

        public void Construct()
        {
            //Правильный порядок использования
            _builder.ProdusePaper();
            _builder.PrintMarkup();
            _builder.MakeCover();

        }


    }
}
