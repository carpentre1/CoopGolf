using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallBelowLevel : MonoBehaviour
{
    [Tooltip("How far the ball must fall below the level's starting point to reset")]
    public float YLimit = -2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.transform.position.y < YLimit)
        {
            gameObject.GetComponent<LevelMovement>().RestartLevel();
        }
    }
}
