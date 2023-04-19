using System;

namespace FunctionalRefactoring.Models
{
    record DiscountRule(Func<Cart, Amount> Compute)
    {
        internal static readonly DiscountRule NoDiscount = new(c => throw new InvalidOperationException("no discount"));
    }
}
