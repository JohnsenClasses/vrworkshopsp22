using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameGUI : MonoBehaviour
{
    public GameManager manager;
    public Button startButton; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void handleStartButtonPressed()
	{
        manager.startGame();
	}
}
