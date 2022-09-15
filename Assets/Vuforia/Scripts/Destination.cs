using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destination : MonoBehaviour
{
    public string url;
    // Start is called before the first frame update
    public void OpenDestination(){
        Application.OpenURL(url);
    }
}
