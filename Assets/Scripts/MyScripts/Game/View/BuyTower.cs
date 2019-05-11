using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BuyTower : MonoBehaviour
{
    public towerScript _towerScript; 
    public GameObject _spawn;
    public GameObject _copy;
    public bool activeBuy;
    public bool _selected;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (activeBuy)
        {
            if (_selected)
            {
                _copy = Instantiate(_spawn, Input.mousePosition, Quaternion.identity);
                _copy.transform.parent = transform.parent;
                _copy.transform.localScale = new Vector2(_spawn.transform.localScale.x, _spawn.transform.localScale.y);
                _copy.GetComponent<DragTower>()._selected = true;
                _copy.GetComponent<DragTower>()._id = 0;
                _selected = false;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            _selected = false;
        }
    }

    void LateUpdate()
    {
        if (gameManager.gm.playerEnergy < _towerScript.energy)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            activeBuy = false;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.white;
            activeBuy = true;
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _selected = true;
        }
    }
}
