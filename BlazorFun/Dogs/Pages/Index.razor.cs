﻿using Dogs.Code;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dogs.Pages
{
    public partial class Index
    {
        [Inject] DogsService DogsService { get; set; }

        private List<string> _dogs;
        private string _selectedBreed;
        private string _breedImage;
       
        protected override async Task OnInitializedAsync()
        {
            _dogs = await DogsService.GetDogs();
        }

        private async Task<IEnumerable<string>> SearchDogs(string searchText)
        {
            return await Task.FromResult(_dogs.Where(x => x.ToLower().Contains(searchText.ToLower())).ToList());
        }
      
        private async Task GetDogImage(MouseEventArgs e)
        {
            _breedImage = await DogsService.GetDogImage(_selectedBreed);
        }
    }
}
