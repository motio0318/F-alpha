using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public float enemyHP;       //�G�I�u�W�F�N�gHP
    public float swordDamage;   //���_���[�W�i���player����擾�j
    public float syurikenDmage; //�藠���_���[�W�i�V�j

    //��collider�ڐG��
    void OnTriggerEnter2D(Collider2D other)
    {   
        Debug.Log("OnTriggerEnter2D: " + other.gameObject.name);

        //���Ƃ̐ڐG
        if(other.gameObject.tag == "Sword")
        {
            Debug.Log("���̃_���[�W");
            enemyHP -= swordDamage; //HP�����_���[�W�����炷
        }
        //�藠���Ƃ̐ڐG
        if (other.gameObject.tag == "Syuriken")
        {
            Debug.Log("�藠���̃_���[�W");
            enemyHP -= syurikenDmage; //HP���藠���_���[�W�����炷
        }
        //�|��邩���ׂ�
        EnemyDead();
    }

    //�|��邩���ׂ�֐�
    void EnemyDead()
    {
        //�GHP��0�ȉ��Ȃ�A���̃I�u�W�F�N�g������
        if (enemyHP <= 0.0f)
        {
            Destroy(gameObject);
            Debug.Log("�G���|�ꂽ");
        }
    }
}