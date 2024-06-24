using EmoteScriptLib.Entity.Enum;

namespace EmoteScriptLib.Emotes
{
    public class InqFellowNum : Emote
    {
        public InqFellowNum() : base(EmoteType.InqFellowNum)
        {
            Init();
        }

        public InqFellowNum(int min, int max)

            : base(EmoteType.InqFellowNum)
        {
            Init();

            Min = min;
            Max = max;
        }

        public void Init()
        {
            AddValidBranches(Branch.TestNumFellows);
        }
    }
}
