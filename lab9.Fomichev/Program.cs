decimal cost = 1500;
decimal discount = 0;
if (cost > 1000 && cost < 2000)
{
    discount = cost * 0.05m;
}
else if (cost >= 2000 && cost < 5000)
{
    discount = cost * 0.1m;
}
decimal finalCost = cost - discount;

Console.WriteLine($"Итоговая стоимость покупки: {finalCost} грн");