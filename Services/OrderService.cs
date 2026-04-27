using OrderApi.Models;

namespace OrderApi.Services;

public class OrderService
{
    private readonly List<Order> _orders = new();

    public List<Order> GetAll() => _orders;

    public void Add(Order order)
    {
    if (order.Amount <= 0)
        throw new Exception("Invalid amount");

    order.Id = _orders.Count + 1;
    _orders.Add(order);
    }
}