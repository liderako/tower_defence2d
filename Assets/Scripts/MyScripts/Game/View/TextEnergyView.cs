using UnityEngine;
using UnityEngine.UI;

public class TextEnergyView : MonoBehaviour
{
    void Update()
    {
        GameObject.Find("TextEnergy").gameObject.GetComponent<Text>().text = gameManager.gm.playerEnergy.ToString();
    }
}
