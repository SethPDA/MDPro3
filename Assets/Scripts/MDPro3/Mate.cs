using MDPro3.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using Willow;

namespace MDPro3
{
    public class Mate : MonoBehaviour
    {
        public enum MateType
        {
            MasterDuel,
            CrossDuel
        }

        public enum MateAction
        {
            Initial,
            Entry,
            Tap,
            BattlePhase,
            Attack,
            GetDamage,
            Victory,
            Defeat,
            Random
        }

        public MateType type;
        public bool huge;
        public Transform parent;
        public int code;

        public PlayableDirector directorA;//a_summon    A
        public PlayableDirector directorB;//b_destroy      BD BOSS站立被破坏
        public PlayableDirector directorD;//d_attack        D 直接攻击
        public PlayableDirector directorE;//e_attack         
        public PlayableDirector directorI;//i_spSummon   SP
        public PlayableDirector directorJ;//j_destroy        JD BOSS倒地被破坏
        public PlayableDirector directorK;//k_down          KD BOSS倒地
        public PlayableDirector directorM;//m_bossAttack   BA BOSS重攻击 另有 m_attack 艾克佐迪亞
        public PlayableDirector directorN;//n_attack        NA BOSS范围攻击
        public PlayableDirector directorO;//o_attack        NA BOSS轻攻击
        BoxCollider m_collider;
        SkinnedMeshRenderer mesh;
        bool Playing()
        {
            if (directorA != null && directorA.state == PlayState.Playing)
                return true;
            if (directorB != null && directorB.state == PlayState.Playing)
                return true;
            if (directorD != null && directorD.state == PlayState.Playing)
                return true;
            if (directorE != null && directorE.state == PlayState.Playing)
                return true;
            if (directorI != null && directorI.state == PlayState.Playing)
                return true;

            if (directorI != null && directorI.state == PlayState.Playing)
                return true;
            if (directorJ != null && directorJ.state == PlayState.Playing)
                return true;
            if (directorK != null && directorK.state == PlayState.Playing)
                return true;
            if (directorM != null && directorM.state == PlayState.Playing)
                return true;
            if (directorN != null && directorN.state == PlayState.Playing)
                return true;
            if (directorO != null && directorO.state == PlayState.Playing)
                return true;

            return false;
        }

        void Start()
        {
            if (type == MateType.MasterDuel)
            {
                m_collider = gameObject.AddComponent<BoxCollider>();
                m_collider.size = new Vector3(10, 10, 10);
                m_collider.center = new Vector3(0, 5, 0);
                transform.GetChild(0).gameObject.AddComponent<EventSEPlayer>();
                var animator = transform.GetChild(0).GetComponent<Animator>();
                if (animator != null)
                    animator.cullingMode = AnimatorCullingMode.AlwaysAnimate;
                gameObject.SetActive(false);
            }
            else
            {
                Tools.SetPlayableDirectorUnscaledGameTime(transform);
                transform.localEulerAngles = Vector3.zero;
                mesh = transform.Find("Mesh").GetComponent<SkinnedMeshRenderer>();
                mesh.updateWhenOffscreen = false;
                var bounds = mesh.bounds;
                bounds.extents = new Vector3(1000, 1000, 1000);
                bounds.center = Vector3.zero;
                m_collider = gameObject.AddComponent<BoxCollider>();
                m_collider.size = new Vector3(2, 2, 2);
                m_collider.center = new Vector3(0, 1, 0);

                if (Program.instance.currentServant == Program.instance.ocgcore)
                    Tools.ChangeLayer(gameObject, "Default");
                for (int i = 0; i < transform.childCount; i++)
                {
                    CustomTimelineController controller;
                    if ((controller = transform.GetChild(i).GetComponent<CustomTimelineController>()) != null)
                    {
                        var director = controller.currentDirector;
                        if (director.name.ToLower().Contains("_a_"))
                            directorA = director;
                        if (director.name.ToLower().Contains("_b_"))
                            directorB = director;
                        if (director.name.ToLower().Contains("_d_"))
                            directorD = director;
                        if (director.name.ToLower().Contains("_e_"))
                            directorE = director;
                        if (director.name.ToLower().Contains("_i_"))
                            directorI = director;
                        if (director.name.ToLower().Contains("_j_"))
                            directorJ = director;
                        if (director.name.ToLower().Contains("_k_"))
                            directorK = director;
                        if (director.name.ToLower().Contains("_m_"))
                        {
                            directorM = director;
                            huge = true;
                        }
                        if (director.name.ToLower().Contains("_n_"))
                            directorN = director;
                        if (director.name.ToLower().Contains("_o_"))
                            directorO = director;
                    }
                }
                transform.localScale = Vector3.one * 5;
                if(huge)
                    transform.localScale = Vector3.one * 4f;

                var animator = GetComponent<Animator>();
                if (animator != null)
                    animator.cullingMode = AnimatorCullingMode.AlwaysAnimate;

                //AnimatorControllerParameter[] parameter = animator.parameters;
                //foreach (var param in parameter)
                //    Debug.Log(": 参数名称：" + param.name + " 参数类型：" + param.type);

            }
        }


