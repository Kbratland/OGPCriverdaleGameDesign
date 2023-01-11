using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class healthScript : MonoBehaviour
{
    public int health = 10;
    public TMP_Text healthText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "You have " + health + " Health remaining";
        if(health <= 0)
        {
            print("dead");
            SceneManager.LoadScene("Menu");
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "projectile")
        {
            health -= 1;
            Destroy(other.gameObject);
        }
    }
}
