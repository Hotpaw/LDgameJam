using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCameraX : CinemachineExtension
{

    [Tooltip("Lock the camera's Y position to this value")]
    public float XPosition = 0;

    protected override void PostPipelineStageCallback(
        CinemachineVirtualCameraBase vcam,
        CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        if (stage == CinemachineCore.Stage.Finalize)
        {
            var pos = state.RawPosition;
            pos.x = XPosition;
            state.RawPosition = pos;
        }
    }
}
