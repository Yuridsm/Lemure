using System;

namespace Lemure.OOP.Delegates;

public class PlayFavoriteMusic
{
    public string play(string music)
    {
        if (music == "Ela vem".ToLower())
            return "Ela vem - Biu do Piseiro...";
        return "Não há música na playlist";
    }

    public static string next()
    {
        return "Virgem - Biu do Piseiro...";
    }
}
