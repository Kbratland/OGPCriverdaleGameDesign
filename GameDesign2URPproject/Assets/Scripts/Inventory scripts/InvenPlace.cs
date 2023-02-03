using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvenPlace : MonoBehaviour
{
    public InvenData invenData;
    public InvenDisplay invenDisplay;
    // Start is called before the first frame update
    void Start()
    {
        invenData = this.gameObject.GetComponent<InvenData>();
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(invenItems[invenItems.Count]);
        // invenData.invenDisplay();
       if(Input.GetKeyDown(KeyCode.T)){
        if(invenData.itemCount >= 0)
        {
        invenDisplay.invenImages[invenData.itemCount].invenIcon = null;
        invenData.itemCount -= 1;
        invenData.weightMax -= invenData.invenItems[invenData.invenItems.Count -1].gameObject.GetComponent<InvenItem>().weight;
        invenData.invenItems[invenData.invenItems.Count - 1].gameObject.SetActive(true);
        invenData.invenItems[invenData.invenItems.Count -1].gameObject.GetComponent<InvenItem>().enabled = true;
        Instantiate(invenData.invenItems[invenData.invenItems.Count - 1].itemPrefab, this.transform.position + this.transform.forward * 4, this.transform.rotation);
        invenData.invenItems.Remove(invenData.invenItems[invenData.invenItems.Count - 1]);
        }
       }
    }
     void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Item") && invenData.weightMax < 18f){
            if(other.gameObject.GetComponent<InvenItem>().eTime >= 1)
            {
            invenData.weightMax += other.gameObject.GetComponent<InvenItem>().weight;
            invenData.itemCount +=1;
            invenData.invenItems.Add(other.gameObject.GetComponent<InvenItem>());
            other.gameObject.GetComponent<InvenItem>().grabbed = true;
            other.gameObject.SetActive(false);
            }
        }
    }
}
