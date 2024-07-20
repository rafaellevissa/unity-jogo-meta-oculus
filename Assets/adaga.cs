using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class adaga : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rigidBody;
    public bool cravado;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("alvo") && !cravado){
            Debug.LogWarning("colidiu!!!!!!!!!!!");            
            if(rigidBody.velocity.magnitude > 0.5){                                
                CravarFaca(collision.contacts[0]);
            }
        }
    }

    void OnCollisionStay(Collision collision) {        
        if (collision.gameObject.CompareTag("alvo")){
            Debug.LogWarning("colidindo!!!!!!!!!!!"); 
            cravado=true;
            rigidBody.constraints=RigidbodyConstraints.FreezeAll;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        Debug.LogWarning("descolidiu!!!!!!!!!!!"); 
        if (collision.gameObject.CompareTag("alvo")){
            cravado=false;
            rigidBody.isKinematic=false;
            rigidBody.useGravity=true;
            rigidBody.constraints=RigidbodyConstraints.None;
        }
    }

    void CravarFaca(ContactPoint contactPoint){
        cravado=true;
        rigidBody.isKinematic=true;
        transform.position=contactPoint.point;
        rigidBody.useGravity=false;
    }
}
