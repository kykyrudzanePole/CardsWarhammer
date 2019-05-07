using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropZone1 : MonoBehaviour, IDropHandler
{
    public GameObject prefab;
    public Material prefab1;
    string k1;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log(eventData.pointerDrag.name + " was dropped on " + gameObject.name);
        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (k1 == null)
            k1 = "";
        if (d != null && k1 == "")
        {
            k1 = d.name;
            d.parentToReturnTo = this.transform;
            Debug.Log(d.name + "_on");
            prefab = GameObject.Find(d.name + "_on");
            Destroy(d.gameObject);
            Destroy(GameObject.Find("New Game Object"));
            Vector3 position = new Vector3(-0.98f, 0.1f, -0.7f);
            Quaternion rotation = new Quaternion(1, 180, 1, 1);
            GameObject obj = Instantiate(prefab, position, rotation) as GameObject;
            obj.transform.localScale = new Vector3(0.08f, 0.1f, 0.12f);
        }
    }

}
