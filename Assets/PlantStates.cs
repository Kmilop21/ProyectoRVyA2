using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantStates : MonoBehaviour
{
    
    private Animator plantAnimator;
    
    // Start is called before the first frame update
    void Start()
    {

        plantAnimator = transform.GetChild(0).gameObject.GetComponent<Animator>(); 
    }
    
    public void Small()
    {
        plantAnimator.SetTrigger("Small");
    }
    public void Mid()
    {
        plantAnimator.SetTrigger("Mid");
    }
    public void Max()
    {
        plantAnimator.SetTrigger("Max");
    }
    // Update is called once per frame
    
}
