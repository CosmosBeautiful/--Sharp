namespace Iterator
{
    class ConcreteIterator : Iterator
    {
        private Aggregate aggregate;
        private int current = 0;

        public ConcreteIterator(Aggregate aggregate)
        {
            this.aggregate = aggregate;
        }


        public override Book First()
        {
            return aggregate[0];
        }

        public override Book Next()
        {
            if (current++ < aggregate.Count - 1)
                return aggregate[current];
            else
                return null;
        }

        public override Book CurrentItem()
        {
            return aggregate[current];
        }

        public override bool IsDone()
        {
            if (current < aggregate.Count)
                return false;

            current = 0;
            return true;
        }
    }
}
