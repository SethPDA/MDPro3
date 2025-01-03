namespace YgomGame.Deck
{
	internal class CategoryReference
	{
		public int id;

		public string name;

		public string kana;

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
