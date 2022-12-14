using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvenItem : MonoBehaviour
{
    public string itemName;
    public Sprite icon;
    public int weight;
    public GameObject itemPrefab;
    public float eTime = 0;
    public bool grabbed = false;
    //public InvenData invenData;
    // Start is called before the first frame update
    void Start()
    {
        eTime = 0;
    }
    void OnEnable()
    {
        eTime = 0;
        if(grabbed){
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        eTime += Time.deltaTime;
    }
    

}
