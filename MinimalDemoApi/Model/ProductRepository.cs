namespace MinimalDemoApi.Model
{
    public class ProductRepository
    {
        public ProductRepository(bool data)
        {
            if(data)
            {
                CreateMemoryData();
            }
            else
            {
                ProductList = new List<Product>();
            }
        }

        private void CreateMemoryData()
        {
            this.ProductList = new List<Product>()
            {
                new Product() { Description = "Notebook", Price = 249, Code = "nt2022" },
                new Product() { Description = "Office Desk", Price = 109, Code = "od2022" },
                new Product() { Description = "Monitor", Price = 149, Code = "mn2022" }
            };
        }
        public List<Product> ProductList { get; set; }

        public Product AddProduct(Product p)
        {
            ProductList.Add(p);
            return p;
        }

        public List<Product> SelectAllProduct()
        {
            return ProductList;
        }

        public Product SelectProduct(string code)
        {
            var pTemp = (from product in ProductList where product.Code == code select product).SingleOrDefault();
            if(pTemp != null )
                return pTemp;
            return new Product();
        }

        public bool UpdateProduct(Product p)
        {
            var pTemp = (from product in ProductList where product.Code == product.Code select product).SingleOrDefault();
            if(pTemp != null )
            {
                pTemp.Description = p.Description;
                pTemp.Price = p.Price;
                pTemp.Code = p.Code;
                return true;
            }
            return false;
        }

        public bool RemoveProduct(string code)
        {
            var pTemp = (from product in ProductList where product.Code == code select product).SingleOrDefault();
            if (pTemp != null)
            {
                var removed = ProductList.Remove(pTemp);
                return removed;
            }
            return false;
        }
    }
}
