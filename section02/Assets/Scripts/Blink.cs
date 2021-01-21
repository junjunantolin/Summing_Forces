 using UnityEngine;
 using System.Collections;
 using UnityEngine.UI;
 using UnityEngine.EventSystems;
 
 public class Blink : MonoBehaviour {
 
  public float timer;
     public GameObject Tap;
     void exit()
     {
         if (Input.touchCount > 0)
         {
           Tap.SetActive(false);
         }
     
 
         }
 
     void Update()
     {
         timer = timer + Time.deltaTime;
         if(timer >= 0.5)
         {
                 GetComponent<Text>().enabled = true;
         }
         if(timer >= 1)
         {
                 GetComponent<Text>().enabled = false;
                 timer = 0;
         }
 
     }
 
 }