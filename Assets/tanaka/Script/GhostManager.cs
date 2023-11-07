using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostManager : MonoBehaviour
{
    public float alpha = 0.5f;//最初の透明度

    public float num = 0.02f;//1fで減る透明度

    private void FixedUpdate()
    {
        SpriteRenderer ghostRenderer = GetComponent<SpriteRenderer>();//SpriteRendererを読み込み

        //透明度を変更
        ghostRenderer.color = new Color(ghostRenderer.color.r, ghostRenderer.color.g, ghostRenderer.color.b, alpha);

        //透明度用数値を減らす
        alpha -= num;

        //透明度が０になったらクローンを削除
        if(alpha <= 0.0f)
            Destroy(gameObject, 1.0f);
    }
}
