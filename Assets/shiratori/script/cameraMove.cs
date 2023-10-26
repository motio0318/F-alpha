using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class cameraMove : MonoBehaviour
{
        public float Movespeed1 = 1.5f;
        public float Movespeed2 = 0.5f;

        GameObject playerObj;
        PlayerManager player;
        Transform playerTransform;

        int n = 3;
        void Start()
        {
            playerObj = GameObject.FindGameObjectWithTag("Player");
            player = playerObj.GetComponent<PlayerManager>();
            playerTransform = playerObj.transform;
        }
        void LateUpdate()
        {
            MoveCamera();
        }
        void MoveCamera()
        {
             if(player.transform.position.y >= n && player.transform.position.y <= 18)
            {
                //�c���������Ǐ]
                transform.position = new Vector3(transform.position.x, playerTransform.position.y + Movespeed1, transform.position.z);
                transform.position = new Vector3(transform.position.x, playerTransform.position.y + Movespeed2, transform.position.z);
            n++;
            }

        }

 }
