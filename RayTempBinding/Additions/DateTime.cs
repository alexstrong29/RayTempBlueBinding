using Java.Lang;

namespace UK.CO.Etiltd.Thermalib
{
    public partial class DeviceDateStamp : Object, IComparable
    {
        int IComparable.CompareTo(Object obj)
        {
            return CompareTo((DeviceDateStamp)obj);
        }
    }
}