using UnityEngine;

public static class ConfigTimes
{
    private const string TIME1_KEY = "TIME_1_NOME";
    private const string TIME2_KEY = "TIME_2_NOME";
    private const string PONTOS1_KEY = "TIME_1_PONTOS";
    private const string PONTOS2_KEY = "TIME_2_PONTOS";

    // =========================
    // NOMES DOS TIMES
    // =========================
    public static string NomeTime1
    {
        get => PlayerPrefs.GetString(TIME1_KEY, "Time 1");
        set
        {
            PlayerPrefs.SetString(TIME1_KEY, value);
            PlayerPrefs.Save();
        }
    }

    public static string NomeTime2
    {
        get => PlayerPrefs.GetString(TIME2_KEY, "Time 2");
        set
        {
            PlayerPrefs.SetString(TIME2_KEY, value);
            PlayerPrefs.Save();
        }
    }

    // =========================
    // PONTUAÇÃO
    // =========================
    public static int PontosTime1
    {
        get => PlayerPrefs.GetInt(PONTOS1_KEY, 0);
        set
        {
            PlayerPrefs.SetInt(PONTOS1_KEY, value);
            PlayerPrefs.Save();
        }
    }

    public static int PontosTime2
    {
        get => PlayerPrefs.GetInt(PONTOS2_KEY, 0);
        set
        {
            PlayerPrefs.SetInt(PONTOS2_KEY, value);
            PlayerPrefs.Save();
        }
    }

    // =========================
    // RESET GERAL
    // =========================
    public static void ResetarTudo()
    {
        PlayerPrefs.DeleteKey(TIME1_KEY);
        PlayerPrefs.DeleteKey(TIME2_KEY);
        PlayerPrefs.DeleteKey(PONTOS1_KEY);
        PlayerPrefs.DeleteKey(PONTOS2_KEY);
        PlayerPrefs.Save();
    }
}

