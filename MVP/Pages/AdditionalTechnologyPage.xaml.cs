﻿using MVP.Services.Interfaces;
using Xamarin.Forms;

namespace MVP.Pages
{
    public partial class AdditionalTechnologyPage
    {
        public AdditionalTechnologyPage(IAnalyticsService analyticsService)
            : base(analyticsService) => InitializeComponent();

        void CollectionView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
        {
            appFrame.ShadowOpacity = e.VerticalOffset / 50 > 1 ? 1 : e.VerticalOffset / 50;
        }
    }
}