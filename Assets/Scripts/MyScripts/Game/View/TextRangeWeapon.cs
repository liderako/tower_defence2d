using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextRangeWeapon : MonoBehaviour
{
    public towerScript _towerScript; 
    
    void LateUpdate()
    {
        gameObject.GetComponent<UnityEngine.UI.Text>().text = _towerScript.range.ToString();
    }
}
