using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Projectile;
    public float eTime;
    public float a;
    public float b;
    public float c;
    public bool started = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        eTime += Time.deltaTime;
        if(started)
        {
            if(eTime > 4f)
            {
                a = Random.Range(-2f,2f);
                b = Random.Range(-2f,2f);
                c = Random.Range(-2f,2f);
                Instantiate(Projectile, this.transform.position + this.transform.up * 2 + new Vector3(a,b,c), this.transform.rotation);
                eTime = 0;
            }
        }
    }
}
