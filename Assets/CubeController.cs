using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

    //キューブの移動速度
    private float speed = -12;

    //消滅位置
    private float deadLine = -10;
    //キューブの生成音(課題)
    private AudioSource audiodata;

    // Use this for initialization
    void Start ()
    {
        audiodata = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
        //キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //画面外にでたら破棄する
        if(transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
		
	}

    //キューブ同士が接触したら音を鳴らす（課題）
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "CubePrefab" || other.gameObject.tag == "ground")
        {
            audiodata.PlayDelayed(1);
        }
    }
}
