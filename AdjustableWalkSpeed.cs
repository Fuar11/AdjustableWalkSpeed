using Mono.Cecil;

namespace AdjustableWalkSpeed
{
    internal sealed class Main : MelonMod
    {

        public static float walkSpeedMultiplier = 1;

        public override void OnInitializeMelon()
        {
            MelonLogger.Msg("Adjustable Walk Speed is online!");
            //Settings.OnLoad();
        }

        public override void OnUpdate()
        {

            if (Input.mouseScrollDelta.y < 0 && !InterfaceManager.IsOverlayActiveCached())
            {
                walkSpeedMultiplier -= 0.1f;
                walkSpeedMultiplier = Mathf.Clamp(walkSpeedMultiplier, 0.3f, 1);
            }

            if (Input.mouseScrollDelta.y > 0 && !InterfaceManager.IsOverlayActiveCached())
            {
                walkSpeedMultiplier += 0.1f;
                walkSpeedMultiplier = Mathf.Clamp(walkSpeedMultiplier, 0.3f, 1);

            }

        }

    }
}
