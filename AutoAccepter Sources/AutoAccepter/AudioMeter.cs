using CSCore.CoreAudioAPI;

namespace AutoAccepter
{
    public static class AudioMeter
    {
        public static bool CheckForSoundPeak()
        {
            using (var sessionManager = GetDefaultAudioSessionManager2(DataFlow.Render))
            {
                using (var sessionEnum = sessionManager.GetSessionEnumerator())
                {
                    foreach (var session in sessionEnum)
                    {
                        using (var session2 = session.QueryInterface<AudioSessionControl2>())
                        {
                            using (var audioMeterInformation = session.QueryInterface<AudioMeterInformation>())
                            {
                                //See if Dota emits sound (If there are two Windows containing Dota in the title sound of either one will trigger!!
                                if (session2 == null) return false;
                                if (session2.Process.MainWindowTitle.Contains("Dota") && (audioMeterInformation.GetPeakValue() > 0.015))
                                    return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        private static AudioSessionManager2 GetDefaultAudioSessionManager2(DataFlow dataFlow)
        {
            using (var enumerator = new MMDeviceEnumerator())
            {
                using (var device = enumerator.GetDefaultAudioEndpoint(dataFlow, Role.Multimedia))
                {

                    var sessionManager = AudioSessionManager2.FromMMDevice(device);
                    return sessionManager;
                }
            }
        }
    }
}
