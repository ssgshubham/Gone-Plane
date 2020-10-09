
using System.Collections.Generic;


//Player Data Holder
[System.Serializable]
public class PlayerDataa
{
    public int coins = 0;

}

public static class GameDataMF 
{
	static PlayerDataa playerDataa = new PlayerDataa();

	static GameDataMF()
	{
		LoadPlayerData();

	}

	public static int GetCoins()
	{
		return playerDataa.coins;
	}

	public static void AddCoins(int amount)
	{
		playerDataa.coins += amount;
		SavePlayerData();
	}

	public static bool CanSpendCoins(int amount)
	{
		return (playerDataa.coins >= amount);
	}

	public static void SpendCoins(int amount)
	{
		playerDataa.coins -= amount;
		SavePlayerData();
	}

	static void LoadPlayerData()
	{
		playerDataa = BinarySerializer.Load<PlayerDataa>("player-dataa.txt");
		UnityEngine.Debug.Log("<color=green>[PlayerDataa] Loaded.</color>");
	}

	static void SavePlayerData()
	{
		BinarySerializer.Save(playerDataa, "player-dataa.txt");
		UnityEngine.Debug.Log("<color=magenta>[PlayerDataa] Saved.</color>");
	}
}
