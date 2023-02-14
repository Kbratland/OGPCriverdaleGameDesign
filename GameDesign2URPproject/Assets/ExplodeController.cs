using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeController : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J)){
            // animator.Switch1 = true;
            if(animator != null){
                animator.SetBool("Switch1",true);
                Debug.Log($"animing");
            }
        }
    }
}
