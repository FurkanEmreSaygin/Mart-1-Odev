class Product
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int Stock { get; set; }

    public Product(string name, string type, int stock)
    {
        Name = name;
        Type = type;
        Stock = stock;
    }
}
