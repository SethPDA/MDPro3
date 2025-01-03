namespace YgomGame.Duel
{
	public interface IMainCameraOperation
	{
		void UpdateOperation(MainCameraOrganizer mainCamera);

		void LateUpdateOperation(MainCameraOrganizer mainCamera);
	}
}
