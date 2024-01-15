using System;

namespace Lab5
{
    internal class CustomType : ICloneable
    {
        public int IntValue;
        public string StringValue;

        public CustomType(int intValue, string stringValue)
        {
            IntValue = intValue;
            StringValue = stringValue;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
