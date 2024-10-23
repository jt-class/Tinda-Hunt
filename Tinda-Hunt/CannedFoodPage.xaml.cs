using System;
using System.Collections.Generic;
using Microsoft.Maui.Controls;
namespace Tinda_Hunt { 

public partial class CannedFoodPage : ContentPage
{
	public CannedFoodPage()
	{
		InitializeComponent();
            var cannedFoodList = new List<CannedFood>
            {
                new CannedFood { Name = "Mega Sardines", Image = "mega_sardines.png" },
                new CannedFood { Name = "Ligo Sardines", Image = "ligo_sardines.png" },
                new CannedFood { Name = "555 Sardines", Image = "fivefivefive_sardines.png" },
                new CannedFood { Name = "Century Tuna", Image = "century_tuna.png" },
                new CannedFood { Name = "Meat Loaf", Image = "meat_loaf.png" },
                new CannedFood { Name = "Corned Beef", Image = "corned_beef.png" },
                new CannedFood { Name = "Hunt's Pork & Beans", Image = "hunts_pork_beans.png" }
            };

            CollectionView cannedFoodCollection = this.FindByName<CollectionView>("cannedFoodCollectionView");
            cannedFoodCollection.ItemsSource = cannedFoodList;
        }
    }

    public class CannedFood
    {
        public string Name { get; set; }
        public string Image { get; set; }
    }
}
