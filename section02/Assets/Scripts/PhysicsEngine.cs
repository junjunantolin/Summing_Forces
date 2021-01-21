using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsEngine : MonoBehaviour
{
    public float mass;
    public GameObject StatusGood;
    public GameObject StatusBad;
    public Vector3 velocityVector; //average velocity this fixed update()
    public Vector3 netForceVector;
    public List<Vector3> forceVectorList = new List<Vector3>(); 

    void Start()
    {
        StatusBad.SetActive(false);
        StatusGood.SetActive(true);
    }

    
    void FixedUpdate()
    {
        AddForces();
        UpdateVelocity();
        if (netForceVector == Vector3.zero)
        {
            transform.position += velocityVector * Time.deltaTime;
            
        }else{
            StatusGood.SetActive(false);
            StatusBad.SetActive(true);
        }
        //transform.position += vectorVelocity * Time.deltaTime;
    }

    void UpdateVelocity(){
        Vector3 accelerationVector = netForceVector / mass;
        velocityVector += accelerationVector * Time.deltaTime;
    }

    void AddForces(){
        netForceVector = Vector3.zero;

        foreach (Vector3 forceVector in forceVectorList){
            netForceVector += forceVector;
        }
    }
}
