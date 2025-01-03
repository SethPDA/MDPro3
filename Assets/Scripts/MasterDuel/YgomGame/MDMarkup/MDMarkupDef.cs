namespace YgomGame.MDMarkup
{
	public static class MDMarkupDef
	{
		public enum ContainerType
		{
			Board = 1,
			Pager = 2,
			Tabs = 3,
			Embed = 4,
			BoardPager = 5
		}

		public enum CloseButtonType
		{
			None = 0,
			Always = 1,
			ReachLast = 2
		}

		public enum MarkupType
		{
			None = 0,
			H1 = 1,
			H2 = 2,
			Text = 3,
			Image = 4,
			Table = 5,
			Separator = 6,
			Spacer = 7,
			HalfImageTextPage = 8,
			HalfImageMarkupPage = 9,
			HalfBannerMarkupPage = 10,
			FullImagePage = 11,
			FullTextPage = 12,
			EmbedContainerTab = 13,
			RawContainerTab = 14,
			CustomBoardPageHandler = 100
		}

		public enum TableRowStyle
		{
			Normal = 0,
			Header = 1
		}

		public enum TableCellValueType
		{
			Text = 0,
			Image = 1,
			Card = 2,
			Item = 3,
			Banner = 4,
			Button = 5
		}

		public enum CardSize
		{
			S = 0,
			M = 1,
			L = 2
		}

		public enum ItemSize
		{
			S = 0,
			M = 1,
			L = 2
		}

		public enum SpacerSize
		{
			S = 0,
			M = 1,
			L = 2
		}

		public enum ButtonStyle
		{
			S = 0,
			M = 1,
			L = 2
		}
	}
}
