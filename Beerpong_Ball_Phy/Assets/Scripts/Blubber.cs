using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blubber : MonoBehaviour
{
    [SerializeField] private float blubberSuccumbsToObesityIn = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, blubberSuccumbsToObesityIn);   
    }
}
