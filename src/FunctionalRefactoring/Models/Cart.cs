namespace FunctionalRefactoring.Models
{
    record Cart(CartId Id, CustomerId CustomerId, Amount Amount)
    {
        internal static readonly Cart MissingCart = default;
    }
}
