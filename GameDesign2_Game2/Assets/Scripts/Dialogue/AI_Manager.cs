using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AI_Manager : MonoBehaviour
{
    public TMP_Text TrustScore;
    public TMP_Text OpinionScore;
    int characterOpinion = 0;
    int characterTrust = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TrustScore.text = characterTrust.ToString();
        OpinionScore.text = characterOpinion.ToString();
    }
    public void TrustUp(int trust){
        characterTrust += trust;
    }
    public void TrustDown(int trust){
        characterTrust -= trust;
    }
    public void OpinionUp(int Opinion){
        characterOpinion += Opinion;
    }
    public void OpinionDown(int Opinion){
        characterOpinion -= Opinion;
    }
}
