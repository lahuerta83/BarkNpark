using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkNPark
{
    public enum ErrorCode
    {
        EXT_FAIL = 0,
        SALE_FAIL = 1,
        DIS_FAIL = 2,
        IN_FAIL = 3,
        OUT_FAIL = 4,
        DUR_INV = 5,
        NO_STAT = 6,
        STAT_FAIL = 7,
        PAY_FAIL = 8,
        SUCCESS = 200,
    }
    public class System
    {
        List<IStation> stations = new List<IStation>() { new Station(StationCode.STATION_0), new Station(StationCode.STATION_1), new Station(StationCode.STATIOn_2) };
        List<IAppointment> appointments = new List<IAppointment>() { };
        //Create User Profile
        bool createProile() { return true; }
        public List<IStation> listStations() { return stations; }

        public int CheckIn(StationCode code, string name, double duration)
        {
            IStation availStation = getFirstAvailableStation();
            if (availStation != null)
            {
                DateTime checkinTime = DateTime.Now;
                Appointment newappt = new Appointment(this, name, checkinTime,checkinTime.AddMinutes(duration));
                int confCode = newappt.checkin(code,checkinTime,duration);
                if ( confCode != (int)ErrorCode.SUCCESS)
                {
                    return confCode;
                }

                appointments.Add(newappt);
                return confCode;
            }
            else
            {
                return (int)ErrorCode.NO_STAT;
            }

            
        }

        public int Checkout(StationCode code, string name)
        {
            IAppointment relappt = getAppointmentByName(name);


            if (relappt.getStationCode() == code)
            {
                return relappt.checkout();
            }
            IStation brokenStation = this.GetStation(code);

            return (int)ErrorCode.OUT_FAIL;

        }

        public int requestextension(StationCode code, string name, double timeToAdd)
        {
            IAppointment relappt = getAppointmentByName(name);

            
            if (relappt.getStationCode() == code)
            {
                return relappt.extendTime(timeToAdd);
            }
            return (int)ErrorCode.EXT_FAIL;

        }

        public int addItem(StationCode code, string name,ItemType [] items)
        {
            IAppointment relappt = getAppointmentByName(name);


            if (relappt.getStationCode() == code)
            {
                return relappt.dispenseItem(items);
            }
            return (int)ErrorCode.DIS_FAIL;
        }

        public IStation getFirstAvailableStation()
        {
            foreach (IStation station in stations){
                if (station.isAvailable()) { return station; }
            }

            return null;
        }

        public IAppointment getAppointmentByName(string name)
        {
            foreach (IAppointment appt in appointments)
            {
                if (appt.getName() == name) return appt;
            }

            return null;
        }



        public IStation GetStation(StationCode code)
        {
            foreach (Station s in stations)
            {
                if (s.Code == code)
                {
                    return s;
                }
            }

            return null;
        }
                  
               

        public override string ToString()
        {
            Console.WriteLine("System Appointments: ");
            foreach (IAppointment appt in this.appointments)
            {
                Console.WriteLine(appt.ToString());
            }

            return "End Of System Stations";
        }
    }

    



    public class Program
    {

        public static void Main(string[] args)
        {
            

        }
    }
}
