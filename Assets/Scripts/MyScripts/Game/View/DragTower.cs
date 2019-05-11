using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DragTower : MonoBehaviour
{
    public GameObject _circle;
    public towerScript _towerScript;
    public GameObject _gameobject;

    public bool _selected;

    public bool _build;

    public float oldTime;

    public int _id;
    
    // Start is called before the first frame update
    void Start()
    {
        _circle.transform.localScale = new Vector2((_towerScript.range - 2) * 0.5f + 1, (_towerScript.range - 2) * 0.5f + 1);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z - 10);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            _selected = false;
            oldTime = Time.time;
        }
        if (_selected)
        {
            Vector2 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(cursorPosition.x, cursorPosition.y, transform.position.z);
        }

        if (_id == 0 & Time.time - oldTime > 0.01f && !_selected)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (_id == 1)
        {
            return;
        }
        if (!_selected && !_build)
        {
            if (other.gameObject.tag.Equals("empty"))
            {
                _build = true;
                Instantiate(_gameobject, new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z - 1), Quaternion.identity);
                other.gameObject.tag = "tower";
                gameManager.gm.playerEnergy -= _towerScript.energy;
                Destroy(gameObject);
            }
        }

        if (!_selected && !other.gameObject.tag.Equals("empty"))
        {
            Destroy(gameObject);
        }
    }
}
