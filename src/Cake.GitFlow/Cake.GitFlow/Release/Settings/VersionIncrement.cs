namespace Cake.GitFlow.Release.Settings
{
    public class VersionIncrement
    {
        private bool increaseMajor;
        public bool IncreaseMajor
        {
            get => increaseMajor;

            set
            {
                increaseMajor = true;
                increaseMinor = false;
                increasePatch = false;
            }
        }


        private bool increaseMinor;
        public bool IncreaseMinor
        {
            get => increaseMinor;
            set
            {
                increaseMajor = false;
                increaseMinor = true;
                increasePatch = false;
            }
        }
        private bool increasePatch;
        public bool IncrestePatch { get => increasePatch;
            set
            {
                increaseMajor = false;
                increaseMinor = false;
                increasePatch = true;
            }
        }
    }
}
