using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class character : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //    coin.transform.position = cam.ScreenToWorldPoint(new Vector3(coin_target.transform.position.x,
        //           coin_target.transform.position.y, 0));
        //    Vector3 screen_pos = cam.ScreenToWorldPoint(coin.transform.position);
        //    Vector3 screen_pos2 = cam.ScreenToWorldPoint(coin_target.transform.position);
        //    print(screen_pos);
        //    print(screen_pos2);

        //Vector3 screen_pos2 = cam.WorldToScreenPoint(coin_target.transform.position);
        //print(screen_pos2);
       
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
            rb.AddForce(0, 250, 0);

        if (Input.GetKey(KeyCode.RightArrow))
            rb.transform.position += new Vector3(5 * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.LeftArrow))
            rb.transform.position += new Vector3(-5 * Time.deltaTime, 0, 0);



        //Vector3 screen_pos = cam.WorldToScreenPoint(coin.transform.position);
        //Vector3 screen_pos2 = cam.WorldToScreenPoint(coin_target.transform.position);
        //coin.transform.position = Vector3.Lerp(screen_pos, screen_pos2, .000001f);

            //GO.transform.position = Vector3.Lerp(coin.transform.position, point, .01f);
        
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if(other.gameObject.tag == "coin")
    //    {
    //        coin_pos = other.transform.position;
    //        print(coin_pos);
    //            other.transform.position = Vector3.Lerp(coin_pos, target_pos, Time.deltaTime * 1);
    //        // point = cam.ScreenToWorldPoint(new Vector3(coin_pos.position.x, target_pos.position.x, cam.transform.position.z));
    //        //// coin_pos.position = target_pos.position;
    //        // //float time = 0;
    //        // //while (time < 10)
    //        // //{
    //        // //time += .002f * Time.deltaTime;
    //        time = 15;
    //       // GO = Instantiate(coin, coin.transform);
    //        //}
    //        //Destroy(other.gameObject);
    //    }
    //}
}
