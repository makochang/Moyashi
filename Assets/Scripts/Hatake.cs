using UnityEngine;

/// <summary>
/// ���N���X
/// </summary>
public class Hatake : MonoBehaviour
{
    int ID; //����ID
    float timer;    //�����g�����^�C�}�[

    const float HOUR_TO_SEC = 3600f;  //���Ԃ�b�ɒ����Ƃ��Ɋ|����l

    bool mameueta = false;          //�����A�����Ă��邩
    const float hatsuga = 1.5f;   //���肷��܂ł̓���
    const float moyashi = 3.5f;   //���₵�ɂȂ����
    const float mame = 80f;   //���ɂȂ����

    public float dayByHour = 0.5f; //�G�f�B�^�Ŏw��@1���Ԃ����艽��
    float secToDay; //1�b�����艽���i���s���v�Z�ŋ��߂�j

    // Start is called before the first frame update
    void Start()
    {
        //1�b������̓��������߂�
        secToDay = dayByHour * HOUR_TO_SEC;

        //�f�o�b�O�p
        mameueta = true;
    }

    // Update is called once per frame
    void Update()
    {
        //�����A�����Ă��鎞
        if (mameueta)
        {
            timer += Time.deltaTime;
            float keikaNissu = timer / secToDay;
            if (keikaNissu >= mame)
            {
                Debug.Log("�����Ƃ��");
            }
            else if (keikaNissu >= moyashi)
            {
                Debug.Log("���₵���Ƃ��");
            }
            else if (keikaNissu >= hatsuga)
            {
                Debug.Log("�肪�o�Ă���");
            }
        }
    }
}
