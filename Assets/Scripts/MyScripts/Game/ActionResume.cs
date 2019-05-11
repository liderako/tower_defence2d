using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionResume : MonoBehaviour
{
    public GameObject _backgroundPanel;

    public GameObject _resume;
    
    public GameObject _exit;

    public ActionExitGame actionExitGame;


    void Update()
    {
        
    }
    
    public void onClickAction()
    {
        gameManager.gm.pause(false);
        _backgroundPanel.SetActive(false);
        _resume.SetActive(false);
        _exit.SetActive(false);
        actionExitGame.count = 0;
    }
}
