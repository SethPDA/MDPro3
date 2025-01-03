using System.Data;

namespace YGOSharp.OCGWrapper
{
    public class NamedCard : Card
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        internal NamedCard(IDataRecord reader) : base(reader)
        {
            Name = reader.GetString(10);
            Description = reader.GetString(11);
        }

        public static new NamedCard Get(int id)
        {
            return NamedCardsManager.GetCard(id);
        }

        public bool HasSetcode(int setcode)
        {
            long num = setcode;
            int num2 = setcode & 0xFFF;
            int num3 = setcode & 0xF000;
            while(num > 0)
            {
                long num4 = num & 0xFFFF;
                num >>= 16;
                if((num4 & 0xFFF) == num2 && (num4 & 0xF000 & num3) == num3)
                    return true;
            }
            return false;
        }
    }
}
