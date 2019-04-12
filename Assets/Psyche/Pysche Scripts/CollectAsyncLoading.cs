using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectAsyncLoading : MonoBehaviour {
    public string Collect;
    AsyncOperation async;

    public void StartLoading () {
        StartCoroutine ("load");
    }

    IEnumerator load () {
        Debug.LogWarning ("ASYNC LOAD STARTED - " +
            "DO NOT EXIT PLAY MODE UNTIL SCENE LOADS... UNITY WILL CRASH");
        async = Application.LoadLevelAsync (Collect);
        async.allowSceneActivation = false;
        yield return async;
    }

    public void ActivateScene () {

        async.allowSceneActivation = true;
    }
}