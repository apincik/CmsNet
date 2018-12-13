﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
using Web.Areas.Cms.ViewModels;

namespace Web.Areas.Cms.Controllers
{
    [Area("Cms")]
    public class PhotoController : Controller
    {
        private IMapper _mapper;
        private IPhotoService _photoService;

        public PhotoController(
            IMapper mapper,
            IPhotoService photoService)
        {
            _mapper = mapper;
            _photoService = photoService;
        }

        public async Task<IActionResult> ToggleStatus(int id, int albumId)
        {
            await _photoService.ToggleStatusById(id);
            return RedirectToAction("Album", new { id = albumId });
        }

        public async Task<IActionResult> Album(int id)
        {
            var photos = await _photoService.ListAllByAlbumId(id);
            return View(new PhotoAlbumViewModel()
            {
                AlbumId = id,
                Photos = photos
            });
        }

        [HttpPost]
        public async Task<IActionResult> Upload(PhotoAlbumViewModel model)
        {
            await _photoService.UploadImages(model.AlbumId, model.Files);
            return RedirectToAction("Album", new { id = model.AlbumId });
        }
    }
}