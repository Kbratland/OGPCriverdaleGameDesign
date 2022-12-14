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
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(invenItems[invenItems.Count - 1].itemName);
        Debug.Log(invenItems[0].itemName);
       if(Input.GetKeyDown(KeyCode.T)){
        invenItems[invenItems.Count - 1].gameObject.SetActive(true);
        Instantiate(invenItems[invenItems.Count - 1].itemPrefab, this.transform.position + this.transform.forward * 3, this.transform.rotation);
        invenItems[invenItems.Count - 1].gameObject.GetComponent<InvenItem>().grabbed = true;
        invenItems[invenItems.Count - 1].gameObject.SetActive(false);
        invenItems.Remove(invenItems[invenItems.Count - 1]);
       }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Item")){
            if(other.gameObject.GetComponent<InvenItem>().eTime >= 1)
            {invenItems.Add(other.gameObject.GetComponent<InvenItem>());
            other.gameObject.SetActive(false);}
        }
    }
}
