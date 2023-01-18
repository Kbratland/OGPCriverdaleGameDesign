using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBetterJump : MonoBehaviour
{
    public float fallMltiplier = 2.75f;
    public float lowJumpMult = 2f;
    Rigidbody2D rb;
    void Awake() {
    rb = GetComponent<Rigidbody2D>();    
    }
    void Update() {
        if (rb.velocity.y < 0){
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMltiplier - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && !Input.GetKey(KeyCode.Space)){
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMult - 1) * Time.deltaTime;
        }
    }
}
