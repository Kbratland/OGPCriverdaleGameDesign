using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public float eTime;
    public float radius = 20f;
    public GameObject player;
    Rigidbody RB;
    public int speed = 4;
    public bool started = true;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        eTime = 0f;
    }
//Vector3.Distance(transform.position, player.transform.position) <= radius
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Y))
        {
            started = true;
        }
        transform.LookAt(player.transform);
        eTime += Time.deltaTime;
        if(eTime > 5f && eTime < 5.25f)
        {
            RB.AddForce(transform.forward * speed);
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Player"){
            Destroy(this.gameObject);
        }
    }
}
