


public abstract class CoffeeDecorator : Coffee
{
    protected Coffee _coffee;

    public CoffeeDecorator(Coffee coffee)
    {
        _coffee = coffee;
    }

    public override string GetDescription() => _coffee.GetDescription();
    public override double GetCost() => _coffee.GetCost();
}
