using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmitterScript : MonoBehaviour
{
    [SerializeField] GameObject lightball;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LaunchLightball() {
        for (int i = -40; i < 40; i++){
        Instantiate(lightball, transform.position + new Vector3(0.25f*i,-0.75f,0), Quaternion.identity);
        }
    }

    public void OnMouseDown() {
        if(Input.GetMouseButtonDown(0)){
            LaunchLightball();
        }
    }
}
