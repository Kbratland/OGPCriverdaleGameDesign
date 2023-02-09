using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXscript : MonoBehaviour
{
    AudioSource m_AudioSource;
    // Start is called before the first frame update
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)){
            m_AudioSource.Play();
            Debug.Log($"playing");
        }
    }
}
