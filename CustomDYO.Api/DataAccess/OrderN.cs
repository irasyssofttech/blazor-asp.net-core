using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class OrderN
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int ConsumerId { get; set; }
        public byte? DelivieryMethodId { get; set; }
        public int? ModifyDays { get; set; }
        public byte OrderStatusId { get; set; }
        public int? OrderAddressId { get; set; }
        public int? SalesCordinatorId { get; set; }
        public int? MechandiserId { get; set; }
        public int? WarehouseUserId { get; set; }
        public string OrderNumber { get; set; }
        public string Ponumber { get; set; }
        public string OrderType { get; set; }
        public string OrderNote { get; set; }
        public string OrderName { get; set; }
        public string JobSheetFile { get; set; }
        public string JobSheetShippingDetailFile { get; set; }
        public string PickupNoteFile { get; set; }
        public string UpdatedPickupNoteFile { get; set; }
        public string DispatchNoteFile { get; set; }
        public DateTime? ExpectedDeliveryOnUtc { get; set; }
        public DateTime? PickupRequestedOnUtc { get; set; }
        public DateTime? DispatchedOnUtc { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public bool? IsPublic { get; set; }
        public bool? IsActive { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
