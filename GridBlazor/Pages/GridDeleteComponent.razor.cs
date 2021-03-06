﻿using GridShared.Columns;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace GridBlazor.Pages
{
    public partial class GridDeleteComponent<T> : ICustomGridComponent<T>
    {
        [CascadingParameter(Name = "GridComponent")]
        protected GridComponent<T> GridComponent { get; set; }

        [Parameter]
        public T Item { get; set; }

        protected async Task DeleteItem()
        {
            await GridComponent.DeleteItem();
        }

        protected void BackButtonClicked()
        {
            GridComponent.BackButton();
        }
    }
}