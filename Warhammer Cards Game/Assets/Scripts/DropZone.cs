using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropZone : MonoBehaviour, IDropHandler {
    public GameObject prefab;
    public Material prefab1;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log(eventData.pointerDrag.name + " was dropped on " + gameObject.name);
        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null)
        {
            d.parentToReturnTo = this.transform;
            Debug.Log(d.name + "_on");
            prefab = GameObject.Find(d.name + "_on");
            Destroy(d.gameObject);
            Destroy(GameObject.Find("New Game Object")); 
             Vector3 position = new Vector3(0, 0.01f, -1.25f);
            Quaternion rotation = new Quaternion(1, 180, 1, 1);
            GameObject obj = Instantiate(prefab, position, rotation) as GameObject;
            obj.transform.localScale = new Vector3(0.07f, 0.1f, 0.1f);
        }
    }
    
}
