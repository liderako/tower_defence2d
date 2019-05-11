using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scopeLogic : MonoBehaviour
{
    public GameObject _panelVictory;
    public GameObject _panelGameOver;
    public GameObject gm1;
    public GameObject gm2;
    public GameObject gm3;
    public GameObject enemy;
    public int[] _levelHp;
    public int[] _levelEnergy;
    
    public static scopeLogic _sp;
    
    void Awake () {
        if (_sp == null)
            _sp = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        _levelHp = new int[3];
        _levelEnergy = new int[3];
        _levelHp[0] = gameManager.gm.playerMaxHp;
        _levelHp[1] = gameManager.gm.playerMaxHp / 2;
        _levelHp[2] = gameManager.gm.playerMaxHp / 4;
        _levelEnergy[0] = 300;
        _levelEnergy[1] = 200;
        _levelEnergy[2] = 100;
    }

    void Update()
    {
        if (gameManager.gm.lastWave)
        {
            _panelVictory.SetActive(true);
            gm1.SetActive(true);
            gm2.SetActive(true);
            gm3.SetActive(true);
            enemy.SetActive(false);
        }

        if (gameManager.gm.playerHp <= 0)
        {
            _panelGameOver.SetActive(true);
            gm1.SetActive(true);
            gm2.SetActive(true);
            gm3.SetActive(true);
            enemy.SetActive(false);
        }
    }
    
    public string getStatus()
    {
        if (gameManager.gm.playerHp == gameManager.gm.playerMaxHp - gameManager.gm.playerMaxHp)
        {
            return "C--";
        }
        if (gameManager.gm.playerHp >= _levelHp[0] && gameManager.gm.playerEnergy >= _levelEnergy[0])
        {
            return "A++";
        }
        
        if (gameManager.gm.playerHp >= _levelHp[0] && gameManager.gm.playerEnergy >= _levelEnergy[1])
        {
            return "A";
        }
        
        if (gameManager.gm.playerHp >= _levelHp[0] && gameManager.gm.playerEnergy >= _levelEnergy[2])
        {
            return "B++";
        }
        
        if (gameManager.gm.playerHp >= _levelHp[1])
        {
            return "B";
        }
        
        if (gameManager.gm.playerHp >= _levelHp[2])
        {
            return "B--";
        }
        
        return "C";
    }
}
