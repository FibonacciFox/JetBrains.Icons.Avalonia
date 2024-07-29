using System.Runtime.CompilerServices;

namespace JetBrains.Icons;

/// <summary>
/// Allows retrieving data for icons
/// </summary>
public partial class JetBrainsIconDataProvider
{
    private static JetBrainsIconDataProvider _instance = new();

    public static JetBrainsIconDataProvider Instance
    {
        get => _instance;
        set { _instance = value ?? throw new ArgumentNullException(nameof(value)); }
    }

    public static List<JetBrainsIconData> GetData(JetBrainsIconKind kind) => Instance.ProvideData(kind);
    public virtual partial List<JetBrainsIconData> ProvideData(JetBrainsIconKind kind);
}

public partial class JetBrainsIconDataProvider
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public virtual partial List<JetBrainsIconData> ProvideData(JetBrainsIconKind kind)
    {
        return kind switch
        {
            JetBrainsIconKind.addFile => new List<JetBrainsIconData>
            {
                new("avares://JetBrains.Icons/Assets/Icons/addFile.svg")
            },
            JetBrainsIconKind.propertyReadStatic => new List<JetBrainsIconData>
            {
                new("avares://JetBrains.Icons/Assets/Icons/propertyReadStatic.svg")
            },
            // Добавьте остальные иконки здесь
            _ => new List<JetBrainsIconData>()
        };
    }
}