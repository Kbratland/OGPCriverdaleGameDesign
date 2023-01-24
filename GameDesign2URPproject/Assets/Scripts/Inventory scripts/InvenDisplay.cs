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
        invenImages[0].invenIcon = invenData.invenItems[0].icon;
    }
}
