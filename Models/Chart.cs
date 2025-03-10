class Chart
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int Stock { get; set; }

    public Chart(string name, string type, int stock)
    {
        Name = name;
        Type = type;
        Stock = stock;
    }
}