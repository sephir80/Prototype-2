using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float sendDogRate=2.0f;
    private float timeElapsed=0f;
    // Update is called once per frame
    void Update()
    {

         // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)&&(timeElapsed<=0))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timeElapsed=sendDogRate;
        }
        timeElapsed-=Time.deltaTime;
        Debug.Log("time elapsed = "+timeElapsed.ToString());
    }

}
