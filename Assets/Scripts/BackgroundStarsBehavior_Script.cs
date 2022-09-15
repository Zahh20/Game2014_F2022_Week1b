using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundStarsBehavior_Script : MonoBehaviour
{
    //Float Variables.
    public float verticalSpeed;

    //Struct.
    public Boundary_Script boundary;


    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    void Update()
    {
        MoveBackground();
        CheckBounds();
    }

    //Moves the background.
    public void MoveBackground()
    {
        transform.position -= new Vector3(0.0f, verticalSpeed) * Time.deltaTime;
    }

    //Checks the min and/or max of a position.
    public void CheckBounds()
    {
        if(transform.position.y < boundary.min)
        {
            ResetBackgroundStars();
        }
    }

    //Resets the Space Stars background.
    public void ResetBackgroundStars()
    {
        transform.position = new Vector2(0.0f, boundary.max);
    }
}
