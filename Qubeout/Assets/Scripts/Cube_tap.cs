using UnityEngine;
using System.Collections;

public class Cube_tap : MonoBehaviour {

	public Color changeColor = new Color(0.5F, 0F, 0F, 0.5F);
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if(OnMouseDown){
			this.gameObject.GetComponent<Renderer> ().material.SetColor ("_TintColor", changeColor);
			Debug.Log ("tap_recog");
		}
	}

	bool OnMouseDown() {
		// 左クリックされているとき
		if(Input.GetMouseButton(0) == true){
				// クリックした座標をコピー
				Vector3 mousePos = Input.mousePosition;
				//クリックした位置からRayを飛ばす
				Ray ray = Camera.main.ScreenPointToRay(mousePos);
				RaycastHit hit = new RaycastHit();
				if (Physics.Raycast(ray, out hit)){
					//Rayを飛ばしてあたったオブジェクトが自分自身だったら
					if (hit.collider.gameObject == this.gameObject){
						return true;
					}
				}

			
		}
		return false; //クリックされてなかったらfalse
	}

	//そのオブジェクトがタッチされていたらtrue（マルチタップ対応）
//	bool OnTouchDown() {
//		// タッチされているとき
//		if( 0 < Input.touchCount){
//			// タッチされている指の数だけ処理
//			for(int i = 0; i < Input.touchCount; i++){
//				// タッチ情報をコピー
//				Touch t = Input.GetTouch(i);
//				// タッチしたときかどうか
//				if(t.phase == TouchPhase.Began ){
//					//タッチした位置からRayを飛ばす
//					Ray ray = Camera.main.ScreenPointToRay(t.position);
//					RaycastHit hit = new RaycastHit();
//					if (Physics.Raycast(ray, out hit)){
//						//Rayを飛ばしてあたったオブジェクトが自分自身だったら
//						if (hit.collider.gameObject == this.gameObject){
//							return true;
//						}
//					}
//				}
//			}
//		}
//		return false; //タッチされてなかったらfalse
//	}
}