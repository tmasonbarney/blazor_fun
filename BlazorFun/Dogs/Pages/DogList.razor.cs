using Dogs.Code;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dogs.Pages
{
    public partial class DogList
    {
        [Inject] DogsService DogsService { get; set; }
        public List<string> _dogs;

        protected override async Task OnInitializedAsync()
        {
            _dogs = await DogsService.GetDogs();
        }
    }
}
