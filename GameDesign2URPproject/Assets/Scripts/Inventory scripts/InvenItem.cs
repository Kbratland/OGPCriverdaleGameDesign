using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InvenItem : MonoBehaviour
{
    public string itemName;
    public Sprite icon;
    public float weight;
    public GameObject itemPrefab;
    public float eTime = 0;
    public bool grabbed = false;
    //public InvenData invenData;
    // Start is called before the first frame update
    void Start()
    {
        eTime = 0;
        // bool grabbed = false;
    }
    void OnEnable()
    {
        if(grabbed){
            Destroy(this.gameObject);
        }
        grabbed = false;
        eTime = 0;
        // Debug.Log("enabled");
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log($"Item updating");
        eTime += Time.deltaTime;
    }
    

}
