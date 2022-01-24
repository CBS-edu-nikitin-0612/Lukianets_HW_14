using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class ClassRoom
    {
        private int _roomNumber;
        private List<Pupil> _pupilslist;

        public int RoomNumber
        {
            get => _roomNumber;
            set
            {
                if (value > 0)
                    _roomNumber = value;
                else
                    Console.WriteLine("Wrong room number");
            }
        }
        public ClassRoom(int roomnumber, Pupil p1, Pupil p2)
        {
            RoomNumber = roomnumber;
            _pupilslist = new List<Pupil>();
            _pupilslist.Add(p1);
            _pupilslist.Add(p2);

        }

        public ClassRoom(int roomnumber, Pupil p1, Pupil p2, Pupil p3) : this(roomnumber, p1, p2)
        {
            _pupilslist.Add(p3);
        }
        public ClassRoom(int roomnumber, Pupil p1, Pupil p2, Pupil p3, Pupil p4) : this(roomnumber, p1, p2, p3)
        {
            _pupilslist.Add(p4);
        }
        public override string ToString()
        {
            Console.WriteLine($"Classroom number {RoomNumber}:\n");
            foreach (Pupil p in _pupilslist)
            {
                p.Study();
                p.Read();
                p.Write();
                p.Relax();
                Console.WriteLine();
            }
            return "\n";
        }
    }
}
