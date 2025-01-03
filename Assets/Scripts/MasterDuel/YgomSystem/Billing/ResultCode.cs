namespace YgomSystem.Billing
{
	public enum ResultCode
	{
		NONE = 0,
		Success = 1,
		NotEnable = 2,
		Error = 3,
		ReservationError = 4,
		Cancel = 5,
		PurchaseError = 6,
		DateLimitOverError = 7,
		LimitExceededError = 8,
		LimitError = 9,
		RegisterAgeError = 10,
		AddItemError = 11,
		RestoreError = 12,
		SectionMainte = 13,
		StoreMainte = 14,
		Pending = 15,
		SteamOverlayCaution = 16,
		VoidedPurchaseError = 17,
		AdminFinishTransaction = 18
	}
}
