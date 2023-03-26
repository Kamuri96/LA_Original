using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    private float moveDistance;
    private bool isMoving = false;
    private int wallLayer;

    void Start()
    {
        wallLayer = LayerMask.GetMask("Obstacle");

        if(SceneManager.GetActiveScene().name == "Main1")
        {
            moveDistance = 2.22f;
        }
        if(SceneManager.GetActiveScene().name == "Main2" || SceneManager.GetActiveScene().name == "Main3")
        {
            moveDistance = 1.82f;
        }
    }

    void Update()
    {
        PlayerMove();
    }

    private void PlayerMove()
    {
        //isMovingがtrueなら終了
        if (isMoving)
        {
            return;
        }

        // 上方向への移動
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Move(Vector3.up);
        }
        // 下方向への移動
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Move(Vector3.down);
        }
        // 右方向への移動
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Move(Vector3.right);
        }
        // 左方向への移動
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Move(Vector3.left);
        }
    }

    private void Move(Vector3 direction)
    {
        // レイを飛ばして衝突判定を行う
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, moveDistance, wallLayer);

        // 衝突しているオブジェクトがない場合、プレイヤーを移動する
        if (hit.collider == null)
        {
            Vector3 targetPosition = transform.position + direction * moveDistance;
            StartCoroutine(MoveCoroutine(targetPosition));
            Debug.Log("Go");
        }
        // 衝突しているオブジェクトがある場合
        else
        {
            // 障害物とプレイヤーの色が一致する場合、障害物のColliderを無効にする
            if (hit.collider.gameObject.CompareTag("Seaweed") && hit.collider.gameObject.GetComponent<Renderer>().material.color == GetComponent<Renderer>().material.color)
            {
                hit.collider.enabled = false;
                Debug.Log("Can Through");
                Vector3 targetPosition = transform.position + direction * moveDistance;
                StartCoroutine(MoveCoroutine(targetPosition));
                Destroy(hit.collider.gameObject,1.0f);
            }
            // 障害物とプレイヤーの色が一致しない場合、プレイヤーは動かない
            else
            {
                Debug.Log("Can't move");
                return;
            }
        }
    }

    private IEnumerator MoveCoroutine(Vector3 targetPosition)
    {
        isMoving = true;

        while (transform.position != targetPosition)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            yield return null;
        }

        isMoving = false;
    }
}

