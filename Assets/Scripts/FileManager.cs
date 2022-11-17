using System.IO;

public static class FileManager
{
    static string initData = "";

    /// <summary>
    /// 指定のファイルパスに文字列を保存する
    /// </summary>
    /// <param name="path">ファイルパス</param>
    /// <param name="data">書き込む文字列</param>
    public static void WriteString(string path, string data)
    {
        StreamWriter writer = new StreamWriter(path,false);
        writer.Write(data);
        writer.Close();
    }

    /// <summary>
    /// 指定のファイルパスから文字列を読み取り、返す
    /// </summary>
    /// <param name="path">ファイルパス</param>
    /// <returns>読み込んだ文字列</returns>
    public static string ReadString(string path)
    {
        //ファイルの有無で処理を変更する
        if (File.Exists(path))
        {
            StreamReader reader = new StreamReader(path);
            string data = reader.ReadLine();
            reader.Close();

            return data;
        }
        else
        {
            //ファイルが存在しなければ、セーブデータを初期化する
            WriteString(path, initData);
            return initData;
        }
    }
}
