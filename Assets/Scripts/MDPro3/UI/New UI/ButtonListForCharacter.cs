namespace MDPro3.UI
{
    public class ButtonListForCharacter : ButtonList
    {
        public override void SelectThis()
        {
            base.SelectThis();
            Program.instance.character.ShowCharacters(gameObject.name);
        }
    }
}
