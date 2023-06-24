using FFmpegTranslator.DTOs;
using FFmpegTranslator.Services;
using Microsoft.AspNetCore.Mvc;

namespace FFmpegTranslator.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class FFmpegTranslatorController : ControllerBase
	{
		private readonly FFmpegTranslatorService translatorService;

		public FFmpegTranslatorController(FFmpegTranslatorService translatorService)
		{
			this.translatorService = translatorService;
		}

		[HttpPost]
		[Route("translate")]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public ActionResult Translate(FrontTextDTO frontText)
		{
			try
			{
				return Ok(this.translatorService.Translate(frontText));
			} catch (Exception ex)
			{
				// propper way to do it: having a middleware that handle errors but I didn't want to lose time on it 
				return BadRequest(ex.Message);
			}
		}
	}
}
