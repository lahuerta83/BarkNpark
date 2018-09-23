using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkNPark
{

    public class System
    {
        List<IStation> stations = new List<IStation>() { new Station(StationCode.STATION_0), new Station(StationCode.STATION_1), new Station(StationCode.STATIOn_2) };

        //Create User Profile
        bool createProile() { return true; }

        public Appointment SystemAppt { get; set; }

        public int CheckIn(StationCode code)
        {
            SystemAppt = new Appointment(this);
            return SystemAppt.checkin(code);
        }
        public int requestextension(string[] args) { return 0; }
        public int checkout(Appointment appt) { return appt.checkout(); }

        //List all available stations
        public List<IStation> listStations() { return stations; }

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

        //get appointments for a user
        public List<IAppointment> getUserAppointment(string username) { return new List<IAppointment>() { }; }

        //Adds item to an appointment
        public string addItem(IAppointment appointment, ItemType item) { return ""; }

        public bool processPayment(int total) { return true; }

        public override string ToString()
        {
            Console.WriteLine("System Stations: ");
            foreach (IStation station in this.listStations())
            {
                Console.WriteLine(station.ToString());
            }

            return "End Of System Stations";
        }
    }

    public enum StationCode
    {

        STATION_0 = 0,
        STATION_1 = 1,
        STATIOn_2 = 2
    }
    public interface IStation
    {
        bool isAvailable();
        int open_door();
        int check_out();


    }

    class Station : IStation
    {
        StationCode station_code;
        Random r = new Random();
        public bool Broken { get; set; }
        public bool Maintenance { get; set; }
        public bool Occupied { get; set; }
        public StationCode Code { get { return station_code; } }

        public Station(StationCode code)
        {
            station_code = code;
        }
        public bool isAvailable()
        {
            return !(Broken | Maintenance);
        }

        public int open_door()
        {
            Console.WriteLine("DOOR OPENED. CHECKEDIN TO " + station_code);
            Occupied = true;


            return r.Next(0, 10);
        }

        public int check_out()
        {
            Console.WriteLine("CHECKEDOUT OF " + station_code + " BYE!");
            Occupied = false;
            return r.Next(10, 20);
        }

        public override string ToString()
        {
            return station_code.ToString() + " Check-IN status: " + Occupied;
        }

    }


    public enum ItemType
    {
        DOG_TREAT = 1,
        WATER = 2,
        TOY = 3

    }


    public interface IAppointment

    {
        int checkin(StationCode station);
        bool extendTime(int duration);
        int checkout();
        bool durationValid();
        bool dispenseItem(ItemType item);

    }

    public class Appointment : IAppointment
    {
        System system;
        IStation appointment_station;
        public Appointment(System mySystem)
        {
            system = mySystem;
        }
        public int checkin(StationCode stationCode)
        {
            appointment_station = system.GetStation(stationCode);
            return appointment_station.open_door();
        }

        public int checkout()
        {
            return appointment_station.check_out();
        }

        public bool dispenseItem(ItemType item)
        {
            throw new NotImplementedException();
        }

        public bool durationValid()
        {
            throw new NotImplementedException();
        }

        public bool extendTime(int duration)
        {
            throw new NotImplementedException();
        }

        override public string ToString()
        {
            if (appointment_station != null)
            {
                return "This appointment station is : " + appointment_station.ToString();
            }
            else
            {
                return "This appointment does not have an associated staion yet.";
            }
        }
    }

    public class Program
    {

        public static void Main(string[] args)
        {
            System system = new System();

            Console.WriteLine(system.ToString());
            Console.WriteLine();

            int confirmation_code = system.CheckIn(StationCode.STATION_0);
            Console.WriteLine("Check In Confirmation Code: " + confirmation_code);
            Console.WriteLine();

            Appointment appointment = system.SystemAppt;
            Console.WriteLine(appointment.ToString());
            Console.WriteLine();

            Console.WriteLine(system.ToString());
            Console.WriteLine();

            int new_confirmation = system.checkout(system.SystemAppt);
            Console.WriteLine("Check Out Confirmation Code: " + new_confirmation);
            Console.WriteLine();

            Console.WriteLine(system.ToString());
            Console.WriteLine();

            Console.Read();

        }
    }
}
