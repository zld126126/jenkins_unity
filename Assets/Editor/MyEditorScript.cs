using System;
using UnityEditor;

class MyEditorScript {
        [MenuItem ("Custom/CI/Build Android")]
        public static void BuildAndroid()
        {
            string[] scenes = { "Assets/Scenes/SampleScene.unity"}; // 填写您的场景文件路径
            string outputPath = "Builds/Android/JenkinsUnity.apk";
            
            BuildPipeline.BuildPlayer(scenes, outputPath, BuildTarget.Android, BuildOptions.None);
        }
}