﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApiOefening.Logic
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Eindresultaten : ContentPage
    {
        public Eindresultaten()
        {
            InitializeComponent();
        }

        private async void SearchCocktailNameButton_Clicked(object sender, EventArgs e)
        {
            var cocktails = await CocktailLogic.GetCocktailsByName(CocktailNameEntry.Text);
            CocktailListView.ItemsSource = cocktails;
        }
    }
}