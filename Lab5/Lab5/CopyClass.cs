using System;
using Newtonsoft.Json;

namespace Lab5
{
    internal class CopyClass
    {
        public T Copy<T>(T obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "Parametr nie może być null.");
            }

            if (obj is ICloneable)
            {
                return (T)((ICloneable)obj).Clone();
            }
            else
            {
                throw new ArgumentException("Typ obiektu nie implementuje interfejsu ICloneable.", nameof(obj));
            }
        }
    }
}