        public void Play(MateAction action)
        {
            switch (type)
            {
                case (MateType.MasterDuel):
                    switch (action)
                    {
                        case MateAction.Entry:
                            transform.SetParent(parent, false);
                            Tools.PlayAnimation(transform, "Entry");
                            break;
                        case MateAction.Tap:
                            int i = Random.Range(0, 3);
                            switch (i)
                            {
                                case 0:
                                    Tools.PlayAnimation(transform, "Tap");
                                    break;
                                case 1:
                                    Tools.PlayAnimation(transform, "Tap1");
                                    break;
                                case 2:
                                    Tools.PlayAnimation(transform, "Tap2");
                                    break;
                            }
                            break;
                        case MateAction.BattlePhase:

                            break;
                        case MateAction.Attack:
                            Tools.PlayAnimation(transform, "Attack");
                            break;
                        case MateAction.GetDamage:
                            Tools.PlayAnimation(transform, "Damage");
                            break;
                        case MateAction.Victory:
                            Tools.PlayAnimation(transform, "Victory");
                            break;
                        case MateAction.Defeat:
                            Tools.PlayAnimation(transform, "Defeat");
                            break;
                        case MateAction.Random:
                            if (Random.Range(0, 2) > 0.5f)
                                Tools.PlayAnimation(transform, "Random1");
                            else
                                Tools.PlayAnimation(transform, "Random2");
                            break;
                    }
                    break;
                case (MateType.CrossDuel):
                    var animator = GetComponent<Animator>();
                    if (animator.GetBool("IsKnockDown"))
                        break;
                    switch (action)
                    {
                        case MateAction.Initial:

                            animator.SetBool("IsVisible", true);
                            animator.SetBool("IsFaceUp", true);
                            animator.SetBool("IsAttackPosition", true);
                            animator.SetTrigger("Update");
                            break;
                        case MateAction.Entry:
                            transform.SetParent(parent, false);
                            animator.SetBool("IsVisible", true);
                            animator.SetBool("IsFaceUp", true);
                            animator.SetBool("IsAttackPosition", true);
                            animator.SetTrigger("Update");
                            if (directorI != null)
                            {
                                directorI.Play();
                                MateView.PlayCrossDuelSe(directorI.name.Replace("(Clone)", string.Empty));
                                mesh.updateWhenOffscreen = true;
                            }
                            else if (directorA != null)
                            {
                                directorA.Play();
                                MateView.PlayCrossDuelSe(directorA.name.Replace("(Clone)", string.Empty));
                            }
                            break;
                        case MateAction.Tap:
                            if (Playing())
                                break;
                            if (directorM != null && directorN != null && directorO != null)
                            {
                                var random = Random.Range(0, 3);
                                switch (random)
                                {
                                    case 0:
                                        directorM.Play();
                                        MateView.PlayCrossDuelSe(directorM.name.Replace("(Clone)", string.Empty));
                                        break;
                                    case 1:
                                        directorN.Play();
                                        MateView.PlayCrossDuelSe(directorN.name.Replace("(Clone)", string.Empty));
                                        break;
                                    case 2:
                                        directorO.Play();
                                        MateView.PlayCrossDuelSe(directorO.name.Replace("(Clone)", string.Empty));
                                        break;
                                }
                            }
                            else if (directorM != null)//艾克佐迪亞
                            {
                                directorM.Play();
                                MateView.PlayCrossDuelSe(directorM.name.Replace("(Clone)", string.Empty));
                            }
                            else if (directorD != null)
                            {
                                directorD.Play();
                                MateView.PlayCrossDuelSe(directorD.name.Replace("(Clone)", string.Empty));
                            }
                            break;
                        case MateAction.BattlePhase:
                            break;
                        case MateAction.Attack:
                            if (directorE != null)
                            {
                                directorE.Play();
                                MateView.PlayCrossDuelSe(directorE.name.Replace("(Clone)", string.Empty));
                            }
                            break;
                        case MateAction.GetDamage:
                            //animator.SetTrigger("Damage");
                            break;
                        case MateAction.Victory:
                            break;
                        case MateAction.Defeat:
                            if (directorB != null) 
                            { 
                                directorB.Play();
                                MateView.PlayCrossDuelSe(directorB.name.Replace("(Clone)", string.Empty));
                                animator.SetBool("IsKnockDown", true);
                                animator.SetBool("IsVisible", false);
                            }
                            else
                            {
                                animator.SetBool("IsAttackPosition", false);
                            }
                            break;
                    }
                    break;
            }
        }

        public void ActiveCamera(MateAction action, int layerMask)
        {
            if (action == MateAction.Entry)
            {
                if (directorI != null)
                {
                    foreach (var camera in directorI.transform.parent.GetComponentsInChildren<Camera>(true))
                    {
                        if (camera.name == "UIEffect_Camera")
                            continue;
                        camera.enabled = true;
                        camera.cullingMask = 1 << layerMask;
                        camera.clearFlags = CameraClearFlags.Nothing;
                        CameraManager.DuelOverlay2DMinus();
                        var mono = camera.gameObject.AddComponent<DoWhenDisabled>();
                        mono.action = () =>
                        {
                            CameraManager.DuelOverlay2DPlus();
                        };
                    }
                    foreach (var light in directorI.transform.parent.GetComponentsInChildren<Light>(true))
                    {
                        light.enabled = true;
                        light.cullingMask = 1 << layerMask;
                    }
                }
            }
            if (action == MateAction.Tap)
            {
                if (directorM != null)
                {
                    foreach (var camera in directorM.transform.parent.GetComponentsInChildren<Camera>(true))
                    {
                        if (camera.name == "UIEffect_Camera")
                            continue;
                        camera.enabled = true;
                        camera.cullingMask = 1 << layerMask;
                    }
                    foreach (var light in directorM.transform.parent.GetComponentsInChildren<Light>(true))
                    {
                        light.enabled = true;
                        light.cullingMask = 1 << layerMask;
                    }

                }
            }
        }

        public void SetTimeScale(float timeScale)
        {
            if (type == MateType.MasterDuel)
            {
                Tools.SetAnimatorTimescale(transform, timeScale);
            }
        }
    }
}
