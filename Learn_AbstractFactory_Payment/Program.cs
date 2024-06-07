IPaymentGatewayFactory paymentGatewayFactory = new PayPalPaymentGatewayFactory();
IPaymentGateway paymentGateway = paymentGatewayFactory.CreatePaymentGateway();
paymentGateway.ProcessPayment(new Order("10",1500000));


//=================================//
public interface IPaymentGateway
{
    void ProcessPayment(Order order);
}
public class PayPalPaymentGateway : IPaymentGateway
{
    public void ProcessPayment(Order order)
    {
        // پردازش پرداخت از طریق درگاه PayPal
    }
}

public class StripePaymentGateway : IPaymentGateway
{
    public void ProcessPayment(Order order)
    {
        // پردازش پرداخت از طریق درگاه Stripe
    }
}

//=================================//
public interface IPaymentGatewayFactory
{
    IPaymentGateway CreatePaymentGateway();
}
public class PayPalPaymentGatewayFactory : IPaymentGatewayFactory
{
    public IPaymentGateway CreatePaymentGateway()
    {
        return new PayPalPaymentGateway();
    }
}

public class StripePaymentGatewayFactory : IPaymentGatewayFactory
{
    public IPaymentGateway CreatePaymentGateway()
    {
        return new StripePaymentGateway();
    }
}
//=================================//


public class Order
{
    public string OrderId { get; set; }
    public decimal Amount { get; set; }
    // دیگر ویژگی های سفارش

    public Order(string orderId, decimal amount /*, other properties */)
    {
        OrderId = orderId;
        Amount = amount;
        // مقداردهی دیگر ویژگی های سفارش
    }
}