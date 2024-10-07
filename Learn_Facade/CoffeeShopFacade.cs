public class CoffeeShopFacade
{
    private CoffeeMaker _coffeeMaker;
    private PaymentSystem _paymentSystem;
    private DeliverySystem _deliverySystem;

    public CoffeeShopFacade()
    {
        _coffeeMaker = new CoffeeMaker();
        _paymentSystem = new PaymentSystem();
        _deliverySystem = new DeliverySystem();
    }

    public void OrderCoffee()
    {
        _coffeeMaker.BrewCoffee();
        _paymentSystem.ProcessPayment();
        _deliverySystem.DeliverOrder();
    }
}

