//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RoomBooking
    {
        public int Bookingid { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddres { get; set; }
        public System.DateTime BookingFrom { get; set; }
        public System.DateTime BookingTo { get; set; }
        public int AssignRoomid { get; set; }
        public int NoOfMembers { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<int> Paymentid { get; set; }
    }
}
