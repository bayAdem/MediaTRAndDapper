﻿using MediaTRAndDapper.Models.BaseEntity;

namespace MediaTRAndDapper.Models
{
    public class Customer : BaseEntity<int>
    {
        public string FullName { get; set; } 
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<Order> Orders { get; set; }

    }


}
 