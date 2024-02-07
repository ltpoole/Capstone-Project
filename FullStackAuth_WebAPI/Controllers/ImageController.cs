﻿using FullStackAuth_WebAPI.Data;
using FullStackAuth_WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using Image = FullStackAuth_WebAPI.Models.Image;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FullStackAuth_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ImageController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Image>>> GetAllImages()
        {
            return await _context.Images.Select(i => new Image()
            {
                Id = i.Id,
                Title = i.Title,
                Description = i.Description,
                ImageSrc = String.Format("{0}://{1}{2}/Images/{3}", Request.Scheme, Request.Host, Request.PathBase, i.Title)
            }).ToListAsync();
        }

        // POST: api/Images
        // This action method receives an Image object from a POST request.
        [HttpPost]
        public async Task<ActionResult<Image>> PostNewImage([FromForm] Image value)
        {
            // Save the image from the Image object to the Images folder.
            // The SaveImage method returns the name of the image, which is then assigned to the Title property.
            value.Title = await SaveImage(value.ImageFile);

            // Add the Image object to the Image table in the database and save changes.
            _context.Images.Add(value);
            _context.SaveChanges();

            // Return a 201 Created status code and the Image object.
            return StatusCode(201, value);
        }

        // This method saves an image file to the Images folder and returns the name of the image.
        [NonAction]
        public async Task<string> SaveImage(IFormFile imageFile)
        {
            // Create a new image name by taking the first 10 characters of the original file name (without the extension),
            // replacing spaces with dashes, and appending a timestamp. Then append the original extension to this name.
            string imageName = new String(Path.GetFileNameWithoutExtension(imageFile.FileName)
                .Take(10).ToArray()).Replace(' ', '-');
            imageName = imageName + DateTime.Now.ToString("yymmssfff") + Path.GetExtension(imageFile.FileName);

            // Combine the root path of the project, the Images folder, and the image name to get the image path.
            var imagePath = Path.Combine(_hostEnvironment.ContentRootPath, "Images", imageName);

            // Create a new file at the image path and copy the contents of the image file to it.
            using (var fileStream = new FileStream(imagePath, FileMode.Create))
            {
                await imageFile.CopyToAsync(fileStream);
            }

            // Return the name of the image.
            return imageName;
        }
    }
}
