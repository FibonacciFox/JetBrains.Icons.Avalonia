using System.Drawing;

namespace JetBrains.Icons;

public class JetBrainsIconData
{
    public string? Data { get; set; }
    public string? Fill { get; set; }
    public double Opacity { get; set; }
    public Point? Transform { get; set; }

    public JetBrainsIconData(string data, string? fill = null, double opacity = 1.0,
        Point? transform = null)
    {
        Data = data;
        Opacity = opacity;
        Fill = fill;
        Transform = transform;
    }
}