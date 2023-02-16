using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderSwitcher : MonoBehaviour
{
    public GameObject xploder;
    public GameObject player;
    public int radius;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, player.transform.position) <= radius){
            audioSource.Play();
            Instantiate(xploder, this.transform.position, this.transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
