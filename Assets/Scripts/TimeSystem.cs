using System;       //DateTime�����TimeSpan�\���̂��g�p���邽��
using UnityEngine;
public class TimeSystem : MonoBehaviour
{
    void Start()
    {
        //DateTime�^�̕ϐ���錾������̓����i2022�N11��8��19:59:00�j�ŏ���������
        DateTime specificDate = new DateTime(2022, 11, 8, 19, 59, 0);
        //DateTime�^�̕ϐ���錾�����݂̓����ŏ���������
        DateTime nowDate = DateTime.Now;
        //TimeSpan�^�̕ϐ���錾�����ݓ����Ɠ���̓����̍��ŏ���������
        TimeSpan interval = nowDate - specificDate;
        //�����̍���b���ŃR���\�[���ɏo�͂���
        Debug.Log(interval.TotalSeconds);
    }
}