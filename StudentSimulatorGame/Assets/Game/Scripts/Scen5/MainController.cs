using UnityEngine;
using System.Collections;
using PSV_Prototype;
using DG.Tweening;

public class SceneContoller : MonoBehaviour {
    [SerializeField]
    private GameObject _bg;
	// Use this for initialization
	void Start () {
        var time = AudioPlayer.Instance.Play("scoolEnd");
        _bg.GetComponent<SpriteRenderer>().DOFade(1f, time);
        DOVirtual.DelayedCall(AudioPlayer.Instance.Play("scoolEnd"), delegate {
            SceneLoader.Instance.SwitchToScene(Scenes.Abiturient);
        }, false);

    }
}
