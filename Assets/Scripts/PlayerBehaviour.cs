using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    //Floats.
    public float speed = 10.0f;
    public float verticalPosition;

    //Structs.
   public Boundary_Script boundary_Script;


    // Update is called once per frame
    void Update()
    {
        Move();

        //CheckBounds();
    }

    //Player movements.
    public void Move()
    {
        float x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;//Goes left and right.
        //float y = Input.GetAxisRaw("Vertical") * Time.deltaTime * speed;//Up and down.

        transform.position += new Vector3(x, 0.0f, 0.0f);

        float clampedPosition = Mathf.Clamp(transform.position.x, boundary_Script.min, boundary_Script.max);

        transform.position = new Vector2(clampedPosition, verticalPosition);//Same thing as CheckBounds, but much shorter code.
    }

    //public void CheckBounds()
    //{
    //    if(transform.position.x > boundary_Script.max)
    //    {
    //        transform.position = new Vector2(boundary_Script.max, verticalPosition);
    //    }

    //    if(transform.position.x < boundary_Script.min)
    //    {
    //        transform.position = new Vector2(boundary_Script.min, verticalPosition);
    //    }
    //}
}
