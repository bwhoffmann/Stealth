using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform tf;
    public float turnSpeed = 110f; //sets base turn speed, can be changed
    public float moveSpeed = 5f; //sets base move speed, can be changed
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.player = this.gameObject;
        tf = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        HandleRotation();
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            tf.Translate(Vector3.right * moveSpeed * Time.deltaTime, Space.Self); //Moves player forward in the direction faced
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            tf.Translate(Vector3.left * moveSpeed * Time.deltaTime / 2, Space.Self); //Moves player forward in the direction faced
        }
    }
    public void HandleRotation()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            tf.Rotate(0, 0, turnSpeed * Time.deltaTime); //Rotates player left when pressing left arrow
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            tf.Rotate(0, 0, -turnSpeed * Time.deltaTime); //Rotates player right when pressing right arrow
        }
    }


}
