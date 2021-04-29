using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;

    private float positionX;
    private float positionY;


    // Start is called before the first frame update
    void Start()
    {
        positionX = 0;
        positionY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.mousePosition.x / Screen.width * screenWidthInUnits);
        //float mouseX = Input.mousePosition.x / Screen.width * screenWidthInUnits;

        //if (mouseX <0)
        //{
        //    mouseX = 0;
        //}
        //else if (mouseX > 16)
        //{
        //    mouseX = 16;
        //}

        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(GetXPos(), minX, maxX);
        transform.position = paddlePos;
    }
    private float GetXPos()
    {
        if (FindObjectOfType<GameSession>().IsAutoPlayEnabled())
        {
            return FindObjectOfType<Ball>().transform.position.x;
        }
        return Input.mousePosition.x / Screen.width * screenWidthInUnits;
    }
}
