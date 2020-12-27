using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    private Text coin_txt;
    private Camera cam;
    private Vector3 target_pos;
    private Image target;
    private bool isAnimation;
    private static int total_coin;
    // Start is called before the first frame update
    void Start()
    {
        total_coin = 0;
        cam = Camera.main;
        isAnimation = false;
        target = GameObject.Find("coin_target").GetComponent<Image>();
        coin_txt = GameObject.Find("coin_txt").GetComponent<Text>();
        coin_txt.text = total_coin.ToString();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float distance = Vector3.Distance(transform.position, target_pos);
        if (distance < 1f)
        {
            Destroy(gameObject);
        }
        else if (isAnimation)
        {
            PlayAnimation();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            target_pos = Target();
            isAnimation = true;
            total_coin++;
            coin_txt.text = total_coin.ToString();
        }
    }
    private Vector3 Target()
    {
        Vector3 ps = target.rectTransform.position;
        ps.z = 10;//You can make this value an average of 50 so that the money shrinks as it goes to the target.
        return cam.ScreenToWorldPoint(ps);
    }
    private void PlayAnimation()
    {
        transform.position = Vector3.Lerp(transform.position, target_pos, Time.deltaTime * 5);
    }
}
