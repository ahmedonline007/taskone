﻿using System; 

namespace TaskContext.Entities
{
    public class BaseEntity
    {
        public Guid? Id { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
