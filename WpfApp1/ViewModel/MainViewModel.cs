using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
            ///
            AlarmCardViewModelList = new ObservableCollection<AlarmCardViewModel>()
            {
                (AlarmCardViewModel)ViewModelLocator.GetViewModel<AlarmCardViewModel>("alarm1"),
                (AlarmCardViewModel)ViewModelLocator.GetViewModel<AlarmCardViewModel>("alarm2"),
                (AlarmCardViewModel)ViewModelLocator.GetViewModel<AlarmCardViewModel>("alarm3"),
                (AlarmCardViewModel)ViewModelLocator.GetViewModel<AlarmCardViewModel>("alarm4")
            };
            GetConfig();

            CmdWindowClosing = new RelayCommand(WindowClosing);
        }

        public RelayCommand CmdWindowClosing { get; private set; }

        public ObservableCollection<AlarmCardViewModel> AlarmCardViewModelList { get; set; }

        private void WindowClosing()
        {
            SaveConfig();
        }

        private void GetConfig()
        {
            if (Properties.Settings.Default.DayOfWeek1 == null)
            {
                Properties.Settings.Default.DayOfWeek1 = new bool[7] { true, true, true, true, true, true, true };
            }
            if (Properties.Settings.Default.DayOfWeek2 == null)
            {
                Properties.Settings.Default.DayOfWeek2 = new bool[7] { true, true, true, true, true, true, true };
            }
            if (Properties.Settings.Default.DayOfWeek3 == null)
            {
                Properties.Settings.Default.DayOfWeek3 = new bool[7] { true, true, true, true, true, true, true };
            }
            if (Properties.Settings.Default.DayOfWeek4 == null)
            {
                Properties.Settings.Default.DayOfWeek4 = new bool[7] { true, true, true, true, true, true, true };
            }

            AlarmCardViewModelList[0].AlarmModel.Enable = Properties.Settings.Default.Enable1;
            AlarmCardViewModelList[0].AlarmModel.Alarm = Properties.Settings.Default.AlarmTime1;
            AlarmCardViewModelList[0].AlarmModel.Remark = Properties.Settings.Default.Remark1;
            AlarmCardViewModelList[0].AlarmModel.DayOfWeekEnable[0] = Properties.Settings.Default.DayOfWeek1[0];
            AlarmCardViewModelList[0].AlarmModel.DayOfWeekEnable[1] = Properties.Settings.Default.DayOfWeek1[1];
            AlarmCardViewModelList[0].AlarmModel.DayOfWeekEnable[2] = Properties.Settings.Default.DayOfWeek1[2];
            AlarmCardViewModelList[0].AlarmModel.DayOfWeekEnable[3] = Properties.Settings.Default.DayOfWeek1[3];
            AlarmCardViewModelList[0].AlarmModel.DayOfWeekEnable[4] = Properties.Settings.Default.DayOfWeek1[4];
            AlarmCardViewModelList[0].AlarmModel.DayOfWeekEnable[5] = Properties.Settings.Default.DayOfWeek1[5];
            AlarmCardViewModelList[0].AlarmModel.DayOfWeekEnable[6] = Properties.Settings.Default.DayOfWeek1[6];

            AlarmCardViewModelList[1].AlarmModel.Enable = Properties.Settings.Default.Enable2;
            AlarmCardViewModelList[1].AlarmModel.Alarm = Properties.Settings.Default.AlarmTime2;
            AlarmCardViewModelList[1].AlarmModel.Remark = Properties.Settings.Default.Remark2;
            AlarmCardViewModelList[1].AlarmModel.DayOfWeekEnable[0] = Properties.Settings.Default.DayOfWeek2[0];
            AlarmCardViewModelList[1].AlarmModel.DayOfWeekEnable[1] = Properties.Settings.Default.DayOfWeek2[1];
            AlarmCardViewModelList[1].AlarmModel.DayOfWeekEnable[2] = Properties.Settings.Default.DayOfWeek2[2];
            AlarmCardViewModelList[1].AlarmModel.DayOfWeekEnable[3] = Properties.Settings.Default.DayOfWeek2[3];
            AlarmCardViewModelList[1].AlarmModel.DayOfWeekEnable[4] = Properties.Settings.Default.DayOfWeek2[4];
            AlarmCardViewModelList[1].AlarmModel.DayOfWeekEnable[5] = Properties.Settings.Default.DayOfWeek2[5];
            AlarmCardViewModelList[1].AlarmModel.DayOfWeekEnable[6] = Properties.Settings.Default.DayOfWeek2[6];

            AlarmCardViewModelList[2].AlarmModel.Enable = Properties.Settings.Default.Enable3;
            AlarmCardViewModelList[2].AlarmModel.Alarm = Properties.Settings.Default.AlarmTime3;
            AlarmCardViewModelList[2].AlarmModel.Remark = Properties.Settings.Default.Remark3;
            AlarmCardViewModelList[2].AlarmModel.DayOfWeekEnable[0] = Properties.Settings.Default.DayOfWeek3[0];
            AlarmCardViewModelList[2].AlarmModel.DayOfWeekEnable[1] = Properties.Settings.Default.DayOfWeek3[1];
            AlarmCardViewModelList[2].AlarmModel.DayOfWeekEnable[2] = Properties.Settings.Default.DayOfWeek3[2];
            AlarmCardViewModelList[2].AlarmModel.DayOfWeekEnable[3] = Properties.Settings.Default.DayOfWeek3[3];
            AlarmCardViewModelList[2].AlarmModel.DayOfWeekEnable[4] = Properties.Settings.Default.DayOfWeek3[4];
            AlarmCardViewModelList[2].AlarmModel.DayOfWeekEnable[5] = Properties.Settings.Default.DayOfWeek3[5];
            AlarmCardViewModelList[2].AlarmModel.DayOfWeekEnable[6] = Properties.Settings.Default.DayOfWeek3[6];

            AlarmCardViewModelList[3].AlarmModel.Enable = Properties.Settings.Default.Enable4;
            AlarmCardViewModelList[3].AlarmModel.Alarm = Properties.Settings.Default.AlarmTime4;
            AlarmCardViewModelList[3].AlarmModel.Remark = Properties.Settings.Default.Remark4;
            AlarmCardViewModelList[3].AlarmModel.DayOfWeekEnable[0] = Properties.Settings.Default.DayOfWeek4[0];
            AlarmCardViewModelList[3].AlarmModel.DayOfWeekEnable[1] = Properties.Settings.Default.DayOfWeek4[1];
            AlarmCardViewModelList[3].AlarmModel.DayOfWeekEnable[2] = Properties.Settings.Default.DayOfWeek4[2];
            AlarmCardViewModelList[3].AlarmModel.DayOfWeekEnable[3] = Properties.Settings.Default.DayOfWeek4[3];
            AlarmCardViewModelList[3].AlarmModel.DayOfWeekEnable[4] = Properties.Settings.Default.DayOfWeek4[4];
            AlarmCardViewModelList[3].AlarmModel.DayOfWeekEnable[5] = Properties.Settings.Default.DayOfWeek4[5];
            AlarmCardViewModelList[3].AlarmModel.DayOfWeekEnable[6] = Properties.Settings.Default.DayOfWeek4[6];
        }

        private void SaveConfig()
        {
            Properties.Settings.Default.Enable1 = AlarmCardViewModelList[0].AlarmModel.Enable;
            Properties.Settings.Default.Enable2 = AlarmCardViewModelList[1].AlarmModel.Enable;
            Properties.Settings.Default.Enable3 = AlarmCardViewModelList[2].AlarmModel.Enable;
            Properties.Settings.Default.Enable4 = AlarmCardViewModelList[3].AlarmModel.Enable;

            Properties.Settings.Default.DayOfWeek1[0] = AlarmCardViewModelList[0].AlarmModel.DayOfWeekEnable[0];
            Properties.Settings.Default.DayOfWeek1[1] = AlarmCardViewModelList[0].AlarmModel.DayOfWeekEnable[1];
            Properties.Settings.Default.DayOfWeek1[2] = AlarmCardViewModelList[0].AlarmModel.DayOfWeekEnable[2];
            Properties.Settings.Default.DayOfWeek1[3] = AlarmCardViewModelList[0].AlarmModel.DayOfWeekEnable[3];
            Properties.Settings.Default.DayOfWeek1[4] = AlarmCardViewModelList[0].AlarmModel.DayOfWeekEnable[4];
            Properties.Settings.Default.DayOfWeek1[5] = AlarmCardViewModelList[0].AlarmModel.DayOfWeekEnable[5];
            Properties.Settings.Default.DayOfWeek1[6] = AlarmCardViewModelList[0].AlarmModel.DayOfWeekEnable[6];

            Properties.Settings.Default.DayOfWeek2[0] = AlarmCardViewModelList[1].AlarmModel.DayOfWeekEnable[0];
            Properties.Settings.Default.DayOfWeek2[1] = AlarmCardViewModelList[1].AlarmModel.DayOfWeekEnable[1];
            Properties.Settings.Default.DayOfWeek2[2] = AlarmCardViewModelList[1].AlarmModel.DayOfWeekEnable[2];
            Properties.Settings.Default.DayOfWeek2[3] = AlarmCardViewModelList[1].AlarmModel.DayOfWeekEnable[3];
            Properties.Settings.Default.DayOfWeek2[4] = AlarmCardViewModelList[1].AlarmModel.DayOfWeekEnable[4];
            Properties.Settings.Default.DayOfWeek2[5] = AlarmCardViewModelList[1].AlarmModel.DayOfWeekEnable[5];
            Properties.Settings.Default.DayOfWeek2[6] = AlarmCardViewModelList[1].AlarmModel.DayOfWeekEnable[6];

            Properties.Settings.Default.DayOfWeek3[0] = AlarmCardViewModelList[2].AlarmModel.DayOfWeekEnable[0];
            Properties.Settings.Default.DayOfWeek3[1] = AlarmCardViewModelList[2].AlarmModel.DayOfWeekEnable[1];
            Properties.Settings.Default.DayOfWeek3[2] = AlarmCardViewModelList[2].AlarmModel.DayOfWeekEnable[2];
            Properties.Settings.Default.DayOfWeek3[3] = AlarmCardViewModelList[2].AlarmModel.DayOfWeekEnable[3];
            Properties.Settings.Default.DayOfWeek3[4] = AlarmCardViewModelList[2].AlarmModel.DayOfWeekEnable[4];
            Properties.Settings.Default.DayOfWeek3[5] = AlarmCardViewModelList[2].AlarmModel.DayOfWeekEnable[5];
            Properties.Settings.Default.DayOfWeek3[6] = AlarmCardViewModelList[2].AlarmModel.DayOfWeekEnable[6];

            Properties.Settings.Default.DayOfWeek4[0] = AlarmCardViewModelList[3].AlarmModel.DayOfWeekEnable[0];
            Properties.Settings.Default.DayOfWeek4[1] = AlarmCardViewModelList[3].AlarmModel.DayOfWeekEnable[1];
            Properties.Settings.Default.DayOfWeek4[2] = AlarmCardViewModelList[3].AlarmModel.DayOfWeekEnable[2];
            Properties.Settings.Default.DayOfWeek4[3] = AlarmCardViewModelList[3].AlarmModel.DayOfWeekEnable[3];
            Properties.Settings.Default.DayOfWeek4[4] = AlarmCardViewModelList[3].AlarmModel.DayOfWeekEnable[4];
            Properties.Settings.Default.DayOfWeek4[5] = AlarmCardViewModelList[3].AlarmModel.DayOfWeekEnable[5];
            Properties.Settings.Default.DayOfWeek4[6] = AlarmCardViewModelList[3].AlarmModel.DayOfWeekEnable[6];

            Properties.Settings.Default.Save();
        }
    }
}