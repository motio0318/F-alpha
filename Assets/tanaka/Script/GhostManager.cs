using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostManager : MonoBehaviour
{
    public float alpha = 0.5f;//�ŏ��̓����x

    public float num = 0.02f;//1f�Ō��铧���x

    private void FixedUpdate()
    {
        SpriteRenderer ghostRenderer = GetComponent<SpriteRenderer>();//SpriteRenderer��ǂݍ���

        //�����x��ύX
        ghostRenderer.color = new Color(ghostRenderer.color.r, ghostRenderer.color.g, ghostRenderer.color.b, alpha);

        //�����x�p���l�����炷
        alpha -= num;

        //�����x���O�ɂȂ�����N���[�����폜
        if(alpha <= 0.0f)
            Destroy(gameObject, 1.0f);
    }
}
