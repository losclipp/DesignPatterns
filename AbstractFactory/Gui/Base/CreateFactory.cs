using AbstractFactory.Gui.Mac;
using AbstractFactory.Gui.Windows;

namespace AbstractFactory.Gui.Base;

public static class CreateFactory
{
    public static IGuiFactory GetFactory(OsType osType)
    {
        switch (osType)
        {
            case OsType.Windows: return new WindowsFactory();
            case OsType.Mac: return new MacFactory();
            default: throw new NotImplementedException("Unknown OS type");
        }
    }
}