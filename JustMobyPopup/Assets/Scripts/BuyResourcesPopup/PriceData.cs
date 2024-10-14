using System;

namespace Game.Popups
{
    [Serializable]
    public struct PriceData
    {
        public float FullCost;
        public int Discount;
        public readonly float DiscountCost => (float)Math.Round(FullCost - (FullCost * Discount / 100), 2);
        public readonly bool HasDiscount => Discount > 0;

        public PriceData(float fullCost, int discount)
        {
            FullCost = fullCost;
            Discount = discount;
        }
    }
}
