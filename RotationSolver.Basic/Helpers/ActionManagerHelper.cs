﻿using ECommons.DalamudServices;
using FFXIVClientStructs.FFXIV.Client.Game;
using FFXIVClientStructs.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotationSolver.Basic.Helpers
{
    internal static class ActionManagerHelper
    {
        public static unsafe float GetCurrentAnimationLock()
        {
            var actionManager = ActionManager.Instance();
            if (actionManager == null) return 0.6f;

            var animationLockRaw = ((IntPtr)actionManager + 8);
            var animationLock = *(float*)animationLockRaw;
            //Svc.Log.Verbose($"AnimationLock: {animationLock}");
            return animationLock;
        }
    }
}
