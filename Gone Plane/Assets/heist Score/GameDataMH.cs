
using System.Collections.Generic;


//Player Data Holder
[System.Serializable]public class PlayerDaata
{
    public int coins = 0;

}

public static class GameDataMH
{
	static PlayerDaata playerDaata = new PlayerDaata();

	static GameDataMH()
	{
		LoadPlayerData();

	}

	public static int GetCoins()
	{
		return playerDaata.coins;
	}

	public static void AddCoins(int amount)
	{
		playerDaata.coins += amount;
		SavePlayerData();
	}

	public static bool CanSpendCoins(int amount)
	{
		return (playerDaata.coins >= amount);
	}

	public static void SpendCoins(int amount)
	{
		playerDaata.coins -= amount;
		SavePlayerData();
	}

	static void LoadPlayerData()
	{
		playerDaata = BinarySerializer.Load<PlayerDaata>("player-daata.txt");
		UnityEngine.Debug.Log("<color=green>[PlayerDaata] Loaded.</color>");
	}

	static void SavePlayerData()
	{
		BinarySerializer.Save(playerDaata, "player-daata.txt");
		UnityEngine.Debug.Log("<color=magenta>[PlayerDaata] Saved.</color>");
	}

}