using UnityEngine;
using UnityEngine.UI;

public class ResultPlayerNameInput :MonoBehaviour
{
	public InputField inputName;

	public void Save()
	{
		PlayerPrefs.SetString("Name", inputName.text);
	}


}