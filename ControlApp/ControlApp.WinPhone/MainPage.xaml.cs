﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainPage.xaml.cs" company="">
//   
// </copyright>
// <summary>
//   An empty page that can be used on its own or navigated to within a Frame.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

 // The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ControlApp.WinPhone
{
    using Windows.UI.Xaml.Navigation;

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainPage"/> class.
        /// </summary>
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;

            this.LoadApplication(new ControlApp.AppControl());
        }

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">
        /// Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.
        /// </param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        #endregion
    }
}