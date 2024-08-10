using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAuthentication.Classes
{
    [FirestoreData]
    internal class UserData
    {
        [FirestoreProperty]
        public string Name { get; set; }

        [FirestoreProperty]
        public string UserNameorEmail { get; set; }

        [FirestoreProperty]
        public string Gender { get; set; }

        [FirestoreProperty]
        public string DateofBirth { get; set; }

        [FirestoreProperty]
        public string Address { get; set; }

        [FirestoreProperty]
        public string Password { get; set; }


    }
}
