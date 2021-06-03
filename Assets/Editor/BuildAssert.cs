using UnityEngine;
using UnityEditor;

/// <summary>
/// 利用ScriptableObject创建资源文件
/// </summary>
public class BuildAsset : Editor {

    [MenuItem("BuildAsset/Build Scriptable Level")]
    public static void ExcuteBuildLevel()
    {
        Questionnaire holder = ScriptableObject.CreateInstance<Questionnaire>();

        //查询excel表中数据，赋值给asset文件
        holder.items = ExcelAccess.SelectMenuLang(0);

        string path= "Assets/Resources/DataAssets/Questionnaire.asset";

        AssetDatabase.CreateAsset(holder, path);
        AssetDatabase.Refresh();
        Debug.Log("BuildAsset Success!");
    }
}
