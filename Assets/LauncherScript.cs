using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherScript : MonoBehaviour
{
    public List<GameObject> Emitters;

    public void LaunchThemAll(){
        if(Emitters != null){
            // foreach(GameObject emitter in Emitters){
            //     emitter.LaunchLightball();
            // }
        }
    }
}
