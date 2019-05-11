using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSpeed : MonoBehaviour
{
    private void Start()
    {
        GameObject.Find("TextSpeedGame").gameObject.GetComponent<Text>().text = "Click play to Start";
        GameObject.Find("TextSpeedGame").gameObject.GetComponent<Text>().fontSize = 5;
        gameManager.gm.changeSpeed(0);
    }

    void Update()
    {
        if (GameObject.Find("TextSpeedGame").gameObject.GetComponent<Text>().text.Equals("Click play to Start"))
        {
            gameManager.gm.changeSpeed(0);
        }
    }

    public void onClickPause()
    {
        GameObject.Find("TextSpeedGame").gameObject.GetComponent<Text>().text = "Pause";
        GameObject.Find("TextSpeedGame").gameObject.GetComponent<Text>().fontSize = 10;
        gameManager.gm.changeSpeed(0);
    }
    
    public void onClickPlay()
    {
        GameObject.Find("TextSpeedGame").gameObject.GetComponent<Text>().text = "Speed : 1x";
        GameObject.Find("TextSpeedGame").gameObject.GetComponent<Text>().fontSize = 10;
        gameManager.gm.changeSpeed(1);
    }
    
    public void onClickPlayFast()
    {
        GameObject.Find("TextSpeedGame").gameObject.GetComponent<Text>().text = "Speed : 2x";
        GameObject.Find("TextSpeedGame").gameObject.GetComponent<Text>().fontSize = 10;
        gameManager.gm.changeSpeed(2);
    }
    
    public void onClickPlayFastHard()
    {
        GameObject.Find("TextSpeedGame").gameObject.GetComponent<Text>().text = "Speed : 16x";
        GameObject.Find("TextSpeedGame").gameObject.GetComponent<Text>().fontSize = 10;
        gameManager.gm.changeSpeed(16);
    }
}
