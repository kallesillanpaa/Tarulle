using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    float speed;
    void Start()
    {
        speed = 5f;
    }


    void Update()
    {
       if (Input.GetKey(KeyCode.Space))
        {
            transform.position += new Vector3(5, 0, 0) * speed * Time.deltaTime;
            //if (transform.position.x >= 5)
            //{
            //    SceneManager.LoadScene(0);
            //}
        } 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("TÖRMÄTTIIN");
        }
    }
}
