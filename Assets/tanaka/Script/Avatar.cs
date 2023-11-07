using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Avatar : MonoBehaviour
{

    public GameObject playerClonePrefab;//�v���C���[���g�̃v���n�u

    public Transform spawnPoint;//���g�����ʒu

    public Button cloneButton;//���g�{�^��

    
    // Start is called before the first frame update
    private  void Start()
    {
        //�{�^�����N���b�N�C�x���g�Ɋ֐����֘A�t����

        cloneButton.onClick.AddListener(SpawnPlayerClone);
        
    }

    void SpawnPlayerClone()
    {
        //�v���n�u�𐶐����Ĉʒu��ݒ�
        GameObject clone =
       Instantiate(playerClonePrefab, spawnPoint.position, Quaternion.identity);

        //�����ŁA�v���C���[�̐���𕪐g�ɐ؂�ւ��邽�߂̃R�[�h��ǉ�

        /*��: ���g�𐧌䂷�邽�߂̃X�N���v�g��L���ɂ���
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
