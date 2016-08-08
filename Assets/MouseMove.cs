using UnityEngine;
using System.Collections;

public class MouseMove : MonoBehaviour {
    [SerializeField]
    private Camera m_subCamera;

    private float m_subCameraPosZ;

	// Use this for initialization
	void Start () {
        this.m_subCameraPosZ = this.m_subCamera.transform.localPosition.z;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 viewportPoint = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        float posX = viewportPoint.x - 0.125f;
        float posY = viewportPoint.y - 0.125f;
        this.m_subCamera.rect = new Rect(posX, posY, 0.25f, 0.25f);


        /* サブカメラの移動処理 */
        Vector3 mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.m_subCamera.transform.localPosition = new Vector3(mousePoint.x, mousePoint.y, this.m_subCameraPosZ);
    }
    
}
