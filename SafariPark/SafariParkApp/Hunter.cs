using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    internal class Hunter : Person
    {
        private string _camera;
        private string _firstname;
        private string _lastname;
        public Hunter()
        {

        }
        public Hunter(string fName, string lName, string camera = "") : base(fName, lName)
        {
            this._camera = camera;
            _firstname= fName;
            _lastname= lName;
        }

        public string FirstName { get => _firstname; set => _firstname = value; }
        public string LastName { get => _lastname; set => _lastname = value; }

        public string Shoot()
        {
            return $"{GetFullName()} has taken a photo with their {_camera}";
        }

        public override string ToString()
        {
            return $"{base.ToString()} Camera: {_camera}";
        }
    }
}
