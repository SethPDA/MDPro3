using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace MDPro3
{
    public class CameraManager : Manager
    {
        public Camera cameraMain;
        public Camera camera2D;
        public Camera cameraDuelOverlay3D;
        public Camera cameraDuelOverlayEffect3D;
        public Camera cameraDuelOverlay2D;
        public Camera cameraDuelOverlayEffect2D;
        public Camera cameraUI;
        public Camera cameraUIBlur;
        public Camera cameraRenderTexture;
        public GameObject light;
        public SpriteRenderer black;

        public UniversalRenderPipelineAsset urpAsset;
        public UniversalRendererData forwardRendererData;
        public UniversalRenderPipelineAsset urpAssetForUI;
        public UniversalRendererData forwardRendererDataForUI;

        public static Vector3 mainCameraDefaultPosition = new Vector3(0f, 95f, -37f);
        public static Vector3 mainCameraDefaultRotation = new Vector3(70f, 0f, 0f);

        public override void Initialize()
        {
            base.Initialize();
            urpAsset = Resources.Load<UniversalRenderPipelineAsset>("Settings/URPAsset");
            forwardRendererData = Resources.Load<UniversalRendererData>("Settings/URPAsset_Renderer");
            urpAssetForUI = Resources.Load<UniversalRenderPipelineAsset>("Settings/URPAssetForUI");
            forwardRendererDataForUI = Resources.Load<UniversalRendererData>("Settings/URPAssetForUI_Renderer");

            ShiftTo2D();
            ChangeCameraFOV();
            DuelOverlay2DMinus();
            DuelOverlay3DMinus();
            DuelOverlayEffect2DMinus();
            DuelOverlayEffect3DMinus();
            UIBlurMinus();
            SystemEvent.OnResolutionChange += ChangeCameraFOV;
        }

        public static void ChangeCameraFOV()
        {
            float aspect = (float)Screen.width * 9 / Screen.height;
            if (aspect > 16)
            {
                Program.instance.camera_.cameraMain.fieldOfView = 30 + 16 - aspect;
                Program.instance.camera_.cameraDuelOverlay3D.fieldOfView = Program.instance.camera_.cameraMain.fieldOfView;
            }
            else
            {
                Program.instance.camera_.cameraMain.fieldOfView = 30;
                Program.instance.camera_.cameraDuelOverlay3D.fieldOfView = 30;
            }
        }

        public static void ShiftTo2D()
        {
            Program.instance.camera_.cameraMain.gameObject.SetActive(false);
            Program.instance.camera_.light.SetActive(false);
            Program.instance.camera_.camera2D.gameObject.SetActive(true);

            DuelOverlay3DCount = 0;
            DuelOverlay2DCount = 0;
            DuelOverlayEffect3DCount = 0;
            DuelOverlayEffect2DCount = 0;

            DuelOverlay3DMinus();
            DuelOverlayEffect3DMinus();
            DuelOverlay2DMinus();
            DuelOverlayEffect2DMinus();

            QualitySettings.SetQualityLevel(6);
        }
        public static void ShiftTo3D()
        {
            Program.instance.camera_.cameraMain.gameObject.SetActive(true);
            Program.instance.camera_.light.SetActive(true);
            Program.instance.camera_.camera2D.gameObject.SetActive(false);
            QualitySettings.SetQualityLevel((int)Config.GetFloat("Quality", 2f));
        }
        public static void Overlay3DReset()
        {
            Program.instance.camera_.cameraDuelOverlay3D.transform.localPosition = new Vector3(0, 95, -37);
            Program.instance.camera_.cameraDuelOverlay3D.transform.localEulerAngles = new Vector3(70, 0, 0);
        }

        public static int DuelOverlay2DCount = 0;
        public static void DuelOverlay2DPlus()
        {
            DuelOverlay2DCount++;
            Program.instance.camera_.cameraDuelOverlay2D.gameObject.SetActive(true);
        }
        public static void DuelOverlay2DMinus()
        {
            DuelOverlay2DCount--;
            if (DuelOverlay2DCount < 0)
                DuelOverlay2DCount = 0;
            if (DuelOverlay2DCount == 0)
                Program.instance.camera_.cameraDuelOverlay2D.gameObject.SetActive(false);
        }

        public static int DuelOverlayEffect2DCount = 0;
        public static void DuelOverlayEffect2DPlus()
        {
            DuelOverlayEffect2DCount++;
            Program.instance.camera_.cameraDuelOverlayEffect2D.gameObject.SetActive(true);
        }
        public static void DuelOverlayEffect2DMinus()
        {
            DuelOverlayEffect2DCount--;
            if (DuelOverlayEffect2DCount < 0)
                DuelOverlayEffect2DCount = 0;
            if (DuelOverlayEffect2DCount == 0)
                Program.instance.camera_.cameraDuelOverlayEffect2D.gameObject.SetActive(false);
        }

        public static int DuelOverlay3DCount = 0;
        public static void DuelOverlay3DPlus()
        {
            DuelOverlay3DCount++;
            Program.instance.camera_.cameraDuelOverlay3D.gameObject.SetActive(true);
        }
        public static void DuelOverlay3DMinus()
        {
            DuelOverlay3DCount--;
            if (DuelOverlay3DCount < 0)
                DuelOverlay3DCount = 0;
            if (DuelOverlay3DCount == 0)
                Program.instance.camera_.cameraDuelOverlay3D.gameObject.SetActive(false);
        }

        public static int DuelOverlayEffect3DCount = 0;
        public static void DuelOverlayEffect3DPlus()
        {
            DuelOverlayEffect3DCount++;
            Program.instance.camera_.cameraDuelOverlayEffect3D.gameObject.SetActive(true);
        }
        public static void DuelOverlayEffect3DMinus()
        {
            DuelOverlayEffect3DCount--;
            if (DuelOverlayEffect3DCount < 0)
                DuelOverlayEffect3DCount = 0;
            if (DuelOverlayEffect3DCount == 0)
                Program.instance.camera_.cameraDuelOverlayEffect3D.gameObject.SetActive(false);
        }


        public static int uiBlurCount = 0;
        public static void UIBlurPlus()
        {
            uiBlurCount++;
            Program.instance.camera_.cameraUIBlur.gameObject.SetActive(true);
            //foreach (var feature in Program.instance.camera_.forwardRendererData.rendererFeatures)
            //    if (feature is KawaseBlur)
            //        feature.SetActive(true);
            //foreach (var feature in Program.instance.camera_.forwardRendererDataForUI.rendererFeatures)
            //    if (feature is KawaseBlur)
            //        feature.SetActive(true);
        }
        public static void UIBlurMinus()
        {
            uiBlurCount--;
            if (uiBlurCount < 0)
                uiBlurCount = 0;
            if (uiBlurCount == 0)
            {
                Program.instance.camera_.cameraUIBlur.gameObject.SetActive(false);
                //foreach (var feature in Program.instance.camera_.forwardRendererData.rendererFeatures)
                //    if (feature is KawaseBlur)
                //        feature.SetActive(false);
                //foreach (var feature in Program.instance.camera_.forwardRendererDataForUI.rendererFeatures)
                //    if (feature is KawaseBlur)
                //        feature.SetActive(false);
            }
        }

        public static void BlackInOut(float delay, float inTime, float time, float outTime)
        {
            var sequence = DOTween.Sequence();
            sequence.AppendInterval(delay);
            sequence.Append(Program.instance.camera_.black.DOFade(0.75f, inTime));
            sequence.AppendInterval(time);
            sequence.Append(Program.instance.camera_.black.DOFade(0, outTime));
        }
        public static void BlackIn(float delay, float inTime)
        {
            var sequence = DOTween.Sequence();
            sequence.AppendInterval(delay);
            sequence.Append(Program.instance.camera_.black.DOFade(0.75f, inTime));
        }
        public static void BlackOut(float delay, float outTime)
        {
            var sequence = DOTween.Sequence();
            sequence.AppendInterval(delay);
            sequence.Append(Program.instance.camera_.black.DOFade(0f, outTime));
        }

        public static void ShakeCamera(bool heavy = false)
        {
            if (heavy)
            {
                Program.instance.camera_.cameraMain.DOShakePosition(0.4f, 5, 100);
            }
            else
            {
                Program.instance.camera_.cameraMain.DOShakePosition(0.2f, 0.5f, 50);
            }
        }

        public static bool overlaySticking;
        public static void Duel3DOverlayStickWithMain(bool stick)
        {
            if (stick)
            {
                overlaySticking = true;
                Program.instance.camera_.cameraDuelOverlay3D.transform.SetParent(Program.instance.camera_.cameraMain.transform, false);
                Program.instance.camera_.cameraDuelOverlay3D.transform.localPosition = Vector3.zero;
                Program.instance.camera_.cameraDuelOverlay3D.transform.localEulerAngles = Vector3.zero;
            }
            else
            {
                overlaySticking = false;
                Program.instance.camera_.cameraDuelOverlay3D.transform.SetParent(Program.instance.camera_.transform, false);
                Program.instance.camera_.cameraDuelOverlay3D.transform.localPosition = mainCameraDefaultPosition;
                Program.instance.camera_.cameraDuelOverlay3D.transform.localEulerAngles = mainCameraDefaultRotation;

            }
        }

        private void OnApplicationQuit()
        {
            cameraRenderTexture.targetTexture = null;
        }
    }
}
