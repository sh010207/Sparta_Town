using UnityEngine;

public enum Players
{
    Fox = 0,
    Frog
}
public class GameManager : MonoBehaviour
{
    public Players currentPlayer;
	private string playerName;
	
    public static GameManager instance;

	private void Awake()
	{
		if (instance == null) instance = this;
		else if (instance != null) return;
		DontDestroyOnLoad(gameObject);
	}

	public void CurrentPlayerNameSave(string name)
	{
		playerName = name;
	}

	public string CurrentPlayerNameLoad()
	{
		return playerName;
	}

}
