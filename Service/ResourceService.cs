using System.Drawing;
using System.Windows.Forms;

namespace Menagelec.Service;

public static class ResourceService
{
    private static readonly string ProductsImagePath = Application.StartupPath + "/products";

    public static Image GetProductImage(string name)
    {
        return Image.FromFile(string.Join("/", ProductsImagePath, name));
    }
}