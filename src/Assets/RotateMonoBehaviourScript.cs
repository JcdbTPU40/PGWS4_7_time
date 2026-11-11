using UnityEngine;

// Y軸まわりに一定速度で回転させる（Scene_1 のスクリプト回転用）
public class RotateMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private float secondsPerTurn = 10.0f; // 1周にかける秒数

    void Update()
    {
        // 1周 = 360度。deltaTime は1秒で合計1.0になる
        float angle = 360.0f * Time.deltaTime / secondsPerTurn;
        transform.Rotate(0.0f, angle, 0.0f);
    }
}
