using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;

public class BallControl : MonoBehaviour
{
    // The Rewired player id of this character
    public int playerId = 0;

    //The Rewired player
    private Player player;

    private bool launchBall;

    private void Awake()
    {
        // Get the Rewired Player object for this player and keep it for the duration of the character's lifetime
        player = ReInput.players.GetPlayer(playerId);
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
        ProcessInput();
    }

    void GetInput()
    {
        launchBall = player.GetButtonDown("LaunchBall");
    }

    void ProcessInput()
    {
        if(launchBall)
        {
            //launch the ball
        }
    }

    void LaunchBall()
    {

    }
}
