using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlackHoleScript : MonoBehaviour
{
    void OnTriggerEnter(Collider hit)
    {
        // ItemにPlayerが触れた時に呼ばれます
        // 接触したオブジェクトのタグが"Player"の場合
        if (hit.gameObject.CompareTag("Player"))
        {
            // 現在のシーン番号を取得
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            // 現在のシーンを再読込する
            SceneManager.LoadScene(sceneIndex);
        }
    }
}