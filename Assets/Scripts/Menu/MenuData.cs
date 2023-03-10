using System.Collections.Generic;

public enum Theme
{
    Classic,
    Soccer,
    Minecraft,
    Music,
}

public enum Players
{
    OnePlayer,
    TwoPlayer,
}

public enum GameMode
{
    Endless,
    Score,
}

public static class MenuData
{
    public static Dictionary<Theme, string> ThemeDescription = new()
    {
        { Theme.Classic, "Classic" },
        { Theme.Soccer, "Soccer" },
        { Theme.Minecraft, "Minecraft" },
        { Theme.Music, "Music" },
    };

    public static Dictionary<Players, string> PlayersDescription = new()
    {
        { Players.OnePlayer, "One Player" },
        { Players.TwoPlayer, "Two Player" },
    };

    public static Dictionary<GameMode, string> GameModeDescription = new()
    {
        { GameMode.Endless, "Endless" },
        { GameMode.Score, "To Score" }
    };
}
