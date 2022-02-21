using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameGUI : MonoBehaviour
{
    public GameManager manager;
    public Button startButton;
    public GameObject menuPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (!manager.gameStarted)
		{
            menuPanel.SetActive(true);
		}
    }

    public void handleStartButtonPressed()
	{

        StartCoroutine(doGameStart(3));
	}

    IEnumerator doGameStart(float timer)
	{
        startButton.interactable = false;
        Text buttonText = startButton.GetComponentInChildren<Text>();

        while (timer > 0)
        {

            buttonText.text = "" + timer;
            timer -= 1;
            yield return new WaitForSeconds(1);
        }
        
        manager.startGame();
        menuPanel.SetActive(false);
        startButton.interactable = true;
        buttonText.text = "Start";
    }
}
