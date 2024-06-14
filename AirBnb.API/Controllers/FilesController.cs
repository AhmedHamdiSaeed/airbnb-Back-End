using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AirBnb.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FilesController : ControllerBase
	{
		[HttpPost("UploadImage")]
		public ActionResult UploadFile(IFormFile? file)
		{
			//validation
			if (file == null)
			{
				return BadRequest("File not found");
			}
			if (file.Length is > 100_000_000 or <= 0)
			{
				return BadRequest("File size is not right");
			}
			string[] allowedExtentions = [".jpg", ".svg", ".png"];
			var fileExtention = Path.GetExtension(file.FileName);
			var isExtensionAllowed = allowedExtentions.Select(e => e.ToLower()).Contains(fileExtention);
			if (!isExtensionAllowed)
			{
				return BadRequest("File extention is not right");
			}
			//
			//save file
			var newFileName = $"{Guid.NewGuid()}{fileExtention}";
			var fileFullPath = Path.Combine(Directory.GetCurrentDirectory(), "Assets", newFileName);
			using var fileStream = new FileStream(fileFullPath, FileMode.Create);
			file.CopyTo(fileStream);
			//generate url
			var url = $"{Request.Scheme}://{Request.Host}/Assets/{newFileName}";

			//
			return Ok(new
			{
				FileName = newFileName,
				FileUrl = url,
			});
		}
	}
}
