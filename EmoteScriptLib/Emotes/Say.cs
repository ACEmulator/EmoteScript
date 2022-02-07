using EmoteScriptLib.Entity.Enum;

namespace EmoteScriptLib.Emotes
{
    public class Say : Emote
    {
        public Say() : base(EmoteType.Say)
        {

        }
        
        public Say(string message, float? extent = null) : base(EmoteType.Say)
        {
            Message = message;
            Extent = extent;
        }
    }
}
