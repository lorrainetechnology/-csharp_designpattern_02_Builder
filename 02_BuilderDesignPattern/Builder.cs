namespace _02_BuilderDesignPattern
{
    public interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        void BuildPartC();
        IProduct GetProduct();

    }
    public class ConcreteBuilder1 : IBuilder
    {
        private Product _product = new Product();

        public void BuildPartA()
        {
            _product.Add("PartA1");
        }

        public void BuildPartB()
        {
            _product.Add("PartB1");
        }

        public void BuildPartC()
        {
            _product.Add("PartC1");
        }

        public IProduct GetProduct()
        {
            //Product result = _product;
            //Reset();
            return _product;
        }
    }

    public class ConcreteBuilder2 : IBuilder
    {
        private Product _product = new Product();

        //public ConcreteBuilder()
        //{
        //    Reset();
        //}

        //public void Reset()
        //{
        //    _product = new Product();
        //}
        public void BuildPartA()
        {
            _product.Add("PartA2");
        }

        public void BuildPartB()
        {
            _product.Add("PartB2");
        }

        public void BuildPartC()
        {
            _product.Add("PartC2");
        }

        public IProduct GetProduct()
        {
            //Product result = _product;
            //Reset();
            return _product;
        }
    }
}
