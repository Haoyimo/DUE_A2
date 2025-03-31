using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject player;
    public float value = 0f;
    public Vector3 sizeChange;

    public void MoveLeft()
    {
        value = value - 10f;
        player.transform.position = new Vector3(value-43,-39,106);
    }

    public void MoveRight()
    {
        value = value + 10f;
        player.transform.position = new Vector3(value-43,-39,106);
    }

    public void RotateLeft()
    {
        player.transform.Rotate(0f,5f,0f);
    }

    public void RotateRight()
    {
        player.transform.Rotate(0f,-5f,0f);
    }

    public void Grow()
    {
        player.transform.localScale = player.transform.localScale + sizeChange;
    }

    public void Smaller()
    {
        player.transform.localScale = player.transform.localScale - sizeChange;
    }

    public void ResetObject()
    {
        player.transform.position = new Vector3(-43,-39,106);
        player.transform.rotation = Quaternion.Euler(new Vector3(0, -90, 0));
        player.transform.localScale = new Vector3(1,1,1);
    }
}
