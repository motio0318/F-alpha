using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Avatar : MonoBehaviour
{

    public GameObject playerClonePrefab;//プレイヤー分身のプレハブ

    public Transform spawnPoint;//文身生成位置

    public Button cloneButton;//分身ボタン

    
    // Start is called before the first frame update
    private  void Start()
    {
        //ボタンをクリックイベントに関数を関連付ける

        cloneButton.onClick.AddListener(SpawnPlayerClone);
        
    }

    void SpawnPlayerClone()
    {
        //プレハブを生成して位置を設定
        GameObject clone =
       Instantiate(playerClonePrefab, spawnPoint.position, Quaternion.identity);

        //ここで、プレイヤーの制御を分身に切り替えるためのコードを追加

        /*例: 分身を制御するためのスクリプトを有効にする
        PlayerCloneScript cloneScript = clone.GetComponent<PlayerCloneScript>();
        if (cloneScript != null)
        {
            cloneScript.EnableControl();
                }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
