using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о заказе приоритетного обслуживания.
    /// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Дата доставки.
        /// </summary>
        private DateTime _deliveryDate;

        /// <summary>
        /// Время доставки.
        /// </summary>
        private string _deliveryTime;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        public PriorityOrder()
        {

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="orderStatus">Статус заказа.</param>
        /// <param name="address">Адрес.</param>
        /// <param name="items">Товары заказа.</param>
        /// <param name="deliveryDate">Дата доставки.</param>
        /// <param name="deliveryTime">Время доставки.</param>
        public PriorityOrder(int id, OrderStatus orderStatus, Address address, List<Item> items, DateTime deliveryDate,
            string deliveryTime, Cart cart) : base(id, orderStatus, deliveryDate, address, cart)
        {
            DeliveryDate = deliveryDate;
            DeliveryTime = deliveryTime;
        }

        /// <summary>
        /// Возвращает и задает дату доставки. 
        /// </summary>
        public DateTime DeliveryDate
        {
            get => _deliveryDate;
            set => _deliveryDate = value;
        }

        /// <summary>
        /// Возвращает и задает время доставки.
        /// </summary>
        public string DeliveryTime
        {
            get => _deliveryTime;
            set => _deliveryTime = value;
        }
    }
}
