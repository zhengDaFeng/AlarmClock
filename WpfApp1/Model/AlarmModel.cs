using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace WpfApp1.Model
{
    public class AlarmModel : ObservableObject
    {
        private bool enable = true;
        private string alarm = "18:00";
        private string remain = "0小时0分钟内";
        private string remark = "备注";
        private ObservableCollection<bool> day = new ObservableCollection<bool>() { true, true, true, true, true, true, true };

        public bool Enable
        {
            get => enable;
            set => Set(ref enable, value);
        }
        public string Alarm
        {
            get => alarm;
            set => Set(ref alarm, value);
        }
        public string Remain
        {
            get => remain;
            set => Set(ref remain, value);
        }
        public string Remark
        {
            get => remark;
            set => Set(ref remark, value);
        }
        public ObservableCollection<bool> DayOfWeekEnable
        {
            get => day;
            set => Set(ref day, value);
        }
    }
}
