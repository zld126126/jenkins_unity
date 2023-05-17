using UnityEditor;

class MyEditorScript {
        [MenuItem ("Custom/CI/Build Android")]
        public static void BuildAndroid()
        {
            string[] scenes = { "Assets/Scenes/myJenkinsUnity.unity"}; // 填写您的场景文件路径

            string outputPath = "Builds/Android/myJenkinsUnity.apk"; // 填写输出APK的路径和名称

            BuildPipeline.BuildPlayer(scenes, outputPath, BuildTarget.Android, BuildOptions.None);
        }
}