using System;

namespace ALItemTrader.Domain.Identifiers
{
    [Serializable]
    public abstract class TypedId : IFormattable, IComparable, IComparable<Guid>, IEquatable<Guid>
    {
        protected TypedId()
        {
            Id = Guid.NewGuid();
        }
        
        private Guid Id { get; }

        public override string ToString()
        {
            return Id.ToString();
        }
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return Id.ToString();
        }
        public int CompareTo(object obj)
        {
            return Id.CompareTo(obj);
        }
        public int CompareTo(Guid other)
        {
            return Id.CompareTo(other);
        }
        public bool Equals(Guid other)
        {
            return Id.Equals(other);
        }
    }
}
