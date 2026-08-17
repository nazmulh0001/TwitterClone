using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public Guid? ModifiedAt { get; private set; }
        public DateTime CreatedBy { get; private set; }
        public Guid? ModifiedBy { get; private set; }

        public BaseEntity(Guid id)
        {
            Id = id;
            CreatedAt = DateTime.UtcNow;
        }

        public virtual string DescribeRecord()
        {
            return $"Base Id: {Id}; Created at: {CreatedAt}; Modified at: {ModifiedAt}; Created by: {CreatedBy}; Modified by: {ModifiedBy};";
        }

    }
}
