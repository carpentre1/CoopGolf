using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMovement : MonoBehaviour
{
    int currentLevel = 0;
    Transform thisLevelStartPosition;

    void Start()
    {

    }

    public void StartNewLevel(GameObject level)
    {

    }

    public void RestartLevel()
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        transform.position = thisLevelStartPosition.position;
    }

}
