namespace Game.Popups
{
    public struct PriceData
    {
        public readonly float FullCost;
        public readonly float DiscountCost;
        public readonly int Discount;
        public readonly bool HasDiscount;

        public PriceData(float fullCost, int discount)
        {
            FullCost = fullCost;
            Discount = discount;
            DiscountCost = fullCost - (fullCost * discount / 100);
            HasDiscount = discount > 0;
        }
    }
}
