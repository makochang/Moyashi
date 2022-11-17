using System.IO;

public static class FileManager
{
    static string initData = "";

    /// <summary>
    /// �w��̃t�@�C���p�X�ɕ������ۑ�����
    /// </summary>
    /// <param name="path">�t�@�C���p�X</param>
    /// <param name="data">�������ޕ�����</param>
    public static void WriteString(string path, string data)
    {
        StreamWriter writer = new StreamWriter(path,false);
        writer.Write(data);
        writer.Close();
    }

    /// <summary>
    /// �w��̃t�@�C���p�X���當�����ǂݎ��A�Ԃ�
    /// </summary>
    /// <param name="path">�t�@�C���p�X</param>
    /// <returns>�ǂݍ��񂾕�����</returns>
    public static string ReadString(string path)
    {
        //�t�@�C���̗L���ŏ�����ύX����
        if (File.Exists(path))
        {
            StreamReader reader = new StreamReader(path);
            string data = reader.ReadLine();
            reader.Close();

            return data;
        }
        else
        {
            //�t�@�C�������݂��Ȃ���΁A�Z�[�u�f�[�^������������
            WriteString(path, initData);
            return initData;
        }
    }
}
