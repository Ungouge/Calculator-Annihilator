namespace Starter_Library
{
    public interface ISettings_Adapter
    {
        object this[string propertyName] { get; }
    }
}