namespace YgomGame.CardPack.Open.Sequence
{
	public interface ISequenceBehaviour
	{
		SequenceBehaviour.State state { get; }

		string name { get; }

		void Begin();

		bool Update();

		void End();

		bool OnBack();
	}
}
