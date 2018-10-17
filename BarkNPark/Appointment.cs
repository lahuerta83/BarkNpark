using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkNPark
{

    public interface IAppointment

    {
        int checkin(StationCode stationCode, DateTime checkin, double duration);
        int extendTime(double duration);
        int checkout();
        bool durationValid(DateTime checkInTime, double duration);
        int dispenseItem(ItemType[] items);
        string getName();
        StationCode getStationCode();
        DateTime getCheckInTime();
    }

    public class Appointment : IAppointment
    {
        System system;
        IStation appointmentStation;
        string appointmentName;
        DateTime appointmentCheckin;
        DateTime appointmentCheckout;
        List<ISale> appointmentSales = new List<ISale>();
        List<ItemType> hoursInStation = new List<ItemType>();
        public Appointment(System mySystem, string name, DateTime checkinTime, DateTime checkoutTime)
        {
            system = mySystem;
            appointmentName = name;
            appointmentCheckin = checkinTime;
            appointmentCheckout = checkoutTime;
        }

        public string getName()
        {
            return this.appointmentName;
        }
        public StationCode getStationCode()
        {
            return appointmentStation.getCode();
        }
        public DateTime getCheckInTime()
        {
            return appointmentCheckin;
        }
        public int checkin(StationCode stationCode, DateTime checkin, double duration)
        {
            if (durationValid(checkin, duration))
            {

                int confCode = processSale(hoursInStation.ToArray<ItemType>());
                appointmentStation.open_door();

                return confCode;
            }               

            return (int)ErrorCode.DUR_INV;
        }

        public int checkout()
        {
            return appointmentStation.check_out();
        }

        public int dispenseItem(ItemType[] items)
        {
            int confCode = processSale(items);
            this.appointmentStation.dispenseItem(items);
            return (int)ErrorCode.SUCCESS;
        }

        public int processSale(ItemType[] items)
        {
            Sale newSale = new Sale(items);
            ISale sale = (ISale)newSale;
            int confCode = sale.processPayment("email");

            Console.WriteLine();
            Console.Write(sale.ToString());
            Console.WriteLine();
            appointmentSales.Add(sale);

            return confCode;
        }
        public int extendTime(double duration)
        {
            DateTime temp = appointmentCheckout;
            int confCode = -1;
            if (durationValid(this.getCheckInTime(), duration))
            {
                confCode = processSale(hoursInStation.ToArray<ItemType>());
                appointmentCheckout = appointmentCheckout.AddMinutes(duration);
            }

            return confCode;


        }

        public bool durationValid(DateTime checkInTime, double duration)
        {
            DateTime proposedCheckOut = checkInTime.AddMinutes(duration);
            TimeSpan minutesInStation = proposedCheckOut - checkInTime;
            if(minutesInStation.TotalHours >= 4)
            {
                return false;
            }
            hoursInStation.Clear();
            for(int i = 0; i < minutesInStation.TotalHours; i++)
            {
                hoursInStation.Add(ItemType.HOUR);
            }
            return true;
        }


        override public string ToString()
        {
            if (appointmentStation != null)
            {
                return "This appointment station is : " + appointmentStation.ToString();
            }
            else
            {
                return "This appointment does not have an associated staion yet.";
            }
        }
    }
}
