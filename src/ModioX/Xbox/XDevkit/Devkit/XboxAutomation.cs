using System;

namespace XDevkit
{
    public class XboxAutomation
    {
        private uint eax2;

        void BindController(uint UserIndex, uint QueueLength)
        {

        }


        void ClearGamepadQueue(uint UserIndex)
        {

        }

        uint ConnectController(uint UserIndex)
        {
            eax2 = DMSendCommand(UserIndex, 0x4654e0, out _);
            return eax2;
        }

        private uint DMSendCommand(uint UserIndex, int v, out string respond)
        {
            throw new NotImplementedException();
        }

        void DisconnectController(uint UserIndex)
        {

        }

        void GetInputProcess(uint UserIndex, out bool SystemProcess)
        {
            SystemProcess = false;
        }

        void GetUserDefaultProfile(out long Xuid)
        {
            Xuid = 0;
        }

        void QueryGamepadQueue(uint UserIndex, out uint QueueLength, out uint ItemsInQueue, out uint TimedDurationRemaining, out uint CountDurationRemaining)
        {
            QueueLength = 0;
            ItemsInQueue = 0;
            TimedDurationRemaining = 0;
            CountDurationRemaining = 0;

        }

        bool QueueGamepadState(uint UserIndex, ref XBOX_AUTOMATION_GAMEPAD Gamepad, uint TimedDuration, uint CountDuration)
        {
            return false;
        }

        void QueueGamepadState_cpp(uint UserIndex, ref XBOX_AUTOMATION_GAMEPAD GamepadArray, ref uint TimedDurationArray, ref uint CountDurationArray, uint ItemCount, out uint ItemsAddedToQueue)
        {
            ItemsAddedToQueue = 0;
        }

        void SetGamepadState(uint UserIndex, ref XBOX_AUTOMATION_GAMEPAD Gamepad)
        {

        }

        void SetUserDefaultProfile(long Xuid)
        {

        }

        void UnbindController(uint UserIndex)
        {

        }
    }
}