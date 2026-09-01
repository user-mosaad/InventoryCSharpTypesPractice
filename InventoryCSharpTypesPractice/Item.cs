namespace RBSRetail.Items;

class Item
{
    // Fields and properties
    public int ItemId { get; set; }
    public required string Name { get; set; }
    public required string UOM { get; set; }
    public required int Quantity { get; set; }
    public decimal PurchasePrice { get; set; }
    public decimal SellingPrice { get; set; }

    // Constructor
    public Item(int itemId, string name, string uom, int quantity, decimal purchasePrice, decimal sellingPrice)
    {
        ItemId = itemId;
        Name = name;
        UOM = uom;
        Quantity = quantity;
        PurchasePrice = purchasePrice;
        SellingPrice = sellingPrice;
    }

    // Methods
    public decimal ReturnProfit()
    {
        return (SellingPrice * Quantity) - (PurchasePrice * Quantity);
    }




    // Operator method overloading:
    // Adding two Item types or subtracting them = add/subtract the quantity of the first item
}
