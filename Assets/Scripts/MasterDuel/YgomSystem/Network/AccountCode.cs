namespace YgomSystem.Network
{
	public enum AccountCode
	{
		NONE = 0,
		ERROR = 1,
		FATAL = 2,
		CRITICAL = 3,
		NO_PLATFORM = 1100,
		NO_TOKEN = 1101,
		INVALID_TOKEN = 1102,
		AGREE_MISMATCH = 1104,
		PLATFORM_EXISTING = 1105,
		PFM_INHERIT_SUCCESS = 1140,
		PFM_INHERIT_NOT_REGISTER = 1141,
		PFM_INHERIT_ALREADY_REGISTERED = 1142,
		PFM_INHERIT_ERR_INVALID_PLATFORM = 1143,
		PFM_INHERIT_ERR_SHA_NON_REG = 1144,
		PFM_INHERIT_ERR_INHERIT_FAILED = 1145,
		KID_INHERIT_SUCCESS = 1150,
		KID_INHERIT_NOT_LINKED = 1151,
		KID_INHERIT_LINKED = 1152,
		KID_INHERIT_INHERIT_WAIT = 1153,
		KID_INHERIT_API_NEED_AGREE = 1154,
		KID_INHERIT_API_UNAVAILABLE = 1155,
		KID_INHERIT_NO_DATA = 1156,
		KID_INHERIT_API_FAILED = 1157,
		KID_INHERIT_NONCE_ERR = 1158,
		KID_INHERIT_FAILED = 1159,
		KID_INHERIT_PF_RELATION_FAILED_PS = 1160,
		KID_INHERIT_PF_RELATION_FAILED_NINTENDO = 1161,
		KID_INHERIT_PF_RELATION_FAILED_XBOX = 1162,
		KID_INHERIT_PF_RELATION_FAILED_STEAM = 1163,
		KID_INHERIT_FAILED_BY_COUNTRY = 1164,
		PLATFORM_ERROR = 1170,
		PLATFORM_REAUTH = 1171,
		PLATFORM_REBOOT = 1172,
		ERR_PLATFORM_AUTH_EXPIRED = 1173,
		ERR_PLATFORM_SERVICE_AUTH_EXPIRED = 1174,
		ERR_EXCESSIVE_REPORT = 1180,
		ERR_SAME_TARGET_REPORT = 1181,
		ERR_GAME_SETTINGS_FAILED = 1185,
		PASSWD_LOCK = 1190,
		PASSWD_LOCK_INCORRECT = 1191,
		PASSWD_LOCK_EXPIRED = 1192
	}
}