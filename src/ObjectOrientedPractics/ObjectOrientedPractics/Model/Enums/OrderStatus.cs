namespace ObjectOrientedPractics.Model.Enums
{
    /// <summary>
    /// Хранит перечисление, описывающее состояние заказа в процессе его выполнения.
    /// </summary>
    public enum OrderStatus
    {
        New,
        Processing,
        Assembly,
        Sent,
        Delivered,
        Returned,
        Abandoned
    }
}
