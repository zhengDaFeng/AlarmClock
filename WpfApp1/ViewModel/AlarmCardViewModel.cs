using GalaSoft.MvvmLight;
using WpfApp1.Model;
using System.Threading.Tasks;
using System.Threading;
using System;

namespace WpfApp1.ViewModel
{
    public class AlarmCardViewModel : ViewModelBase
    {
        public AlarmCardViewModel ()
        {
            Task.Run(new Action(Process));
        }

        public AlarmModel AlarmModel { get; set; } = new AlarmModel();

        private bool _isAlarming = false;

        public void Process()
        {
            while (true)
            {
                if (AlarmModel.Enable)
                {
                    DateTime nowDateTime = DateTime.Now;

                    var dayOfWeek = nowDateTime.DayOfWeek;
                    if (!CheckEnable(dayOfWeek))
                    {
                        _isAlarming = false;
                        AlarmModel.Remain = "0小时0分钟0秒内";
                        Thread.Sleep(500);
                        continue;
                    }

                    DateTime alarmDateTime = GetDateTime(AlarmModel.Alarm);
                    TimeSpan timeSpan = alarmDateTime - nowDateTime;
                    if (timeSpan.TotalSeconds <= 0)
                    {
                        if (_isAlarming == false)
                        {
                            if (timeSpan.TotalSeconds > -3)
                            {
                                _isAlarming = true;
                                AlarmModel.Remain = "0小时0分钟0秒内";
                                System.Windows.MessageBox.Show($"{AlarmModel.Alarm}\r\n{AlarmModel.Remark}");
                            }
                            else
                            {
                                AlarmModel.Remain = "0小时0分钟0秒内";
                            }
                        }
                    }
                    else
                    {
                        _isAlarming = false;
                        int remainHours = timeSpan.Hours;
                        int remainMinutes = timeSpan.Minutes;
                        int remainSeconds = timeSpan.Seconds;
                        AlarmModel.Remain = remainHours.ToString() + "小时" + remainMinutes.ToString() + "分钟" + remainSeconds.ToString() + "秒内";
                    }
                }
                else
                {
                    _isAlarming = false;
                    AlarmModel.Remain = "0小时0分钟0秒内";
                    Thread.Sleep(400);
                }

                Thread.Sleep(100);
            }
        }

        private DateTime GetDateTime(string date)
        {
            DateTime tmp;
            if (DateTime.TryParse(date, out tmp))
            {
                return tmp;
            }
            throw new Exception();
        }

        private bool CheckEnable(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    return AlarmModel.DayOfWeekEnable[6];
                case DayOfWeek.Monday:
                    return AlarmModel.DayOfWeekEnable[0];
                case DayOfWeek.Tuesday:
                    return AlarmModel.DayOfWeekEnable[1];
                case DayOfWeek.Wednesday:
                    return AlarmModel.DayOfWeekEnable[2];
                case DayOfWeek.Thursday:
                    return AlarmModel.DayOfWeekEnable[3];
                case DayOfWeek.Friday:
                    return AlarmModel.DayOfWeekEnable[4];
                case DayOfWeek.Saturday:
                    return AlarmModel.DayOfWeekEnable[5];
                default:
                    throw new Exception();
            }
        }
    }
}
