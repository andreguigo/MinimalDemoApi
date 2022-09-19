namespace MinimalDemoApi.Model
{
    public class Product
    {
        public string Description { get; set; } = string.Empty;
        public float? Price { get; set; } = float.MinValue;
        public string Code { get; set; } = string.Empty;
    }
}
