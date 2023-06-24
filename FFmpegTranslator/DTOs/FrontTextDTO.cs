namespace FFmpegTranslator.DTOs
{
	public class FrontTextDTO
	{
		public string InputPath { get; set; }
		public double Duration { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }
		public string OutputPath { get; set; }
		public string Text { get; set; }
		public int X { get; set; }
		public int Y { get; set; }
		public int FontSize { get; set; }
		public string FontColorHex { get; set; }
		public double StartTime { get; set; }
		public double EndTime { get; set; }
	}
}
