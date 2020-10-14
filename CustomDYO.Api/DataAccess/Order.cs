using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string OrderNumber { get; set; }
        public string Ponumber { get; set; }
        public string OrderType { get; set; }
        public string OrderNote { get; set; }
        public string OrderName { get; set; }
        public string JobSheetFile { get; set; }
        public string JobSheetShippingDetailFile { get; set; }
        public byte OrderStatusId { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public int CreatedBy { get; set; }
        public int? OrderAddressId { get; set; }
        public int? SalesCordinator { get; set; }
        public int? Mechandiser { get; set; }
        public int? WarehouseUserId { get; set; }
        public DateTime? ExpectedDeliveryOnUtc { get; set; }
        public DateTime? PickupRequestedOnUtc { get; set; }
        public DateTime? DispatchedOnUtc { get; set; }
        public string PickupNoteFile { get; set; }
        public string UpdatedPickupNoteFile { get; set; }
        public bool? IsPickUpComplete { get; set; }
        public string ShipmentType { get; set; }
        public string DispatchNoteFile { get; set; }
        public byte? DelivieryMethodId { get; set; }
        public int? ConsumerId { get; set; }
        public int? ModifyDays { get; set; }
        public DateTime? RequestedDeliveryDate { get; set; }
        public DateTime? RequestedExFactoryDate { get; set; }
        public DateTime? ConfirmedExFactoryDate { get; set; }
    }
}
