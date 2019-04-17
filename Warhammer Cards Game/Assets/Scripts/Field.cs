using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Field : MonoBehaviour {
    public GameObject enemy;
    void NewCard()
    {
            for (int i = 0; i < 5; i++)
            {
                Instantiate(enemy);
            }
    }
}
