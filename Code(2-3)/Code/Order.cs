class Order
{
    public Good Good;
    public int Count;

    public int GetTotalPrice()
    {
        return Good.Price * Count;
    }

    public void CloseOrder()
    {
        Good.Count -= Count;
    }
}
