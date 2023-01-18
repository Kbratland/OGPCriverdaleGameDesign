using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class InvenData : MonoBehaviour
{
    public List <InvenItem> invenItems = new List<InvenItem>();
    public TMP_Text itemDisplayText;
    public int itemCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    public void invenDisplay(){
        if ((invenItems.Count) != 0){
            itemDisplayText.text = "Latest item is " + invenItems[invenItems.Count - 1].itemName + " You have " + itemCount + " Items";
        }
        else{
            itemDisplayText.text = "";
        }

    }
}
