:: 运行Unity命令行工具进行Android打包 V2
"E:\Program Files\Unity\Hub\Editor\2020.3.11f1\Editor\Unity.exe" -quit -nographics -batchmode -projectPath "${ProjectRoot}" -executeMethod MyEditorScript.BuildAndroid -logFile "${ProjectRoot}/UnityBuildLog.log"

:: Jenkins粘贴:-quit -nographics -batchmode -projectPath "${ProjectRoot}" -executeMethod MyEditorScript.BuildAndroid -logFile "${ProjectRoot}/UnityBuildLog.log"