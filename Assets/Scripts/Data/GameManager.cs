using UnityEngine;

public enum Players
{
    Fox = 0,
    Frog
}
public class GameManager : MonoBehaviour
{
    public Players currentPlayer;

    public static GameManager instance;
	private void Awake()
	{
		if (instance == null) instance = this;
		else if (instance != null) return;
		DontDestroyOnLoad(gameObject);
	}
}
