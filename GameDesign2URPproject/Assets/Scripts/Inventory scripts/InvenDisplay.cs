using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvenDisplay : MonoBehaviour
{
    public int indexNum;
    public InvenData invenData;
    public List<InvenImageIndex> invenImages = new List<InvenImageIndex>();
    void Start()
    {
       
    }

    void Update()
    {
        Display(0);
        Display(1);
        Display(2);
        Display(3);
        Display(4);
        Display(5);
        Display(6);
    }
    void Display(int index){
        if (invenData.invenItems.Count > index){
            invenImages[index].invenIcon = invenData.invenItems[index].icon;
            invenImages[index].image.color = new Color(1,1,1,1);
        }
         else { 
            invenImages[index].image.color = new Color(0,0,0,0);
            invenImages[index].invenIcon = null;
        }
    }
}
