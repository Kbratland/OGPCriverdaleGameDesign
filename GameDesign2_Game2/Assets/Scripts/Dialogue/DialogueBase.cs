using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueBase : MonoBehaviour
{
    public DialogueBase dialogueBase;
    public AI_Manager aI_Manager;
    public int weightOpinion;
    public int weightTrust;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Option1 (){
        //good with bad trust
        aI_Manager.OpinionUp(weightOpinion);
        aI_Manager.TrustDown(weightTrust);
    }
    public void Option2(){
        //good ith good trust
        aI_Manager.OpinionUp(weightOpinion);
        aI_Manager.TrustUp(weightTrust);
    }
    public void Option3(){
        //bad with bad trust
        aI_Manager.OpinionDown(weightOpinion);
        aI_Manager.TrustDown(weightTrust);
    }
    public void Option4(){
        //bad with good trust
        aI_Manager.OpinionDown(weightOpinion);
        aI_Manager.TrustUp(weightTrust);
    }
    public void NeutralOption(){

    }
}
