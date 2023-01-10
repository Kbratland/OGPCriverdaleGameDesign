using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvenPlace : MonoBehaviour
{
    public InvenData invenData;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(invenData.itemCount<0){
            invenData.itemCount = 0;
        }
        // Debug.Log(invenItems[invenItems.Count]);
        invenData.invenDisplay();
       if(Input.GetKeyDown(KeyCode.T)){
        if(invenData.itemCount >= 0)
        {
        invenData.itemCount -= 1;
        invenData.itemDisplayText.text = "";
        invenData.invenItems[invenItems.Count - 1].gameObject.SetActive(true);
        invenData.invenItems[invenItems.Count -1].gameObject.GetComponent<InvenItem>().enabled = true;
        Instantiate(invenItems[invenItems.Count - 1].itemPrefab, this.transform.position + this.transform.forward * 4, this.transform.rotation);
        invenData.invenItems.Remove(invenItems[invenItems.Count - 1]);
        }
       }
    }
     void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Item") && invenData.itemCount < 20){
            if(other.gameObject.GetComponent<InvenItem>().eTime >= 1)
            {
            invenData.itemCount += 1;
            invenData.invenItems.Add(other.gameObject.GetComponent<InvenItem>());
            other.gameObject.GetComponent<InvenItem>().grabbed = true;
            other.gameObject.SetActive(false);
            }
        }
    }
}
