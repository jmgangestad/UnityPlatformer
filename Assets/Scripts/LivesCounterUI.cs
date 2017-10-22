using UnityEngine;
using UnityEngine.UI;

public class LivesCounterUI : MonoBehaviour {


    private Text livesText;


	void Awake () {
        livesText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        livesText.text = "LIVES: " + GameMaster.RemainingLives.ToString();
	}
}
