using System;

namespace Lib
{
    public class Good : IEquatable<Good>
    {
        public int Id { get; }
        public string Name { get; }
        public string Producer { get; }
        public int RequiredSpace { get; }

        public Good(int id, string name, string producer, int requiredSpace)
        {
            Id = id;
            Name = name;
            Producer = producer;
            RequiredSpace = requiredSpace;
        }

        public static bool operator ==(Good left, Good right)
        {
            if (left is null)
                return right is null;

            return left.Equals(right);
        }
        
        public static bool operator !=(Good left, Good right) => !(left == right);

        public override bool Equals(object obj)
        {
            var good = obj as Good;

            if (good is null)
                return false;

            return Id == good.Id;
        }

        public bool Equals(Good other) => other != null && Id == other.Id;

        public override int GetHashCode() => HashCode.Combine(Id);
    }
}
