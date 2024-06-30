namespace ProductWebAPI
{
    public class ProductModelData
    {
        public string ModelName { get; set; }
        public string ModelDescription { get; set; }
        public int originalPrice { get; set; }
        public int discountPrice =>(int)(originalPrice*0.75);
        public string ModelCategory { get; set; }
    }
}
