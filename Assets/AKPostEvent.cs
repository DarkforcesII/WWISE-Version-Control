using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AKPostEvent : MonoBehaviour
{

    [SerializeField] AK.Wwise.Event Music;

    // Start is called before the first frame update
    void Start()
    {
        Music.Post(gameObject);
        print("it works");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
