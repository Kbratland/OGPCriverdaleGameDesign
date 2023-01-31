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
        if(invenData.invenItems[index].icon != null)
        {
            invenImages[index].invenIcon = invenData.invenItems[index].icon;
            var tempColor = invenImages[index].image.color;
            tempColor.a = 1f;
            invenImages[index].image.color = tempColor;
        }
        else 
        {
            var tempColor = invenImages[index].image.color;
            tempColor.a = 0f;
            invenImages[index].image.color = tempColor;
            invenImages[index].image = null;
        }
    }
}
