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
    public float delay;
    int projectilesSpawned;
    public int maxProjectiles = 8;
    public float multiplier;
    public bool started = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(started)
        {
            eTime += Time.deltaTime;
        }
        if(started)
        {
            if(eTime > delay && projectilesSpawned < maxProjectiles)
            {
                a = Random.Range(-1f,1f);
                b = Random.Range(-1f,1f);
                c = Random.Range(-1f,1f);
                Instantiate(Projectile, this.transform.position + this.transform.up * 4 + new Vector3(a,b,c), this.transform.rotation);
                eTime = 0;
                projectilesSpawned += 1;
            }
            if(eTime > maxProjectiles * multiplier){
                projectilesSpawned = 0;
                eTime = 0;
            }
        }
    }
}
