using System.Drawing;

namespace Menagelec.Data;

public static class Constants
{
    public static LoginType[] PossibleLogin =
    {
        new()
        {
            Login = "fournier",
            Password = "1234"
        },
        new()
        {
            Login = "hurier",
            Password = "5678"
        }
    };

    public static readonly Color DisplayStandardColor = Color.FromArgb(223, 80, 0);
    public static readonly Color DisplaySearchSpecificColor = Color.FromArgb(128, 0, 128);
}