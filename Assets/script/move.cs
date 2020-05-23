using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class move : MonoBehaviour
{
   // public Text status;
   // public int count;

    public int playerSpeed = 1;
    // Use this for initialization
    void Start()
    {
      //  status = gameObject.GetComponentInChildren<Text>();
      //  count = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            transform.position = transform.position + Camera.main.transform.forward * playerSpeed *
             Time.deltaTime;
        }
      //  if (count == 0)
    //    {
    //        status.text = "Hurray! :D";
    //    }
     //   else
    //    {
     //       status.text = count + " more to go!";
    //    }

    }
  //  private void OnTriggerEnter(Collider other)
  //  {
  //      if (other.gameObject.CompareTag("coin"))
   //     {
   //         Destroy(other.gameObject);
   //         count--;
   //     }
 //   }

}
