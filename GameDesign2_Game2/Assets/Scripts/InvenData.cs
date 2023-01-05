using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class InvenData : MonoBehaviour
{
    public List <InvenItem> invenItems = new List<InvenItem>();
    public TMP_Text itemDisplayText;
    // Start is called before the first frame update
    void Start()
    {
        itemDisplayText.text = "No items";
    }

    // Update is called once per frame
    void Update()
    {
        invenDisplay();
       if(Input.GetKeyDown(KeyCode.T)){
        Debug.Log("Placed");
        invenItems[invenItems.Count - 1].gameObject.SetActive(true);
        invenItems[invenItems.Count -1].gameObject.GetComponent<InvenItem>().enabled = true;
        Instantiate(invenItems[invenItems.Count - 1].itemPrefab, this.transform.position + this.transform.forward * 4, this.transform.rotation);
        invenItems.Remove(invenItems[invenItems.Count - 1]);
       }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Item")){
            if(other.gameObject.GetComponent<InvenItem>().eTime >= 1)
            {
            invenItems.Add(other.gameObject.GetComponent<InvenItem>());
            other.gameObject.GetComponent<InvenItem>().grabbed = true;
            other.gameObject.SetActive(false);
            }
        }
    }
    void invenDisplay(){
        if ((invenItems.Count) > 0){
            itemDisplayText.text = "Latest item is " + invenItems[invenItems.Count - 1].itemName;
        }
        else{
            itemDisplayText.text = "no items";
        }
    }
}
