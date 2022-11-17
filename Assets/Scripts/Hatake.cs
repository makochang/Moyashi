using UnityEngine;

/// <summary>
/// 畑クラス
/// </summary>
public class Hatake : MonoBehaviour
{
    int ID; //畑のID
    float timer;    //畑自身が持つタイマー

    const float HOUR_TO_SEC = 3600f;  //時間を秒に直すときに掛ける値

    bool mameueta = false;          //豆が植えられているか
    const float hatsuga = 1.5f;   //発芽するまでの日数
    const float moyashi = 3.5f;   //もやしになる日数
    const float mame = 80f;   //豆になる日数

    public float dayByHour = 0.5f; //エディタで指定　1時間あたり何日
    float secToDay; //1秒あたり何日（実行時計算で求める）

    // Start is called before the first frame update
    void Start()
    {
        //1秒あたりの日数を求める
        secToDay = dayByHour * HOUR_TO_SEC;

        //デバッグ用
        mameueta = true;
    }

    // Update is called once per frame
    void Update()
    {
        //豆が植えられている時
        if (mameueta)
        {
            timer += Time.deltaTime;
            float keikaNissu = timer / secToDay;
            if (keikaNissu >= mame)
            {
                Debug.Log("豆がとれる");
            }
            else if (keikaNissu >= moyashi)
            {
                Debug.Log("もやしがとれる");
            }
            else if (keikaNissu >= hatsuga)
            {
                Debug.Log("芽が出ている");
            }
        }
    }
}
