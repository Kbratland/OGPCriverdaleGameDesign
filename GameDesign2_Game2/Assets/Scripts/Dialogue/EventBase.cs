using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventBase : MonoBehaviour
{
Ray ray;
RaycastHit hitData;
float hitDistance;
Vector3 hitPosition;
string tag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(ray,out hitData)){

        }
        ray = Camera.main.ViewportPointToRay(new Vector3 (0.5f, 0.5f, 0));
        hitPosition = hitData.point;
        hitDistance = hitData.distance;
        Debug.Log(hitData.collider.gameObject.tag);
    }
}
