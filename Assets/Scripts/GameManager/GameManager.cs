using UnityEngine;

public enum Players
{
    Fox = 0,
    Flog
}
public class GameManager : MonoBehaviour
{
	PlayerPrefs playerPrefs;

	public static GameManager instance;

	private void Awake()
	{
		if (instance == null) instance = this;
		else if (instance != null) return;
		DontDestroyOnLoad(gameObject);
	}
	public Players currentPlayer;

}