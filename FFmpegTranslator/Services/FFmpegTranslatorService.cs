using FFmpegTranslator.DTOs;
using System.Globalization;
using System.Text.RegularExpressions;

namespace FFmpegTranslator.Services
{
	public class FFmpegTranslatorService
	{
		public string Translate(FrontTextDTO frontText)
		{
			ValidateFrontText(frontText);
			return $@"ffmpeg -i {frontText.InputPath} -vf drawtext=""enable='between(t,{OneDecimal(frontText.StartTime)},{OneDecimal(frontText.EndTime)})':text='{frontText.Text}':fontcolor={frontText.FontColorHex}:fontsize={frontText.FontSize}:x={frontText.X}:y={frontText.Y}"" {frontText.OutputPath}";
		}

		private static void ValidateFrontText(FrontTextDTO frontTextDTO)
		{
			ValidateCoordinates(frontTextDTO.X, frontTextDTO.Y, frontTextDTO.Width, frontTextDTO.Height);
			ValidateClipTime(frontTextDTO.StartTime, frontTextDTO.EndTime, frontTextDTO.Duration);
			ValidateColor(frontTextDTO.FontColorHex);
			ValidateFontSize(frontTextDTO.FontSize);
		}

		private static void ValidateCoordinates(int x, int y, int width, int height)
		{
			if (x < 0 || y < 0 || x > width || y > height)
				throw new Exception("Invalid X,Y coordinate");
		}

		private static void ValidateClipTime(double start, double end, double duration)
		{
			if (duration <= 0)
				throw new Exception("Invalid Duration");
			if (start < 0 || start > duration)
				throw new Exception("Invalid Start Time");
			if (end < 0 || end > duration || end < start)
				throw new Exception("Invalid End Time");
		}


		private static void ValidateColor(string color)
		{
			// For this part I took the regex from the answer of https://stackoverflow.com/questions/1636350/how-to-identify-a-given-string-is-hex-color-format
			// and changed it a little so it's start with 0x instead of # and forced the format to be 6 characters since I don't know about ffmpeg.
			if (!Regex.IsMatch(color, "^0x(?:[0-9a-fA-F]{6})$"))
				throw new Exception("Invalid Color: format should be 0x000000");

		}

		private static void ValidateFontSize(int size)
		{
			if (size < 0)
				throw new Exception("Invalid Font Size");
		}

		private static string OneDecimal(double number)
		{
			NumberFormatInfo nfi = new NumberFormatInfo();
			nfi.NumberDecimalSeparator = ".";
			return String.Format(nfi, "{0:0.0}", number);
		}
	}
}
