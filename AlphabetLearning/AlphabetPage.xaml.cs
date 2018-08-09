using AlphabetLearning.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace AlphabetLearning
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class AlphabetPage : Page
    {

        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }


        public AlphabetPage()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
        }

        /// <summary>
        /// Populates the page with content passed during navigation. Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session. The state will be null the first time a page is visited.</param>
        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion
        private void A_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NextPage), "A.MP4");
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NextPage), "B.MP4");
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NextPage), "C.MP4");
        }

        private void D_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NextPage), "D.MP4");
        }

        private void E_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NextPage), "E.MP4");
        }

        private void F_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NextPage), "F.MP4");
        }

        private void G_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NextPage), "G.MP4");
        }

        private void H_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NextPage), "H.MP4");
        }

        private void I_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NextPage), "I.MP4");
        }

        private void J_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NextPage), "J.MP4");
        }

        private void K_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NextPage), "K.MP4");
        }

        private void L_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NextPage), "L.MP4");
        }

        private void M_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NextPage), "M.MP4");
        }

        private void N_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NextPage), "N.MP4");
        }

        private void O_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NextPage), "O.MP4");
        }

        private void P_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NextPage), "P.MP4");
        }

        private void Q_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NextPage), "Q.MP4");
        }

        private void R_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NextPage), "R.MP4");
        }

        private void S_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NextPage), "S.MP4");
        }

        private void T_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NextPage), "T.MP4");
        }

        private void U_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NextPage), "U.MP4");

        }
        private void V_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NextPage), "V.MP4");
        }

        private void W_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NextPage), "W.MP4");
        }

        private void X_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NextPage), "X.MP4");
        }

        private void Y_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NextPage), "Y.MP4");
        }

        private void Z_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NextPage), "Z.MP4");
        }
    }
}
