using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dancar : MonoBehaviour
{
    public Animator robot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    {
        
    }
    public void dancarFuncao(){
        robot.SetTrigger("dancar");
    }
}
