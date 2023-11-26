using SistemaFinanceiro.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Domain.Entities
{
    public abstract class BaseEntity : IBaseEntity
    {
        public BaseEntity()
        {
            Id = System.Guid.NewGuid();
            //CreateAt = CreateAt ?? DateTime.Now;
        }

        public Guid Id { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }



        public override bool Equals(object obj)
        {
            var compareTo = obj as BaseEntity;

            if (ReferenceEquals(this, compareTo)) return true;
            if (ReferenceEquals(null, compareTo)) return false;

            return Id.Equals(compareTo.Id);
        }

        public static bool operator ==(BaseEntity a, BaseEntity b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(BaseEntity a, BaseEntity b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }

        public override string ToString()
        {
            return GetType().Name + " [Id=" + Id + "]";
        }
    }
}
